using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using AForge.Video;
using AForge.Video.DirectShow;

namespace InstantReplayApp
{
    public class MainManager
    {
        #region Variables privées
        private const int DEFAULT_REPLAY_INDEX = 0;
        private const int DEFAULT_PICTUREBOX_RESOLUTION_POURCENTAGE = 100;

        private FrmMain _frmMain;
        private FrmVideoDisplay _liveDisplay;
        private FrmVideoDisplay _replayDisplay;
        private FrmSettings _frmSettings;

        private DisplayReplay _frmReplay;
        private LiveInputManager _liveInputManager;
        private ReplayManager _replayManager;

        private int _intervalFPS = ReplayManager.DEFAULT_PLAYBACK_POURCENTAGE;
        private int _replayIndex = DEFAULT_REPLAY_INDEX;

        private int selectedCameraIndex = -1;
        private List<Tuple<string, char, Action>> _functions;

        public static readonly char[] DEFAULT_COMMAND_SHORTCUTS =
            new char[] {
                        'i', 'o', 'w', 'x', 'c', 'e', 'r', 't', 'z', 'a', 's', 'd', 'j', 'k', 'l', 'n', 'b'
            };

        #endregion

        #region GETTER / SETTER publiques
        public FrmMain FrmMain { get => _frmMain; set => _frmMain = value; }
        internal LiveInputManager LiveInputManager { get => _liveInputManager; set => _liveInputManager = value; }
        internal ReplayManager ReplayManager { get => _replayManager; set => _replayManager = value; }
        public DisplayReplay FrmReplay { get => _frmReplay; set => _frmReplay = value; }
        public int IntervalPourcentage { get => _intervalFPS; set => _intervalFPS = value; }
        public FrmVideoDisplay LiveDisplay { get => _liveDisplay; set => _liveDisplay = value; }
        public FrmVideoDisplay ReplayDisplay { get => _replayDisplay; set => _replayDisplay = value; }
        public FrmSettings FrmSettings { get => _frmSettings; set => _frmSettings = value; }
        public List<Tuple<string, char, Action>> Functions { get => _functions; set => _functions = value; }
        #endregion

        /// <summary>
        /// Boolean retournant le statut du Replay (Est-ce qu'il afficher le live ou non)
        /// </summary>
        public bool IsReplayLive
        {
            set
            {
                this.ReplayManager.IsReplayLive = value;
            }
            get
            {
                return this.ReplayManager.IsReplayLive;
            }
        }

        /// <summary>
        /// Constructeur par défaut du manager
        /// </summary>
        /// <param name="a_FrmMain">la form parente</param>
        public MainManager(FrmMain a_FrmMain)
        {
            this.FrmMain = a_FrmMain;
            this.LiveInputManager = new LiveInputManager(this);
            this.ReplayManager = new ReplayManager(this); 

            this.ReplayManager.IsReplayLive = true;
            this.FrmReplay = new DisplayReplay(this);
            this.FrmSettings = new FrmSettings(this);

            this.SetPictureboxSizes(DEFAULT_PICTUREBOX_RESOLUTION_POURCENTAGE);

            this.LiveDisplay = null;
            this.ReplayDisplay = null;

            this.LoadSpeedsFromDisk();
            this.SetShortcuts();
            this.SetUpFunctions();
        }

        #region LIVE
        /// <summary>
        /// Permet de démarrer l'affichage live de la caméra sélectionnée
        /// </summary>
        /// <param name="selectedInputIndex">l'index de la caméra sélectionnée</param>
        public void StartStream(int selectedInputIndex)
        {
            (Size full, Size small, int fps) = this.LiveInputManager.StartStream(selectedInputIndex);

            this.FrmMain.ChangeInputResolutionLabel(full, fps);
            this.FrmMain.ChangeDisplayResolutionLabel(small);
            //this.FrmMain.ChangePictureBoxResolution(small);
            //this.FrmMain.ChangeReplayResolution(small);

            this.ReplayManager.ReplaySize = small;
        }

        public FilterInfoCollection GetVideoCaptureDevice()
        {
            return this.LiveInputManager.FilterInfoCollection;
        }

        /// <summary>
        /// Mise en arret du stream
        /// </summary>
        public void StopStream()
        {
            this.LiveInputManager.StopStream();
            this.FrmMain.ChangeLiveWarningVisibility();
        }

        /// <summary>
        /// Récupère toutes les entrées caméras de l'ordinateur 
        /// </summary>
        /// <returns>Une liste avec toutes les caméras</returns>
        public FilterInfoCollection LoadInputList()
        {
            return this.LiveInputManager.LoadInputList();
        }

        /// <summary>
        /// Formattage et affichage de la frame dans le pictureBox LIVE
        /// </summary>
        /// <param name="a_Bitmap">La frame à afficher</param>
        public void DisplayLiveImage(Bitmap a_Bitmap)
        {
            Bitmap resized = new Bitmap(a_Bitmap, this.LiveInputManager.LiveSize);
            this.FrmMain.DisplayLiveImage(resized);
            this.DisplayLiveSecondViewer(resized);
        }

        #endregion

        #region REPLAY
        /// <summary>
        /// Formattage et affichage de la frame dans le pictureBox REPLAY
        /// </summary>
        /// <param name="a_Bitmap">La frame à afficher</param>
        public void DisplayReplayImage(Bitmap a_Bitmap)
        {
            Bitmap resized = new Bitmap(a_Bitmap, this.ReplayManager.ReplaySize);
            this.FrmMain.DisplayReplayImage(resized);
            this.DisplayReplaySecondViewer(resized);
        }

        public void ChangeReplayLiveState(bool state)
        {
            this.IsReplayLive = state;
        }

        public void ChangeReplayLiveState()
        {
            this.IsReplayLive = !this.IsReplayLive;
        }

        /// <summary>
        /// Convertir le buffer en vidéo
        /// </summary>
        public void ConvertToVideo()
        {
            Thread thread = new Thread(() => this.ReplayManager.ConvertToVideo(this));

            thread.Start();
        }

        public void Final(string text, Color c)
        {
            this.FrmMain.ChangeStatusColor(c);
            this.FrmMain.UpdateStatus(text);
        }

        /// <summary>
        /// Ajouter une image dans la liste des images du buffer
        /// </summary>
        /// <param name="bmp">l'image à ajouter au buffer</param>
        public void AddImageToBuffer(Bitmap bmp)
        {
            this.ReplayManager.SaveImage(bmp);
        }

        /// <summary>
        /// Permet de mettre a jour le chemin d'accès au dossier d'enregistrement
        /// </summary>
        /// <param name="path">le chemin complet jusqu'au dossier</param>
        public void SetSavePath(string path)
        {
            Properties.Settings.Default.SavePath = path;
            this.ReplayManager.SetSavePath(path);
        }

        /// <summary>
        /// Récupère le chemin d'acces au dossier des replay
        /// </summary>
        /// <returns>Le chemin d'acces au dossier</returns>
        public string GetSavePath(){
            return this.ReplayManager.SavePath;
        }

        /// <summary>
        /// Démarre le buffer
        /// </summary>
        public void StartBuffer()
        {
            this.ReplayManager.StartBuffer();
        }

        #region VIDEO CONTROL
        /// <summary>
        /// Un marquage out à été notifié
        /// </summary>
        public void Cut()
        {
            this.ReplayManager.Cut();
            this.StreamReplay();
            this.FrmMain.UpdatePourcentageSpeed();
            this.ReplayTick(0);
        }

        /// <summary>
        /// Un marquage IN à été notifié
        /// </summary>
        public void In()
        {
            this.FrmMain.StopReplayTimer();

            this.ReplayManager.In(this._replayIndex);
            this._replayIndex = DEFAULT_REPLAY_INDEX;

            this.StreamReplay();
            this.ReplayTick(0);
        }

        /// <summary>
        /// Un marquage OUT à été notifié
        /// </summary>
        public void Out()
        {
            this.FrmMain.StopReplayTimer();

            this.ReplayManager.Out(this._replayIndex);
            this._replayIndex = DEFAULT_REPLAY_INDEX;

            this.StreamReplay();
            this.ReplayTick(0);
        }

        /// <summary>
        /// Réinitialiser la sélection faite dans le replay
        /// </summary>
        public void ClearSelection()
        {
            this.ReplayManager.ClearSelection();
            this.FrmMain.UpdateTrackBarReplayMaximum(this.ReplayManager.ToDisplay.Count);
        }

        /// <summary>
        /// Permet de mettre a jour l'affichage de la frame du replay en fonction de son index
        /// </summary>
        /// <param name="index">l'index de la frame sélectionnée</param>
        public void ChangeReplayPosition(int index)
        {
            if (index >= 0 && index < this.ReplayManager.ToDisplay.Count)
            {
                this._replayIndex = index;
            }
        }
        #endregion

        /// <summary>
        /// Permet de mettre a jour le boutton sur la forme avec le nombre de secondes qui sont enregistrées dans le buffer
        /// </summary>
        public void SecondsInBuffer()
        {
            this.FrmMain.UpdateBufferButton(this.ReplayManager.Buffer.SecondsInBuffer().ToString());
        }

        /// <summary>
        /// Permet de visionner en boucle selection dans la picturebox de replay
        /// </summary>
        public void StreamReplay()
        {
            this._replayIndex = DEFAULT_REPLAY_INDEX;
            int interval = this.ReplayManager.GetIntervalBasedOnFPS();
            this.FrmMain.SetReplayTimerInterval(interval);
            this.FrmMain.StartReplayTimer();
            this.FrmMain.UpdateTrackBarReplayMaximum(this.ReplayManager.ToDisplay.Count);
            this.FrmMain.UpdateReplaySpeedTrackbar(ReplayManager.MIN_POURCENTAGE, ReplayManager.MAX_POURCENTAGE, ReplayManager.DEFAULT_PLAYBACK_POURCENTAGE);
        }

        /// <summary>
        /// Remet les FPS du replay manager à la valeur par défaut
        /// </summary>
        public void ResetPlayBackFPS()
        {
            this.ReplayManager.ResetFPS();
        }

        /// <summary>
        /// Ce produit a chaque tick d'un timer
        /// </summary>
        public void StreamReplayIntervalTick()
        {
            this.DisplayReplayImage(this.ReplayManager.ToDisplay[this._replayIndex]);
            this.FrmMain.UpdateTrackBarReplayValue(this._replayIndex);
            this._replayIndex++;

            if (this._replayIndex >= this.ReplayManager.ToDisplay.Count)
                this._replayIndex = DEFAULT_REPLAY_INDEX;

            GC.Collect();
        }

        public void SlowDown(int amount)
        {
            this.ReplayManager.PlaybackPourcentage -= amount;
        }

        public void SpeedUp(int amount)
        {
            this.ReplayManager.PlaybackPourcentage += amount;
        }

        public int SetInterval()
        {
            int interval = this.ReplayManager.SetIntervalFPS(this.ReplayManager.PlaybackPourcentage);
            this.ReplayTick(0);
            return interval;
        }

        #region Speed

        /// <summary>
        /// Permet de récupérer les vitesses de lecture du replay
        /// </summary>
        /// <returns>une liste de 6 int coresspondant au vitesse en %</returns>
        public int[] GetSpeeds()
        {
            return this.ReplayManager.Speeds;
        }

        /// <summary>
        /// Retourne la vitesse à l'index du tableau
        /// </summary>
        /// <param name="index">l'index du tableau</param>
        /// <returns>la vitesse</returns>
        public int GetSpeed(int index)
        {
            return this.ReplayManager.GetSpeed(index);
        }

        /// <summary>
        /// Sauvegarder les vitesses de scroll dans les settings
        /// </summary>
        public void SaveSpeedsToDisk()
        {
            Properties.Settings.Default.Speeds = this.GetSpeeds();
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Changer toutes les vitesses
        /// </summary>
        /// <param name="speeds">les nouvelles vitesses</param>
        public void SetSpeeds(int[] speeds)
        {
            this.ReplayManager.Speeds = speeds;
            this.SaveSpeedsToDisk();
        }

        /// <summary>
        /// Permet de changer une des vitesses
        /// </summary>
        /// <param name="index">l'index de la vitesse a changer</param>
        /// <param name="speed">la nouvelle vitesse</param>
        public void SetSpeed(int index, int speed)
        {
            this.ReplayManager.SetSpeed(index, speed);
        }

        /// <summary>
        /// Verification si une sauvegarde éxiste sur le disque, si c'est le cas, on restaure les paramètres
        /// </summary>
        public void LoadSpeedsFromDisk()
        {
            this.ReplayManager.LoadSpeedFromDisk();
        }

        /// <summary>
        /// Remise à zéro du tableau de vitesses
        /// </summary>
        public void ResetSpeed()
        {
            this.ReplayManager.ResetSpeed();
        }
        #endregion
        #endregion

        #region DISPLAYS / WINDOWS

        #region Replay Display

        /// <summary>
        /// Création de la fenètre sur le second moniteur
        /// </summary>
        public void NewDisplay()
        {            
            this.FrmReplay = new DisplayReplay(this);
            this.FrmReplay.Show();
        }

        /// <summary>
        /// Fermer la fen^tre de replay
        /// </summary>
        public void CloseDisplay()
        {
            this.FrmReplay.Close();
        }

        /// <summary>
        /// Afficher la vidéo en cache dans la fenêtre de Replay
        /// </summary>
        public void GoLiveReplay()
        {
            this.FrmReplay.StartLive();
        }

        public void ReplayTick(int currentFrame)
        {
            this.FrmMain.UpdateLiveTimeLeft(this.ReplayManager.TimeLeftLive(currentFrame));
        }

        public void DisplayLittleReplayImage(Bitmap bmp)
        {
            if (bmp != null)
            {
                Bitmap resized = new Bitmap(bmp, new Size(320, 180));
                this.FrmMain.DisplayLittleLive(resized);
            }else
                this.FrmMain.DisplayLittleLive(null);
        }

        #endregion

        #region Form Display
        public void SetPictureboxSizes(int pourcentage)
        {
            Size newSize = this.FrmMain.GetPictureBoxResolution();

            newSize.Width = (int)(newSize.Width * (pourcentage / 100.0));
            newSize.Height = (int)(newSize.Height * (pourcentage / 100.0));


            this.ReplayManager.ReplaySize = newSize;
            this.LiveInputManager.LiveSize = newSize;
        }

        #endregion

        #region Secondary Windows
        public void DisplayLiveSecondViewer(Bitmap Image)
        {
            if (this.LiveDisplay != null)
                this.LiveDisplay.DisplayImage(Image);
        }

        public void DisplayReplaySecondViewer(Bitmap Image)
        {
            if (this.ReplayDisplay != null)
                this.ReplayDisplay.DisplayImage(Image);
        }
        #endregion

        #region SETTINGS FORM

        public void OpenSettingsForm()
        {
            this.FrmSettings = new FrmSettings(this);
            this.FrmSettings.Show();

            if (this.selectedCameraIndex != -1)
                this.FrmSettings.CmbChangeIndex(this.selectedCameraIndex);
        }

        public void ChangeInput(int index)
        {
            this.selectedCameraIndex = index;
            this.StartStream(index);
            this.FrmMain.SelectedIndexInputChange();
        }

        public void CloseLive()
        {
            this.StopStream();
            this.FrmMain.DisplayLiveImage(null);
        }

        public void SaveShortcut(int index, char value)
        {
            Properties.Settings.Default.Shortcuts[index] = value;
            Properties.Settings.Default.Save();

            //this.FrmMain.SetUpFunctions();
        }

        /// <summary>
        /// Set the shortcuts for the buttons
        /// </summary>
        public void SetShortcuts()
        {
            if (Properties.Settings.Default.Shortcuts == null)
            {
                Properties.Settings.Default.Shortcuts = DEFAULT_COMMAND_SHORTCUTS;
            }
        }

        public void ResetShortcuts()
        {
            Properties.Settings.Default.Shortcuts = DEFAULT_COMMAND_SHORTCUTS;
            this.SetUpFunctions();
        }

        public void ChangeShortcut(int index, char value)
        {
            Properties.Settings.Default.Shortcuts[index] = value;
            Properties.Settings.Default.Save();

            this.Functions[index] = new Tuple<string, char, Action>(this.Functions[index].Item1, Properties.Settings.Default.Shortcuts[index], this.Functions[index].Item3);
        }

        public bool ShortcutUsed(char shortcut)
        {
            foreach (char item in Properties.Settings.Default.Shortcuts)
            {
                if (item == shortcut)
                {
                    return true;
                }
            }

            return false;
        }


        /// <summary>
        /// Associer toutes les touches a des fonctions et des labels
        /// </summary>
        public void SetUpFunctions()
        {
            this.Functions = new List<Tuple<string, char, Action>>();

            this.Functions.Add(new Tuple<string, char, Action>("IN", Properties.Settings.Default.Shortcuts[0], () => this.In()));
            this.Functions.Add(new Tuple<string, char, Action>("OUT", Properties.Settings.Default.Shortcuts[1], () => this.Out()));
            this.Functions.Add(new Tuple<string, char, Action>("BUFFER", Properties.Settings.Default.Shortcuts[2], () => this.FrmMain.StartBuffer()));
            this.Functions.Add(new Tuple<string, char, Action>("CLEAR", Properties.Settings.Default.Shortcuts[3], () => this.ClearSelection()));
            this.Functions.Add(new Tuple<string, char, Action>("CUT", Properties.Settings.Default.Shortcuts[4], () => this.Cut()));
            this.Functions.Add(new Tuple<string, char, Action>("2nd DISPLAY", Properties.Settings.Default.Shortcuts[5], () => this.FrmMain.SecondDisplay()));
            this.Functions.Add(new Tuple<string, char, Action>("GO LIVE", Properties.Settings.Default.Shortcuts[6], () => this.GoLiveReplay()));
            this.Functions.Add(new Tuple<string, char, Action>("PLAY", Properties.Settings.Default.Shortcuts[7], () => this.FrmMain.StartReplayTimer()));
            this.Functions.Add(new Tuple<string, char, Action>("PAUSE", Properties.Settings.Default.Shortcuts[8], () => this.FrmMain.StopReplayTimer()));
            this.Functions.Add(new Tuple<string, char, Action>("SLOW DOWN", Properties.Settings.Default.Shortcuts[9], () => this.FrmMain.Down(this.GetSpeed(0))));
            this.Functions.Add(new Tuple<string, char, Action>("SLOWER", Properties.Settings.Default.Shortcuts[10], () => this.FrmMain.Down(this.GetSpeed(1))));
            this.Functions.Add(new Tuple<string, char, Action>("SLOWEST", Properties.Settings.Default.Shortcuts[11], () => this.FrmMain.Down(this.GetSpeed(2))));
            this.Functions.Add(new Tuple<string, char, Action>("SPEED UP", Properties.Settings.Default.Shortcuts[12], () => this.FrmMain.Up(this.GetSpeed(3))));
            this.Functions.Add(new Tuple<string, char, Action>("FASTER", Properties.Settings.Default.Shortcuts[13], () => this.FrmMain.Up(this.GetSpeed(4))));
            this.Functions.Add(new Tuple<string, char, Action>("FASTEST", Properties.Settings.Default.Shortcuts[14], () => this.FrmMain.Up(this.GetSpeed(5))));
            this.Functions.Add(new Tuple<string, char, Action>("TO VIDEO", Properties.Settings.Default.Shortcuts[15], () => this.ConvertToVideo()));
            this.Functions.Add(new Tuple<string, char, Action>("IS LIVE", Properties.Settings.Default.Shortcuts[16], () => this.FrmMain.IsReplayLive()));
        }

        public void ExecuteCommand(char command)
        {
            foreach (Tuple<string, char, Action> function in this.Functions)
            {
                if (command == function.Item2)
                {
                    function.Item3.Invoke();
                    return;
                }
            }
        }

        #endregion

        #endregion

    }
}

﻿using System;
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
        private FrmMain _frmMain;
        private DisplayReplay _frmReplay;
        private LiveInputManager _liveInputManager;
        private ReplayManager _replayManager;

        private int _intervalFPS = ReplayManager.DEFAULT_PLAYBACK_POURCENTAGE;

        private const int DEFAULT_REPLAY_INDEX = 0;
        private int _replayIndex = DEFAULT_REPLAY_INDEX;
        #endregion

        #region GETTER / SETTER publiques
        public FrmMain FrmMain { get => _frmMain; set => _frmMain = value; }
        internal LiveInputManager LiveInputManager { get => _liveInputManager; set => _liveInputManager = value; }
        internal ReplayManager ReplayManager { get => _replayManager; set => _replayManager = value; }
        public DisplayReplay FrmReplay { get => _frmReplay; set => _frmReplay = value; }
        public int IntervalPourcentage { get => _intervalFPS; set => _intervalFPS = value; }
        #endregion

        /// <summary>
        /// Boolean retournant le statut du Replay (Est-ce qu'il afficher le live ou non)
        /// </summary>
        public bool IsReplayLive
        {
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

        /// <summary>
        /// Mise en arret du stream
        /// </summary>
        public void StopStream()
        {
            this.LiveInputManager.StopStream();
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
            Bitmap resized = new Bitmap(a_Bitmap, this.LiveInputManager.ThumbnailSize);
            this.FrmMain.DisplayLiveImage(resized);
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
        }
        
        /// <summary>
        /// Convertir le buffer en vidéo
        /// </summary>
        public void ConvertToVideo()
        {
            ReplayManager.ConvertToVideoCallback callback = new ReplayManager.ConvertToVideoCallback(ReplayManager.ConvertToVideoDone);

            Thread thread = new Thread(() => this.ReplayManager.ConvertToVideo(callback));

            thread.Start();
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
            this.ReplayManager.SetSavePath(path);
            if (path != null)
                this.FrmMain.UpdateSavePathLabel("Save path OK");
            else
                this.FrmMain.UpdateSavePathLabel("Select path");
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
        #endregion

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AForge.Video;
using AForge.Video.DirectShow;

using Accord.Video.FFMPEG;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace InstantReplayApp
{
    public class ReplayManager
    {
        #region Variables privées
        private Buffer _buffer;
        private MainManager _mainManager;
        private string _savePath = null;
        private Size _replaySize;
        private bool _isReplayLive;
        private List<Bitmap> _selection = new List<Bitmap>();
        private List<Bitmap> _toDisplay = new List<Bitmap>();
        private int _playBackFPS;
        private int _playbackPourcentage;

        public const int DEFAULT_PLAYBACK_FPS = 25;
        public const int DEFAULT_PLAYBACK_POURCENTAGE = 100;

        public const int MIN_POURCENTAGE = 0;
        public const int MAX_POURCENTAGE = 400;
        #endregion

        #region Getter / Setter publiques

        public Size ReplaySize { get => _replaySize; set => _replaySize = value; }
        public bool IsReplayLive { get => _isReplayLive; set => _isReplayLive = value; }
        internal Buffer Buffer { get => _buffer; set => _buffer = value; }
        public MainManager MainManager { get => _mainManager; set => _mainManager = value; }
        public string SavePath { get => _savePath; set => _savePath = value; }
        public List<Bitmap> Selection { get => _selection; set => _selection = value; }
        public List<Bitmap> ToDisplay { get => _toDisplay; set => _toDisplay = value; }
        public int PlayBackFPS { 
            get => _playBackFPS;
            set
            {
                if (value <= 0)
                    value = 1;

                _playBackFPS = value;
            }
        }
        public int PlaybackPourcentage { 
            get => _playbackPourcentage;
            set
            {
                if (value < MIN_POURCENTAGE)
                    value = MIN_POURCENTAGE;

                if (value > MAX_POURCENTAGE)
                    value = MAX_POURCENTAGE;

                _playbackPourcentage = value;
            }
        }
        #endregion

        public ReplayManager(MainManager a_mainManager)
        {
            this.Buffer = new Buffer();
            this.MainManager = a_mainManager;

            this.PlayBackFPS = DEFAULT_PLAYBACK_FPS;
            this.PlaybackPourcentage = DEFAULT_PLAYBACK_POURCENTAGE;
        }

       

        #region Images to Video Convert
        public void ConvertToVideo(ConvertToVideoCallback callback)
        {
            if (this.Buffer.Images.Count > 5)
            {
                this.StopBuffer();

                VideoFileWriter writer = new VideoFileWriter();

                string path = Path.Combine(this.SavePath, "replay_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".avi");

                // create new video file
                writer.Open(path, 1920, 1080, this.PlayBackFPS, VideoCodec.MPEG4);

                foreach (Bitmap item in this.ToDisplay)
                    writer.WriteVideoFrame(item);

                writer.Close();
                
                this.StartBuffer();

                callback(path);
            }
        }

        /// <summary>
        /// Signature du callback de la fonction ConvertToVideo
        /// </summary>
        /// <param name="path">le chemin d'accès à la dernière vidéo créée par le replay</param>
        public delegate void ConvertToVideoCallback(string path);

        /// <summary>
        /// Methode de callback de la fonction ConvertToVideo
        /// </summary>
        /// <param name="path">Le chemin complet jusqu'à la dernière vidéo</param>
        public static void ConvertToVideoDone(string path)
        {
            Debug.WriteLine("Video saved at " + path);
        }
        #endregion

        #region Buffer
        /// <summary>
        /// Demarre le buffer
        /// </summary>
        public void StartBuffer()
        {
            this.Buffer.Start();
        }

        /// <summary>
        /// Stopper le buffer
        /// </summary>
        public void StopBuffer()
        {
            this.Buffer.Stop();
        }
        
        /// <summary>
        /// Ajouter une image au buffer
        /// </summary>
        /// <param name="bmp">l'image à ajouter</param>
        public void SaveImage(Bitmap bmp)
        {
            this.Buffer.AddImage(bmp);
        }

        /// <summary>
        /// Mettre a jour le chemin vers le dossier de sauvegarde
        /// </summary>
        /// <param name="path">le chemin du dossier</param>
        public void SetSavePath(string path)
        {
            this.SavePath = path;
        }
        #endregion

        /// <summary>
        /// Vidéo OUT
        /// </summary>
        public void Out(int endFrame)
        {
            this.ToDisplay = new List<Bitmap>(this.ToDisplay.GetRange(0, endFrame));
        }

        public void Cut()
        {
            this.Selection = new List<Bitmap>(this.Buffer.Images);
            this.ToDisplay = new List<Bitmap>(this.Selection);
            this.IsReplayLive = false;
        }

        /// <summary>
        /// Vidéo in
        /// </summary>
        public void In(int startFrame)
        {
            this.ToDisplay = new List<Bitmap>(this.ToDisplay.GetRange(startFrame, this.ToDisplay.Count - startFrame));
        }

        /// <summary>
        /// Supprime la marque IN faite
        /// </summary>
        public void ClearSelection()
        {
            this.ToDisplay = new List<Bitmap>(this.Selection);
        }

        /// <summary>
        /// Convert FPS to MS interval (One frame per X milliseconds)
        /// </summary>
        /// <returns>l'interval</returns>
        public int GetIntervalBasedOnFPS()
        {
            return (int)(1 / (this.PlayBackFPS * 0.001));
        }

        /// <summary>
        /// Convertir un pourcentage de vitesse en FPS
        /// </summary>
        /// <param name="pourcentage">le pourcentage de la vitesse</param>
        /// <returns>L'interval en MS pour chaque frame</returns>
        public int SetIntervalFPS(int pourcentage)
        {
            this.PlaybackPourcentage = pourcentage;
            int newFPS = (int)((double)(this.PlaybackPourcentage / 100.0) * (double)DEFAULT_PLAYBACK_FPS);
            this.PlayBackFPS = newFPS;
            return GetIntervalBasedOnFPS();
        }

        /// <summary>
        /// Remet les FPS d'affichage à la valeur par défaut
        /// </summary>
        public void ResetFPS()
        {
            this.PlayBackFPS = DEFAULT_PLAYBACK_FPS;
        }

        /// <summary>
        /// Remet à 0 la vitesse de playback
        /// </summary>
        public void ResetPourcentage()
        {
            this.PlaybackPourcentage = DEFAULT_PLAYBACK_POURCENTAGE;
        }

    }
}

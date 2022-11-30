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
    internal class ReplayManager
    {
        #region Variables privées
        private Buffer _buffer;
        private MainManager _mainManager;
        private string _savePath = null;
        private Size _replaySize;
        private bool _isReplayLive;
        private List<Bitmap> _selection = new List<Bitmap>();
        private List<Bitmap> _toDisplay = new List<Bitmap>();
        #endregion

        #region Getter / Setter publiques

        public Size ReplaySize { get => _replaySize; set => _replaySize = value; }
        public bool IsReplayLive { get => _isReplayLive; set => _isReplayLive = value; }
        internal Buffer Buffer { get => _buffer; set => _buffer = value; }
        public MainManager MainManager { get => _mainManager; set => _mainManager = value; }
        public string SavePath { get => _savePath; set => _savePath = value; }
        public List<Bitmap> Selection { get => _selection; set => _selection = value; }
        public List<Bitmap> ToDisplay { get => _toDisplay; set => _toDisplay = value; }
        #endregion

        public ReplayManager(MainManager a_mainManager)
        {
            this.Buffer = new Buffer();
            this.MainManager = a_mainManager;
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
                writer.Open(path, 1920, 1080, 25, VideoCodec.MPEG4);

                foreach (Bitmap item in this.Buffer.Images)
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
        
    }
}

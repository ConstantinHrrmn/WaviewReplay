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
    public class LiveInputManager
    {
        #region Variables privées 
        private MainManager _mainManager;
        private FilterInfoCollection _filterInfoCollection;
        private VideoCaptureDevice _videoCaptureDevice;
        private Size _thumbnailSize;

        private const int RATIO = 3;
        #endregion

        #region Getter / Setter publiques
        public Size ThumbnailSize { get => _thumbnailSize; set => _thumbnailSize = value; }
        public MainManager MainManager { get => _mainManager; set => _mainManager = value; }

        #endregion

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="a_FrmMain">La form dans laquelle ont doit envoyer les informations</param>
        public LiveInputManager(MainManager a_mainManager)
        {
            this.MainManager = a_mainManager;
            this._videoCaptureDevice = new VideoCaptureDevice();       
        }

        /// <summary>
        /// Permet de charger la liste de toutes les caméras dans le système
        /// </summary>
        /// <returns>La liste de toutes les caméras</returns>
        public FilterInfoCollection LoadInputList()
        {
            this._filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            return this._filterInfoCollection;
        }

        /// <summary>
        /// Démarre le stream de l'entrée sélectionnée 
        /// </summary>
        /// <param name="selectedInputIndex">l'index de l'entrée à streamer</param>
        public (Size, Size, int) StartStream(int selectedInputIndex)
        {
            // Si la capture vidéo était déjà active, alors on la stop
            this.StopStream();

            // Création d'une nouvelle capture vidéo
            this._videoCaptureDevice = new VideoCaptureDevice(this._filterInfoCollection[selectedInputIndex].MonikerString);
            this._videoCaptureDevice.NewFrame += videoCaptureDevice_NewFrame;

            // Démarrage de la nouvelle capture vidéo
            this._videoCaptureDevice.Start();

            // Envoie de la résolution d'entrée
            VideoCapabilities vc = this._videoCaptureDevice.VideoCapabilities[0];


            Size full_resolution = vc.FrameSize;
            Size small_resultion = new Size(full_resolution.Width / RATIO, full_resolution.Height / RATIO);
            this.ThumbnailSize = small_resultion;

            return (full_resolution, small_resultion, vc.MaximumFrameRate);
        }


        /// <summary>
        /// Stop le stream et libère l'entrée
        /// </summary>
        public void StopStream()
        {
            // Si la capture vidéo était déjà active, alors on la stop
            if (this._videoCaptureDevice.IsRunning)
                this._videoCaptureDevice.Stop();
        }

        /// <summary>
        /// Evenement pour chaque nouvelle image reçue de la caméra
        /// </summary>
        private void videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // On récupère la frame en cours
            Bitmap original = (Bitmap)eventArgs.Frame.Clone();
            
            this.MainManager.AddImageToBuffer(original);
            
            // On affiche le live dans la Form principale
            this.MainManager.DisplayLiveImage(original);

            if (this.MainManager.IsReplayLive)
            {
                this.MainManager.DisplayReplayImage(original);
            }

            // On supprime toutes les frames "mortes"
            GC.Collect();
        }

        
    }
}

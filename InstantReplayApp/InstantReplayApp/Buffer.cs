using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InstantReplayApp
{
    public class Buffer
    {
        private List<Bitmap> _bufferImages;
        private int _bufferSize;
        private int _bufferSeconds;
        private int _fps;
        private bool _IsRunning;

        private const int DEFAULT_SECONDS = 8;
        private const int DEFAULT_FPS = 25;
        private const bool DEFAULT_BUFFER_RUNNING_STATE = false;

        public List<Bitmap> Images { get => _bufferImages; set => _bufferImages = value; }
        public int BufferSize { get => _bufferSize; set => _bufferSize = value; }
        public int BufferSeconds { get => _bufferSeconds; set => _bufferSeconds = value; }
        public int Fps { get => _fps; set => _fps = value; }
        public bool IsRunning { get => _IsRunning; set => _IsRunning = value; }

        public Buffer()
        {
            this.Images = new List<Bitmap>();
            this.BufferSeconds = DEFAULT_SECONDS;
            this.Fps = DEFAULT_FPS;
            this.BufferSize = this.BufferSeconds * this.Fps;

            this.IsRunning = DEFAULT_BUFFER_RUNNING_STATE;
        }

        public float SecondsInBuffer()
        {
            return (float)this.Images.Count / (float)this.Fps;
        }

        public void AddImage(Bitmap bmp)
        {
            if (this.IsRunning)
            {
                if (this.Images.Count >= this.BufferSize)
                    this.Images.RemoveAt(0);

                this.Images.Add(bmp);
            }
        }

        public void Start()
        {
            this.IsRunning = true;
        }

        public void Stop()
        {
            this.IsRunning = false;
        }


    }
}

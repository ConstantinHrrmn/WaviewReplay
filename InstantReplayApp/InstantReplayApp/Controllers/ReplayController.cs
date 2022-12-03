using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantReplayApp
{
    public class ReplayController
    {
        private DisplayReplay _form;
        private ReplayManager _replay;
        private int _currentFrame;

        public DisplayReplay Form { get => _form; set => _form = value; }
        internal ReplayManager Replay { get => _replay; set => _replay = value; }
        public int CurrentFrame { get => _currentFrame; set => _currentFrame = value; }

        public ReplayController(DisplayReplay a_form, ReplayManager a_replayManager)
        {
            this.Form = a_form;
            this.Replay = a_replayManager;
        }

        public void StartReplay()
        {
            this.ResetCurrentFrame();
            
            this.Form.SetReplayTimerInterval(this.Replay.GetIntervalBasedOnFPS());
            this.Form.StartReplayTimer();
        }
        
        public void ResetCurrentFrame()
        {
            this.CurrentFrame = 0;
        }

        public void Tick()
        {
            this.Form.DisplayImage(this.Replay.ToDisplay[this.CurrentFrame]);
            this.CurrentFrame++;

            if (this.CurrentFrame >= this.Replay.ToDisplay.Count)
            {
                this.Form.StopReplayTimer();
                this.Form.DisplayImage(null);
            }
        }
    }
}

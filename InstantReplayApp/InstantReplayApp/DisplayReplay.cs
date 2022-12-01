using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstantReplayApp
{
    public partial class DisplayReplay : Form
    {
        private ReplayController _rC;

        public ReplayController RC { get => _rC; set => _rC = value; }
        
        public DisplayReplay(ReplayManager a_rm)
        {
            InitializeComponent();
            this.RC = new ReplayController(this, a_rm);
        }

        private void DisplayReplay_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            this.Size = Screen.AllScreens[1].WorkingArea.Size;
            this.pbReplayFull.Size = Screen.AllScreens[1].WorkingArea.Size;
        }

        public void StartLive()
        {
            this.RC.StartReplay();
        }

        public void DisplayImage(Bitmap Image)
        {
            this.pbReplayFull.Image = Image;
        }

        public void StartReplayTimer()
        {
            this.replayLive.Start();
        }

        public void StopReplayTimer()
        {
            this.replayLive.Stop();
        }

        public void SetReplayTimerInterval(int interval)
        {
            this.replayLive.Interval = interval;
        }

        private void replayLive_Tick(object sender, EventArgs e)
        {
            this.RC.Tick();
        }
    }
}

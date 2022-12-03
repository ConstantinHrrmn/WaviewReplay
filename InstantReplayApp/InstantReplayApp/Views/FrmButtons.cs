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
    public partial class FrmButtons : Form
    {
        MainManager _manager;
        int[] speeds = null;

        public MainManager Manager { get => _manager; set => _manager = value; }

        public FrmButtons(MainManager a_manager)
        {
            InitializeComponent();
            this.Manager = a_manager;
        }

        public void UpdateButtons()
        {
            int[] speeds = this.Manager.GetSpeeds();
            
            this.btnRewind25.Text = speeds[0].ToString();
            this.btnRewind10.Text = speeds[1].ToString();
            this.btnRewind1.Text = speeds[2].ToString();

            this.btnForward1.Text = speeds[3].ToString();
            this.btnForward10.Text = speeds[4].ToString();
            this.btnForward25.Text = speeds[5].ToString();
        }

        private void FrmButtons_Load(object sender, EventArgs e)
        {
            this.UpdateButtons();
        }

        #region BUTTONS

        private void btnStartBuffer_Click(object sender, EventArgs e)
        {
            this.Manager.FrmMain.StartBuffer();
        }

        private void btnSecondDisplay_Click(object sender, EventArgs e)
        {
            this.Manager.FrmMain.SecondDisplay();
        }

        private void btnReplayLive_Click(object sender, EventArgs e)
        {
            this.Manager.FrmMain.IsReplayLive();
        }

        private void btnForward10_Click(object sender, EventArgs e)
        {
            this.Manager.FrmMain.Up(this.speeds[4]);
        }

        private void btnForward25_Click(object sender, EventArgs e)
        {
            this.Manager.FrmMain.Up(this.speeds[5]);
        }

        private void btnRewind10_Click(object sender, EventArgs e)
        {
            this.Manager.FrmMain.Down(this.speeds[1]);
        }

        private void btnRewind1_Click(object sender, EventArgs e)
        {
            this.Manager.FrmMain.Down(this.speeds[2]);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.Manager.FrmMain.StopReplayTimer();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Manager.FrmMain.StartReplayTimer();
        }

        private void btnForward1_Click(object sender, EventArgs e)
        {
            this.Manager.FrmMain.Up(this.speeds[3]);
        }

        private void btnRewind25_Click(object sender, EventArgs e)
        {
            this.Manager.FrmMain.Down(this.speeds[0]);
        }

        private void btnLive_Click(object sender, EventArgs e)
        {
            this.Manager.GoLiveReplay();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            this.Manager.Cut();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.Manager.In();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Manager.Out();
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            this.Manager.ClearSelection();
        }

        private void btnSaveReplay_Click(object sender, EventArgs e)
        {
            this.Manager.ConvertToVideo();
        }

        #endregion

        #region KEYPRESS

        private void FrmButtons_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Manager.SendCommand((char)e.KeyChar);
        }

        #endregion


    }
}

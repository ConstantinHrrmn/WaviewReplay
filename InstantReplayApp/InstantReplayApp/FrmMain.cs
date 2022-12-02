using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;

namespace InstantReplayApp
{
    public partial class FrmMain : Form
    {
        private MainManager _mainManager;

        public MainManager MainManager { get => _mainManager; set => _mainManager = value; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.MainManager = new MainManager(this);

            //this.lblSaveReplayPath.Text = "Replay path : " + Properties.Settings.Default.SavePath;
            this.MainManager.SetSavePath(Properties.Settings.Default.SavePath);
            this.LoadInputList();
        }

        public void UpdateSavePathLabel(string text)
        {
            this.btnSetSavePath.Text = text;
        }

        #region Camera Selection
        public void LoadInputList()
        {

            // On vide la liste des sources
            this.cmbSources.Items.Clear();

            // On ajoute les sources dans la liste
            foreach (FilterInfo item in this.MainManager.LoadInputList())
                this.cmbSources.Items.Add(item.Name);
        }

        private void cmbSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MainManager.StartStream(this.cmbSources.SelectedIndex);
            this.ChangeLiveWarningVisibility();
            this.btnCloseLiveInput.Enabled = true;
            this.tbxCommand.Focus();
            this.Focus();
        }
        #endregion

        #region PictureBox Controls
        public void DisplayLiveImage(Bitmap image)
        {
            //this.pbLive.Invoke((MethodInvoker)(() => this.pbLive.Image = image));
            this.pbLive.Image = image;
        }

        public void DisplayReplayImage(Bitmap bmp)
        {
            this.pbReplay.Image = bmp;
        }

        public void ChangePictureBoxResolution(Size small_resolution)
        {
            this.pbLive.Invoke((MethodInvoker)(() => this.pbLive.Size = small_resolution));

            Debug.WriteLine("new resolution : " + small_resolution.Width + "x" + small_resolution.Height);


            int newPositionY = this.pbLive.Location.Y + this.pbLive.Size.Height + 10;
            int newPositionX = this.pbLive.Location.X + this.pbLive.Size.Width + 10;

            this.gbInputSource.Location = new Point(this.gbInputSource.Location.X, newPositionY);
            this.pbReplay.Location = new Point(newPositionX, this.pbReplay.Location.Y);

            this.ChangeDisplayResolutionLabel(small_resolution);
        }
        #endregion

        #region TrackBar
        public void UpdateTrackBarReplayMaximum(int max)
        {
            this.tbReplay.Invoke((MethodInvoker)(() => this.tbReplay.Maximum = max));
        }

        public void UpdateTrackBarReplayValue(int value)
        {
            this.tbReplay.Invoke((MethodInvoker)(() => this.tbReplay.Value = value));
        }

        
        
        public void PositionTrackBarReplay()
        {
            Point newPosition = new Point();
            newPosition.X = this.pbReplay.Location.X;
            newPosition.Y = this.pbReplay.Location.Y + this.pbReplay.Size.Height + 10;

            this.tbReplay.Location = newPosition;

            this.tbReplay.Size = new Size(this.pbReplay.Size.Width, this.tbReplay.Size.Height);

            //this.tbSpeed.Size = this.tbReplay.Size;
            //this.tbSpeed.Location = new Point(this.tbReplay.Location.X, this.tbReplay.Location.Y + this.tbReplay.Size.Height + 10);
        }

        public void UpdateReplaySpeedTrackbar(int min, int max, int value)
        {
            //this.tbSpeed.Invoke((MethodInvoker)(() => this.tbSpeed.Minimum = min));
            //this.tbSpeed.Invoke((MethodInvoker)(() => this.tbSpeed.Maximum = max));
            //this.tbSpeed.Invoke((MethodInvoker)(() => this.tbSpeed.Value = value));
        }
        #endregion

        #region Resolutions Control (Don't need it anymore)
        public void ChangeReplayResolution(Size small_resolution)
        {
            this.pbReplay.Invoke((MethodInvoker)(() => this.pbReplay.Size = small_resolution));
            this.PositionTrackBarReplay();
        }

        public void ChangeInputResolutionLabel(Size resolution, int fps)
        {
            this.lblInputResolution.Invoke((MethodInvoker)(() => this.lblInputResolution.Text = string.Format("Input resolution : {0} x {1} ({2} fps)", resolution.Width, resolution.Height, fps)));
        }
        public void ChangeDisplayResolutionLabel(Size resolution)
        {
            this.lblDisplayResolution.Invoke((MethodInvoker)(() => this.lblDisplayResolution.Text = string.Format("Display resolution : {0} x {1}", resolution.Width, resolution.Height)));
        }
        #endregion

        #region Keypress
        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            this.ExecuteCommand(c);
            this.Focus();
        }
        private void tbxCommand_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void tbxCommand_TextChanged(object sender, EventArgs e)
        {
            this.tbxCommand.Text = "";
        }
        #endregion

        #region ReplayTimer
        public void StartReplayTimer()
        {
            this.replayTimer.Start();
        }

        public void StopReplayTimer()
        {
            this.replayTimer.Stop();
        }

        public void SetReplayTimerInterval(int interval)
        {
            this.replayTimer.Interval = interval;
            this.lblReplay.Text = "Speed: " + interval + " ms";
        }

        private void replayTimer_Tick(object sender, EventArgs e)
        {
            this.MainManager.StreamReplayIntervalTick();
        }

        #endregion

        #region BUTTON CLICK
        private void ExecuteCommand(char command)
        {
            switch (command)
            {
                case 'i':
                    this.In();
                    break;
                case 'o':
                    this.Out();
                    break;
                case 'w':
                    this.StartBuffer();
                    break;
                case 'x':
                    this.MainManager.ClearSelection();
                    break;
                case 'c':
                    this.Cut();
                    break;
                case 'e':
                    this.SecondDisplay();
                    break;
                case 'r':
                    this.GoLive();
                    break;
                case 't':
                    this.Play();
                    break;
                case 'z':
                    this.Pause();
                    break;
                case 'a':
                    this.Down(25);
                    break;
                case 's':
                    this.Down(10);
                    break;
                case 'd':
                    this.Down(1);
                    break;
                case 'j':
                    this.Up(25);
                    break;
                case 'k':
                    this.Up(10);
                    break;
                case 'l':
                    this.Up(1);
                    break;
                default:
                    break;
            }
        }

        private void btnSetSavePath_Click(object sender, EventArgs e)
        {
            if (fbdReplay.ShowDialog() == DialogResult.OK)
            {
                //this.lblSaveReplayPath.Text = "Replay path : " + fbdReplay.SelectedPath;
                this.MainManager.SetSavePath(fbdReplay.SelectedPath);
                Properties.Settings.Default.SavePath = fbdReplay.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void btnCloseLiveInput_Click(object sender, EventArgs e)
        {
            this.btnCloseLiveInput.Enabled = false;
            this.MainManager.StopStream();
            this.DisplayLiveImage(null);
        }


        #endregion

        #region Replay Commands
        private void StartBuffer()
        {
            if (this.MainManager.IsReplayLive)
            {
                this.BufferTimer.Start();
                this.MainManager.StartBuffer();
                this.ChangeBufferWarningVisibility();
            }
            else
            {
                this.MainManager.Cut();
            }
        }

        private void BufferTimer_Tick(object sender, EventArgs e)
        {
            this.MainManager.SecondsInBuffer();
        }

        public void SetSpeed()
        {
            this.StopReplayTimer();
            this.SetReplayTimerInterval(this.MainManager.SetInterval());
            this.StartReplayTimer();

            this.UpdatePourcentageSpeed();
        }

        public void Up(int amount)
        {
            this.MainManager.SpeedUp(amount);
            this.SetSpeed();
        }

        public void Down(int amount)
        {
            this.MainManager.SlowDown(amount);
            this.SetSpeed();
        }
        
        public void UpdatePourcentageSpeed(){
            this.lblSpeedPourcentage.Text = this.MainManager.ReplayManager.PlaybackPourcentage + "%";
        }

        private void Cut()
        {
            this.MainManager.Cut();
        }

        private void Out()
        {
            this.MainManager.Out();
        }

        private void In(){
            this.MainManager.In();
        }

        public void UpdateBufferButton(string text)
        {
            this.lblSecondsInBuffer.Invoke((MethodInvoker)(() => this.lblSecondsInBuffer.Text = text));
        }

        private void tbReplay_Scroll(object sender, EventArgs e)
        {
            this.MainManager.ChangeReplayPosition(this.tbReplay.Value);
        }

        private void Pause()
        {
            this.StopReplayTimer();
        }

        private void Play()
        {
            this.StartReplayTimer();
        }

        public void DisplayLittleLive(Bitmap Image)
        {
            this.pbLiveReplay.Invoke((MethodInvoker)(() => this.pbLiveReplay.Image = Image));
        }

        #endregion

        #region Secondary Display

        public void SecondDisplay()
        {
            this.MainManager.NewDisplay();
            this.Focus();
            
        }

        public void GoLive()
        {
            this.MainManager.GoLiveReplay();
        }

        #endregion

        #region Update Labels

        public void UpdateLiveTimeLeft(float timeLeft)
        {
            this.lblLiveEnds.Invoke((MethodInvoker)(() => this.lblLiveEnds.Text = timeLeft.ToString("0.00")));
            this.lblLiveEnds.BackColor = (timeLeft > 0) ? Color.Red : Color.Green;
        }

        public void UpdateBufferWarningLabel(string text)
        {
            this.lblBufferWarning.Invoke((MethodInvoker)(() => this.lblBufferWarning.Text = text));
        }

        public void ChangeBufferWarningVisibility()
        {
            this.lblBufferWarning.Invoke((MethodInvoker)(() => this.lblBufferWarning.Visible = !this.lblBufferWarning.Visible));
        }

        public void UpdateLiveWarning(string text)
        {
            this.lblLiveWarning.Invoke((MethodInvoker)(() => this.lblLiveWarning.Text = text));
        }

        public void ChangeLiveWarningVisibility()
        {
            this.lblLiveWarning.Invoke((MethodInvoker)(() => this.lblLiveWarning.Visible = !this.lblLiveWarning.Visible));
        }

        #endregion

    }
}

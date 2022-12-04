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

            //this.LoadInputList();
        }

        #region Camera Selection

        public void SelectedIndexInputChange()
        {
            this.ChangeLiveWarningVisibility();
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

            //this.gbInputSource.Location = new Point(this.gbInputSource.Location.X, newPositionY);
            this.pbReplay.Location = new Point(newPositionX, this.pbReplay.Location.Y);

            this.ChangeDisplayResolutionLabel(small_resolution);
        }

        public Size GetPictureBoxResolution()
        {
            return this.pbLive.Size;
        }
        
        public Size GetSmallBoxResoltion()
        {
            return this.pbLiveReplay.Size;
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

        private void tbReplay_Scroll(object sender, EventArgs e)
        {
            this.MainManager.ChangeReplayPosition(this.tbReplay.Value);
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
        public void ExecuteCommand(char command)
        {
            this.MainManager.ExecuteCommand(command);
        }

        private void pbLive_Click(object sender, EventArgs e)
        {
            this.MainManager.LiveDisplay = new FrmVideoDisplay("LIVE", this);
            this.MainManager.LiveDisplay.Show();
        }

        private void pbReplay_Click(object sender, EventArgs e)
        {
            this.MainManager.ReplayDisplay = new FrmVideoDisplay("REPLAY", this);
            this.MainManager.ReplayDisplay.Show();
        }

        private void btnOnScreenButtons_Click(object sender, EventArgs e)
        {
            FrmButtons buttons = new FrmButtons(this.MainManager);
            buttons.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.MainManager.OpenSettingsForm();
        }        

        #endregion

        #region Replay Commands

        #region Buffer
        public void StartBuffer()
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

        #endregion

        /// <summary>
        /// Sets the new Seped for the replay
        /// </summary>
        public void SetSpeed()
        {
            this.StopReplayTimer();
            this.SetReplayTimerInterval(this.MainManager.SetInterval());
            this.StartReplayTimer();

            this.UpdatePourcentageSpeed();
        }

        public void IsReplayLive()
        {
            this.MainManager.ChangeReplayLiveState();
            if (this.MainManager.IsReplayLive)
                this.StopReplayTimer();
            else
                this.StartReplayTimer();
        }

        /// <summary>
        /// Set speed up by amount giver
        /// </summary>
        /// <param name="amount">the amount of speed in % to speed up</param>
        public void Up(int amount)
        {
            this.MainManager.SpeedUp(amount);
            this.SetSpeed();
        }

        /// <summary>
        /// Set speed down by amount giver
        /// </summary>
        /// <param name="amount">the amount of speed in % to slow down</param>
        public void Down(int amount)
        {
            this.MainManager.SlowDown(amount);
            this.SetSpeed();
        }

        /// <summary>
        /// Get last 8 seconds to edit
        /// </summary>
        public void Cut()
        {
            this.MainManager.Cut();
        }

        /// <summary>
        /// Make the out mark in the edit video
        /// </summary>
        public void Out()
        {
            this.MainManager.Out();
        }

        /// <summary>
        /// Make the in mark in the edit video
        /// </summary>
        public void In(){
            this.MainManager.In();
        }

        /// <summary>
        /// Pause the Replay editor
        /// </summary>
        public void Pause()
        {
            this.StopReplayTimer();
        }

        /// <summary>
        /// Play the Replay editior
        /// </summary>
        public void Play()
        {
            this.StartReplayTimer();
        }

        /// <summary>
        /// Display an image in the little live feed
        /// </summary>
        /// <param name="Image">The image to display</param>
        public void DisplayLittleLive(Bitmap Image)
        {
            this.pbLiveReplay.Invoke((MethodInvoker)(() => this.pbLiveReplay.Image = Image));
        }

        public void ConvertTovideo()
        {
            this.MainManager.ConvertToVideo();
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

        /// <summary>
        /// Update the Label wich displays the speed of the Replay playback
        /// </summary>
        public void UpdatePourcentageSpeed()
        {
            this.lblSpeedPourcentage.Text = this.MainManager.ReplayManager.PlaybackPourcentage + "%";
        }

        /// <summary>
        /// Update the text wich displays the amount of seconds that are stored in the buffer
        /// </summary>
        /// <param name="text">the text to display</param>
        public void UpdateBufferButton(string text)
        {
            this.lblSecondsInBuffer.Invoke((MethodInvoker)(() => this.lblSecondsInBuffer.Text = text));
        }

        public void UpdateStatus(string text)
        {
            this.lblStatus.Invoke((MethodInvoker)(() => this.lblStatus.Text = text));
        }

        public void ChangeStatusColor(Color c)
        {
            this.lblStatus.Invoke((MethodInvoker)(() => this.lblStatus.ForeColor = c));
        }



        #endregion

        private void Clock_Tick(object sender, EventArgs e)
        {
            this.lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MainManager.StopStream();
        }
    }
}

namespace InstantReplayApp
{
    partial class DisplayReplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbReplayFull = new System.Windows.Forms.PictureBox();
            this.replayLive = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbReplayFull)).BeginInit();
            this.SuspendLayout();
            // 
            // pbReplayFull
            // 
            this.pbReplayFull.Location = new System.Drawing.Point(0, 0);
            this.pbReplayFull.Name = "pbReplayFull";
            this.pbReplayFull.Size = new System.Drawing.Size(100, 100);
            this.pbReplayFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReplayFull.TabIndex = 0;
            this.pbReplayFull.TabStop = false;
            // 
            // replayLive
            // 
            this.replayLive.Interval = 40;
            this.replayLive.Tick += new System.EventHandler(this.replayLive_Tick);
            // 
            // DisplayReplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbReplayFull);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayReplay";
            this.Text = "DisplayReplay";
            this.Load += new System.EventHandler(this.DisplayReplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReplayFull)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbReplayFull;
        private System.Windows.Forms.Timer replayLive;
    }
}
using AForge.Video;
using AForge.Video.DirectShow;
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
    public partial class FrmVideoDisplay : Form
    {
        FrmMain main;

        public FrmVideoDisplay(string title, FrmMain a_main)
        {
            InitializeComponent();
            this.Text = title;
            this.main = a_main;
        }

        private void FrmVideoDisplay_Load(object sender, EventArgs e)
        {
            this.pbVideo.Size = this.Size;
            
        }

        private void FrmVideoDisplay_SizeChanged(object sender, EventArgs e)
        {
            this.pbVideo.Size = this.Size;
        }

        public void DisplayImage(Bitmap image)
        {
            this.pbVideo.Image = image;
            GC.Collect();
        }

        private void FrmVideoDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.main.ExecuteCommand(e.KeyChar);
        }
    }
}

using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            axWindowsMediaPlayer.URL = openFileDialog.FileName;

            this.Text = this.Text + " - Now Playing - " + openFileDialog.SafeFileName;
            this.Update();
        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fullscreenToolStripMenuItem.Checked == true)
            {
                axWindowsMediaPlayer.fullScreen = false;
            }
            else
            {
                axWindowsMediaPlayer.fullScreen = true;
            }
        }

        private void axWindowsMediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://https://github.com/BloddyRose");
        }

        private void axWindowsMediaPlayer_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {
            if (axWindowsMediaPlayer.fullScreen == true)
            {
                axWindowsMediaPlayer.fullScreen = false;
            }
            else
            {
                axWindowsMediaPlayer.fullScreen = true;
            }
        }

        private void axWindowsMediaPlayer_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            
        }

        private void axWindowsMediaPlayer_KeyUpEvent(object sender, AxWMPLib._WMPOCXEvents_KeyUpEvent e)
        {

        }

        private void axWindowsMediaPlayer_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {

        }
    }

}

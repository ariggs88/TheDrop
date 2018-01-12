using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer;
using AxWMPLib;



namespace TheDrop
{
    public partial class FormHelp : Form
    {

        public FormHelp()
        {
            InitializeComponent();
        }

        private void FormHelp_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();


        string dir = Environment.CurrentDirectory;
          if (tabControl1.SelectedTab == tabControl1.TabPages["trabDropZone"])//your specific tabname
            {
                axWindowsMediaPlayer1.URL = dir + @"\Videos\addDeletePrograms.mp4";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.stop();
                axWindowsMediaPlayer3.Ctlcontrols.stop();
                axWindowsMediaPlayer4.Ctlcontrols.stop();
                axWindowsMediaPlayer5.Ctlcontrols.stop();
                axWindowsMediaPlayer1.settings.mute = true;
               

            }
      

            

            return;
        }

        private void FormHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Dispose();
            axWindowsMediaPlayer2.Dispose();
            axWindowsMediaPlayer3.Dispose();
            axWindowsMediaPlayer4.Dispose();
            axWindowsMediaPlayer5.Dispose();
            return;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dir = Environment.CurrentDirectory;
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabAddWebsite"])
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer3.Ctlcontrols.stop();
                axWindowsMediaPlayer4.Ctlcontrols.stop();
                axWindowsMediaPlayer5.Ctlcontrols.stop();
                axWindowsMediaPlayer2.Ctlcontrols.play();
                axWindowsMediaPlayer2.settings.mute = true;
                axWindowsMediaPlayer2.URL = dir + @"\Videos\addDeleteWebsite.mp4";

            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabLeftPaneHelp"])
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer2.Ctlcontrols.stop();
                axWindowsMediaPlayer4.Ctlcontrols.stop();
                axWindowsMediaPlayer5.Ctlcontrols.stop();
                axWindowsMediaPlayer3.Ctlcontrols.play();
                axWindowsMediaPlayer3.URL = dir + @"\Videos\UsingLeftPaneNavigation.mp4";
                axWindowsMediaPlayer3.settings.mute = true;

            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabSearchGoogle"])
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer2.Ctlcontrols.stop();
                axWindowsMediaPlayer3.Ctlcontrols.stop();
                axWindowsMediaPlayer4.Ctlcontrols.play();
                axWindowsMediaPlayer5.Ctlcontrols.stop();
                axWindowsMediaPlayer4.URL = dir + @"\Videos\searchGoogle.mp4";
                axWindowsMediaPlayer4.settings.mute = true;

            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["fullscreenBackground"])
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer2.Ctlcontrols.stop();
                axWindowsMediaPlayer3.Ctlcontrols.stop();
                axWindowsMediaPlayer4.Ctlcontrols.stop();
                axWindowsMediaPlayer5.Ctlcontrols.play();
                axWindowsMediaPlayer5.URL = dir + @"\Videos\FullscreenToggleAndBackgroundChange.mp4";
                axWindowsMediaPlayer5.settings.mute = true;

            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["trabDropZone"])//your specific tabname
            {
                axWindowsMediaPlayer1.URL = dir + @"\Videos\addDeletePrograms.mp4";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.stop();
                axWindowsMediaPlayer3.Ctlcontrols.stop();
                axWindowsMediaPlayer4.Ctlcontrols.stop();
                axWindowsMediaPlayer5.Ctlcontrols.stop(); axWindowsMediaPlayer1.settings.mute = true;

            }
        }
    }
}

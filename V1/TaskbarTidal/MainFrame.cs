using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tidy;
using Tidy.Properties;
using Windows.Media.Control;


namespace TaskbarTidal
{
    public partial class MainFrame : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        Point lastPoint;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void IfInvoke(Action actionToInvoke)
        {
            if (InvokeRequired) _ = Invoke(actionToInvoke);
            else actionToInvoke();
        }

        private void MainFrame_Shown(object sender, EventArgs e)
        {
            this.BringToFront();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Enabled = true;

            this.BackColor = Settings.Default.BackColor;
            this.Left = Settings.Default.LocLeft;
            this.Top = Settings.Default.LocTop;
            
            UpdateMediaData();
        }

        private async void UpdateMediaData()
        {
            var mediaSession = await GlobalSystemMediaTransportControlsSessionManager.RequestAsync();
            if (mediaSession.GetCurrentSession() is null)
            {
                IfInvoke(new Action(() => { 
                    lblState.Text = Settings.Default.StopIcon;
                    lblOutput.Text = Messages.NothingPlaying;
                }));
                return;
            }
            var mediaProperties = await mediaSession.GetCurrentSession().TryGetMediaPropertiesAsync();
            var playbackState = mediaSession.GetCurrentSession().GetPlaybackInfo().PlaybackStatus;

            IfInvoke(new Action(() => { lblOutput.Text = mediaProperties.Artist + " - " + mediaProperties.Title; }));

            switch (playbackState)
            {
                case GlobalSystemMediaTransportControlsSessionPlaybackStatus.Playing:
                    IfInvoke(new Action(() => { lblState.Text = Settings.Default.PlayIcon; })); break;
                case GlobalSystemMediaTransportControlsSessionPlaybackStatus.Paused:
                    IfInvoke(new Action(() => { lblState.Text = Settings.Default.PauseIcon; })); break;
                default:
                    IfInvoke(new Action(() => { lblState.Text = Settings.Default.StopIcon; })); break;
            }            
        }

        private void Timer_Tick(object sender, EventArgs e)
        { 
            this.TopMost = true;
            UpdateMediaData();
        }

        private void MainFrame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.Right) this.Width += 1;
                if (e.KeyCode == Keys.Left) this.Width -= 1;
                return;
            };

            Int32 mov = 10;
            if (e.Modifiers == Keys.Shift) mov = 1;
            if (e.KeyCode == Keys.Right) this.Left += mov;
            if (e.KeyCode == Keys.Left) this.Left -= mov;
            if (e.KeyCode == Keys.Up) this.Top -= mov;
            if (e.KeyCode == Keys.Down) this.Top += mov;
            if (e.KeyCode == Keys.Escape) Application.Exit();

            Settings.Default.LocLeft = this.Left;
            Settings.Default.LocTop = this.Top;
        }

        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void MainFrame_DoubleClick(object sender, EventArgs e)
        {
            colorMainForm.Color = this.BackColor;
            colorMainForm.ShowDialog();
            this.BackColor = colorMainForm.Color;
            Settings.Default.BackColor = this.BackColor;
            Settings.Default.Save();
        }

        private void MainFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

            Settings.Default.LocLeft = this.Left;
            Settings.Default.LocTop = this.Top;
        }

        private void MainFrame_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment1
{
    public partial class Form1 : Form
    {
        private MusicPlayer music;
        private Random random;

        private Thread labelThread;
        private Thread iconThread;

        private volatile bool labelShowing;
        private volatile bool iconShowing;

        public Form1()
        {
            InitializeComponent();

            music = new MusicPlayer();
            random = new Random();

            labelShowing = false;
            iconShowing = false;
        }

        #region Draw Label
        private void StartDrawingLabelButton_Click(object sender, EventArgs e)
        {
            if (!labelShowing)
            {
                labelShowing = true;
                labelThread = new Thread(new ThreadStart(UpdateLabelLocation));
                labelThread.Start();
            }
        }

        private void UpdateLabelLocation()
        {
            try
            {
                while (labelShowing)
                {
                    SetLocation(new Point(random.Next(0, 200), random.Next(300, 400)));
                    Thread.Sleep(1000);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private delegate void SetLocationCallback(Point newLocation);

        private void SetLocation(Point newLocation)
        {
            if (label1.InvokeRequired)
            {
                SetLocationCallback cb = new SetLocationCallback(SetLocation);
                Invoke(cb, new object[] { newLocation });
            }
            else
            {
                label1.Location = newLocation;
                label1.Visible = true;
            }
        }

        private void StopDrawingLabelButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            labelShowing = false;
        }
        #endregion

        #region DrawIcon
        private void StartDrawingIconButton_Click(object sender, EventArgs e)
        {
            if (!iconShowing)
            {
                iconShowing = true;
                iconThread = new Thread(new ThreadStart(DrawIcon));
                iconThread.Start();
            }
        }

        private void DrawIcon()
        {
            try
            {
                Graphics graphics = CreateGraphics();
                graphics.Clip = new Region(new RectangleF(IconPanel.Left, IconPanel.Top, IconPanel.Width, IconPanel.Height));

                Rectangle rect = new Rectangle(IconPanel.Left + (IconPanel.Width / 4), IconPanel.Top + (IconPanel.Height / 4), IconPanel.Width / 2, IconPanel.Height / 2);

                while (iconShowing)
                {
                    graphics.Clear(BackColor);
                    graphics.DrawRectangle(Pens.Black, rect);

                    Matrix mat = graphics.Transform;
                    mat.RotateAt(1.0f, new PointF(IconPanel.Left + IconPanel.Width / 2, IconPanel.Top + IconPanel.Height / 2));
                    graphics.Transform = mat;

                    Thread.Sleep(50);
                }

                graphics.Clear(BackColor);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void StopDrawingIconButton_Click(object sender, EventArgs e)
        {
            iconShowing = false;
        }
        #endregion

        #region Music Player
        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            music.Open(FileDialog.FileName);
            CurrentSongText.Text = FileDialog.SafeFileName;
        }

        private void OpenSongButton_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
        }

        private void PlaySongButton_Click(object sender, EventArgs e)
        {
            music.Play();
        }

        private void StopSongButton_Click(object sender, EventArgs e)
        {
            music.Stop();
            CurrentSongText.Text = "";
        }
        #endregion
    }
}

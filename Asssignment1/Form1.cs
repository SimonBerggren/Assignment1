using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace Asssignment1
{
    public partial class DefaultForm : Form
    {
        private MusicPlayer music;
        private Random random;

        private Thread labelThread;
        private Thread iconThread;

        private volatile bool labelShowing;
        private volatile bool iconShowing;

        public DefaultForm()
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
                    int randX = random.Next(LabelPanel.Left, LabelPanel.Right - label.Width);
                    int randY = random.Next(LabelPanel.Top + (label.Height / 2), LabelPanel.Bottom - (label.Height / 2));

                    SetLocation(new Point(randX, randY));
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
            if (label.InvokeRequired)
            {
                SetLocationCallback cb = new SetLocationCallback(SetLocation);
                Invoke(cb, new object[] { newLocation });
            }
            else
            {
                label.Location = newLocation;
                label.Visible = true;
            }
        }

        private void StopDrawingLabelButton_Click(object sender, EventArgs e)
        {
            label.Visible = false;
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

                // Rectangle position and size 
                int x = IconPanel.Left + (IconPanel.Width / 4);
                int y = IconPanel.Top + (IconPanel.Height / 4);
                int width = IconPanel.Width / 2;
                int height = IconPanel.Height / 2;

                Rectangle rect = new Rectangle(x, y, width, height);

                while (iconShowing)
                {
                    graphics.Clear(BackColor);
                    graphics.DrawRectangle(Pens.Black, rect);

                    Matrix mat = graphics.Transform;
                    mat.RotateAt(1.0f, new PointF(IconPanel.Left + IconPanel.Width / 2, IconPanel.Top + IconPanel.Height / 2));
                    graphics.Transform = mat;

                    Thread.Sleep(10);
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
        private void OpenSongButton_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
        }

        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            music.Open(FileDialog.FileName);
            CurrentSongLabel.Text = FileDialog.SafeFileName;
            music.PlayFromStart();

            ResumeMusicButton.Enabled = false;
            StopSongButton.Enabled = true;
            PlaySongButton.Enabled = true;
        }

        private void PlaySongButton_Click(object sender, EventArgs e)
        {
            music.PlayFromStart();

            ResumeMusicButton.Enabled = false;
            StopSongButton.Enabled = true;
        }

        private void ResumeMusicButton_Click(object sender, EventArgs e)
        {
            music.Resume();
            ResumeMusicButton.Enabled = false;
            StopSongButton.Enabled = true;
        }

        private void StopSongButton_Click(object sender, EventArgs e)
        {
            music.Stop();
            ResumeMusicButton.Enabled = true;
            StopSongButton.Enabled = false;
        }
        #endregion

        private void DefaultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (labelShowing)
            {
                labelShowing = false;
                labelThread.Join();
            }

            if (iconShowing)
            {
                iconShowing = false;
                iconThread.Join();
            }

            music.Close();
        }
    }
}
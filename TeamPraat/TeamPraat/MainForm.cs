using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TeamPraat.Ui_Elements;

namespace TeamPraat
{
    public partial class MainForm : Form
    {
        public readonly int defaultHeight;
        public readonly int initialSplitterDistance;
        public bool MicMuted;
        public bool SpeakerMuted;
        public int Servers;
        public Point originalpos;
        public ConnectedServer selectedServer = null;

        public MainForm()
        {
            InitializeComponent();
            initialSplitterDistance = scMainScreen.SplitterDistance;
            originalpos = pbFriendsSlide.Location;
            scMainScreen.SplitterDistance = scMainScreen.Width;
            pbFriendsSlide.Location = new Point(Size.Width - pbFriendsSlide.Width - 10, pbFriendsSlide.Location.Y);
            pbFriendsSlide.Image = TeamPraat.Properties.Resources.ic_keyboard_arrow_left_black_24dp_2x;
            scMainScreen.Panel2.Hide();
            defaultHeight = pbEmpty.Location.Y;
            pbFriendsSlide.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            scMainScreen.Panel1.Controls.Clear();
            scMainScreen.Panel1.Controls.Add(new ServerBrowser(this));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var b = (PictureBox)sender;

            if (scMainScreen.Panel2.Visible)
            {
                originalpos = b.Location;
                b.Location = new Point(Size.Width - b.Width - 10, b.Location.Y);
                b.Image = TeamPraat.Properties.Resources.ic_keyboard_arrow_left_black_24dp_2x;
                
                for (int splitterDistance = initialSplitterDistance; splitterDistance <= scMainScreen.Width; splitterDistance += 1)
                {
                    DateTime start = DateTime.Now;
                    scMainScreen.SplitterDistance = splitterDistance;

                    while (DateTime.Now.Subtract(start).TotalMilliseconds <= 0.5)
                    {
                        Application.DoEvents();
                    }
                }
                scMainScreen.Panel2.Hide();
            }
            else
            {
                scMainScreen.Panel2.Show();
                b.Image = TeamPraat.Properties.Resources.ic_keyboard_arrow_right_black_24dp_2x;
                for (int splitterDistance = scMainScreen.Width; splitterDistance >= initialSplitterDistance; splitterDistance -= 1)
                {
                    DateTime start = DateTime.Now;
                    scMainScreen.SplitterDistance = splitterDistance;
                    b.Location.Offset(1, 0);

                    while (DateTime.Now.Subtract(start).TotalMilliseconds <= 0.5)
                    {
                        Application.DoEvents();
                    }
                }
                b.Location = originalpos;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (!SpeakerMuted)
            {
                pictureBox1.BackColor = Color.Red;
                SpeakerMuted = true;
            }
            else
            {
                pictureBox1.BackColor = Color.FromArgb(75, 75, 75);
                SpeakerMuted = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var sf = new SettingsForm();
            sf.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!MicMuted)
            {
                pictureBox3.BackColor = Color.Red;
                MicMuted = true;
            }
            else
            {
                pictureBox3.BackColor = Color.FromArgb(75, 75, 75);
                MicMuted = false;
            }
        }
    }
}
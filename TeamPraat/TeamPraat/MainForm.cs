using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TeamPraat.Properties;
using TeamPraat.Ui_Elements;

namespace TeamPraat
{
    public partial class MainForm : Form
    {
        public static MainForm main;
        public readonly int defaultHeight;
        public readonly int initialSplitterDistance;
        public bool MicMuted;
        public Point originalpos;
        public ConnectedServer selectedServer = null;
        public int Servers;
        public bool SpeakerMuted;

        public MainForm()
        {
            InitializeComponent();
            initialSplitterDistance = scMainScreen.SplitterDistance;
            originalpos = pbFriendsSlide.Location;
            scMainScreen.SplitterDistance = scMainScreen.Width;
            pbFriendsSlide.Location = new Point(Size.Width - pbFriendsSlide.Width - 10, pbFriendsSlide.Location.Y);
            pbFriendsSlide.Image = Resources.ic_keyboard_arrow_left_white_24dp_2x;
            scMainScreen.Panel2.Hide();
            defaultHeight = pbEmpty.Location.Y;
            pbFriendsSlide.BringToFront();
            main = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //scMainScreen.Panel1.Controls.Clear();
            //scMainScreen.Panel1.Controls.Add(new ServerBrowser(this));
            foreach (Control c in scMainScreen.Panel1.Controls)
            {
                c.Hide();
            }

            if (scMainScreen.Panel1.Controls.OfType<ServerBrowser>().Any())
            {
                scMainScreen.Panel1.Controls.OfType<ServerBrowser>().First().Show();
            }
            else
            {
                scMainScreen.Panel1.Controls.Add(new ServerBrowser(this));
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var b = (PictureBox) sender;

            if (scMainScreen.Panel2.Visible)
            {
                originalpos = b.Location;
                b.Location = new Point(Size.Width - b.Width - 10, b.Location.Y);
                b.Image = Resources.ic_keyboard_arrow_left_white_24dp_2x;

                for (int splitterDistance = initialSplitterDistance;
                    splitterDistance <= scMainScreen.Width;
                    splitterDistance += 1)
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
                b.Image = Resources.ic_keyboard_arrow_right_white_24dp_2x;
                for (int splitterDistance = scMainScreen.Width;
                    splitterDistance >= initialSplitterDistance;
                    splitterDistance -= 1)
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
            SpeakerMuted = !SpeakerMuted;
            pbSound.BackColor = SpeakerMuted ? Color.Red : Color.FromArgb(75, 75, 75);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var sf = new SettingsForm();
            sf.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MicMuted = !MicMuted;
            pbMic.BackColor = MicMuted ? Color.Red : Color.FromArgb(75, 75, 75);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vriend toegevoegd");
        }
    }
}
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
        private int slideDirection = 0;
        private PictureBox friendsBox;
        private int splitterDistance;

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

        private void button1_Click_1(object sender, EventArgs e) // Friends slider
        {
            friendsBox = (PictureBox) sender;

            if (!tmr_Slide.Enabled)
            {
                if (scMainScreen.Panel2.Visible)
                {
                    originalpos = friendsBox.Location;
                    friendsBox.Location = new Point(Size.Width - friendsBox.Width - 10, friendsBox.Location.Y);
                    friendsBox.Image = Resources.ic_keyboard_arrow_left_white_24dp_2x;

                    slideDirection = 4;
                    splitterDistance = initialSplitterDistance;
                    tmr_Slide.Enabled = true;
                }
                else
                {
                    scMainScreen.Panel2.Show();
                    friendsBox.Image = Resources.ic_keyboard_arrow_right_white_24dp_2x;

                    slideDirection = -4;
                    splitterDistance = scMainScreen.Width;
                    tmr_Slide.Enabled = true;
                }
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

        private void tmr_Slide_Tick(object sender, EventArgs e)
        {
            if (slideDirection > 0) //inklappen
            {
                if (splitterDistance <= scMainScreen.Width)
                {
                    splitterDistance += slideDirection;
                    scMainScreen.SplitterDistance = splitterDistance;
                }
                else
                {
                    slideDirection = 0;
                    scMainScreen.Panel2.Hide();
                    tmr_Slide.Enabled = false;
                }
            }
            else if (slideDirection < 0) // uitklappen
            {
                if (splitterDistance >= initialSplitterDistance)
                {
                    splitterDistance = splitterDistance + slideDirection;
                    scMainScreen.SplitterDistance = splitterDistance;
                    friendsBox.Location.Offset(1, 0);
                }
                else
                {
                    slideDirection = 0;
                    friendsBox.Location = originalpos;
                    tmr_Slide.Enabled = false;
                }
            }
        }
    }
}
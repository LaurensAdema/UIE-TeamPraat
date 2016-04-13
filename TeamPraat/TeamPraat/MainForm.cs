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

        public MainForm()
        {
            InitializeComponent();
            initialSplitterDistance = splitContainer1.SplitterDistance;
            originalpos = pictureBox4.Location;
            splitContainer1.SplitterDistance = splitContainer1.Width;
            pictureBox4.Location = new Point(Size.Width - pictureBox4.Width - 10, pictureBox4.Location.Y);
            pictureBox4.Image = TeamPraat.Properties.Resources.ic_keyboard_arrow_left_black_24dp_2x;
            splitContainer1.Panel2.Hide();
            defaultHeight = pbEmpty.Location.Y;
            pictureBox4.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.Clear();
            splitContainer1.Panel1.Controls.Add(new ServerBrowser(this));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var b = (PictureBox)sender;

            if (splitContainer1.Panel2.Visible)
            {
                originalpos = b.Location;
                b.Location = new Point(Size.Width - b.Width - 10, b.Location.Y);
                b.Image = TeamPraat.Properties.Resources.ic_keyboard_arrow_left_black_24dp_2x;
                
                for (int splitterDistance = initialSplitterDistance; splitterDistance <= splitContainer1.Width; splitterDistance += 1)
                {
                    DateTime start = DateTime.Now;
                    splitContainer1.SplitterDistance = splitterDistance;

                    while (DateTime.Now.Subtract(start).TotalMilliseconds <= 0.5)
                    {
                        Application.DoEvents();
                    }
                }
                splitContainer1.Panel2.Hide();
            }
            else
            {
                splitContainer1.Panel2.Show();
                b.Image = TeamPraat.Properties.Resources.ic_keyboard_arrow_right_black_24dp_2x;
                for (int splitterDistance = splitContainer1.Width; splitterDistance >= initialSplitterDistance; splitterDistance -= 1)
                {
                    DateTime start = DateTime.Now;
                    splitContainer1.SplitterDistance = splitterDistance;
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
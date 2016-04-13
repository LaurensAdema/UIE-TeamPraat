using System;
using System.Drawing;
using System.Windows.Forms;
using TeamPraat.Ui_Elements;

namespace TeamPraat
{
    public partial class MainForm : Form
    {
        private readonly int defaultHeight;
        private bool MicMuted;
        private bool SpeakerMuted;
        private int Servers;
        private Point originalpos;

        public MainForm()
        {
            InitializeComponent();
            defaultHeight = pbEmpty.Location.Y;
            pictureBox4.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pbEmpty.Location = new Point(pbEmpty.Location.X, pbEmpty.Location.Y + pbEmpty.Height + 10);

            var cs = new ConnectedServer();
            cs.Location = new Point(pbEmpty.Location.X, (defaultHeight + cs.Height)*Servers + 10);
            Servers++;

            panel1.Controls.Add(cs);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var b = (PictureBox)sender;

            if (splitContainer1.Panel2.Visible)
            {
                
                originalpos = b.Location;
                b.Location = new Point(Size.Width - b.Width - 10, b.Location.Y);
                splitContainer1.Panel2.Hide();
            }
            else
            {
                b.Location = originalpos;
                splitContainer1.Panel2.Show();
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
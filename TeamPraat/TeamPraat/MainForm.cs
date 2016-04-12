using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamPraat.Ui_Elements;

namespace TeamPraat
{
    public partial class MainForm : Form
    {
        private int defaultHeight;
        private int Servers = 0;
        bool MicMuted,SpeakerMuted = false;
        
        public MainForm()
        {
            InitializeComponent();
            defaultHeight = pbEmpty.Location.Y;
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pbEmpty.Location = new Point(pbEmpty.Location.X, pbEmpty.Location.Y + pbEmpty.Height + 10);

            ConnectedServer cs = new ConnectedServer();
            cs.Location = new Point(pbEmpty.Location.X, (defaultHeight + cs.Height) * Servers + 10);
            Servers++;

            panel1.Controls.Add(cs);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Visible)
            {
                splitContainer1.Panel2.Hide();
            }
            else
            {
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(!MicMuted)
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

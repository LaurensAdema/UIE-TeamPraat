using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace TeamPraat.Ui_Elements
{
    public partial class ConnectedServer : UserControl
    {
        private MainForm main;
        private readonly int initHeight;
        private readonly int colapseSize = 50;

        public ConnectedServer(MainForm main)
        {
            this.main = main;
            InitializeComponent();
            initHeight = this.Height;
        }
        
        private void pb_ServerIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Disconnected");
                main.pbEmpty.Location = new Point(main.pbEmpty.Location.X, main.pbEmpty.Location.Y - main.pbEmpty.Height - 10);
                main.Servers--;
                Dispose();
            }
            else
            {
                main.splitContainer1.Panel1.Controls.Clear();
                main.splitContainer1.Panel1.Controls.Add(new Server(main));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(main.selectedServer == this) //inklappen
            {
                this.Size = new Size(this.Width, initHeight);
                main.pbEmpty.Location = new Point(main.pbEmpty.Location.X, main.pbEmpty.Location.Y - colapseSize);
                main.selectedServer = null;
                foreach (ConnectedServer cs in from Control c in main.Controls select c as ConnectedServer into cs where cs?.Location.Y > this.Location.Y select cs)
                {
                    cs.Location = new Point(cs.Location.X, cs.Location.Y - colapseSize);
                }
            }
            else ///uitklappen
            {
                this.Size = new Size(this.Width, this.Height + colapseSize);
                main.pbEmpty.Location = new Point(main.pbEmpty.Location.X, main.pbEmpty.Location.Y + colapseSize);
                main.selectedServer = this;
                foreach (ConnectedServer cs in from Control c in main.Controls select c as ConnectedServer into cs where cs?.Location.Y > this.Location.Y select cs)
                {
                    cs.Location = new Point(cs.Location.X, cs.Location.Y + colapseSize);
                }
            }
        }
    }
}

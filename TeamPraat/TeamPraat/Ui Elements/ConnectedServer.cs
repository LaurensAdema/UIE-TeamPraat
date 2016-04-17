using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TeamPraat.Ui_Elements
{
    public partial class ConnectedServer : UserControl
    {
        private readonly int colapseSize = 50;
        private readonly int initHeight;
        private readonly MainForm main;

        public ConnectedServer(MainForm main)
        {
            this.main = main;
            InitializeComponent();
            initHeight = Height;
            foreach (var c in main.plConnected.Controls)
            {
                ConnectedServer cs = c as ConnectedServer;
                if (cs != null)
                {
                    if (cs.Height != initHeight)
                    {
                        cs.Colaps();
                    }
                }
            }
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Green, ButtonBorderStyle.Solid);
        }

        private void pb_ServerIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Disconnected");
                main.pbEmpty.Location = new Point(main.pbEmpty.Location.X,
                    main.pbEmpty.Location.Y - main.pbEmpty.Height - 12);
                main.Servers--;
                foreach (ConnectedServer cs in from Control c in main.plConnected.Controls
                    select c as ConnectedServer
                    into cs
                    where cs?.Location.Y > Location.Y
                    select cs)
                {
                    cs.Location = new Point(cs.Location.X, cs.Location.Y - cs.Height - 12);
                }
                Dispose();
            }
            else
            {
                main.scMainScreen.Panel1.Controls.Clear();
                main.scMainScreen.Panel1.Controls.Add(new Server(main));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (main.selectedServer == this) //inklappen
            {
                Colaps();
            }
            else //uitklappen
            {
                Expand();
            }
        }

        public void Colaps()
        {
            Size = new Size(Width, initHeight);
            main.pbEmpty.Location = new Point(main.pbEmpty.Location.X, main.pbEmpty.Location.Y - colapseSize);
            main.selectedServer = null;

            foreach (ConnectedServer cs in from Control c in main.plConnected.Controls
                                           select c as ConnectedServer
                into cs
                                           where cs?.Location.Y > Location.Y
                                           select cs)
            {
                cs.Location = new Point(cs.Location.X, cs.Location.Y - colapseSize);
            }
        }

        public void Expand()
        {
            Size = new Size(Width, Height + colapseSize);
            main.pbEmpty.Location = new Point(main.pbEmpty.Location.X, main.pbEmpty.Location.Y + colapseSize);
            main.selectedServer = this;
            foreach (ConnectedServer cs in from Control c in main.plConnected.Controls
                                           select c as ConnectedServer
                into cs
                                           where cs?.Location.Y > Location.Y
                                           select cs)
            {
                cs.Location = new Point(cs.Location.X, cs.Location.Y + colapseSize);
            }
        }
    }
}
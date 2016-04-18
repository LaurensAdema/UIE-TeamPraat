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
        private readonly Server mainServer;
        private Color border;
        private ConnectedServerChannels csc;

        private Color BorderColor {
            get { return border; }
            set { border = value; Refresh(); }
        }
        public string ServerName
        {
            get { return lblServerName.Text; }
            set { lblServerName.Text = value; }
        }

        public ConnectedServer(MainForm main, Server server)
        {
            this.main = main;
            mainServer = server;
            InitializeComponent();
            initHeight = Height;
            foreach (object c in main.plConnected.Controls)
            {
                var cs = c as ConnectedServer;
                if (cs != null)
                {
                    if (cs.Height != initHeight)
                    {
                        cs.Collapse();
                    }
                }
            }
            BorderColor = Color.Red;
            csc = new ConnectedServerChannels();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 3;
            Color borderColor = BorderColor; //SystemColors.AppWorkspace;
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
            borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,
            ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,
            borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

        private void pb_ServerIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (var c in main.plConnected.Controls)
                {
                    ConnectedServer cs = c as ConnectedServer;
                    if (cs != null)
                    {
                        cs.BorderColor = Color.Red;
                    }
                        
                }
                BorderColor = Color.GreenYellow;

                //main.scMainScreen.Panel1.Controls.Clear();
                //main.scMainScreen.Panel1.Controls.Add(new Server(main));
                //Add channels
                foreach (Control c in main.scMainScreen.Panel1.Controls)
                {
                    c.Hide();
                }

                if (main.scMainScreen.Panel1.Controls.Contains(csc))
                {
                    csc.Show();
                }
                else
                {
                    main.scMainScreen.Panel1.Controls.Add(csc);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (main.selectedServer == this) //inklappen
            {
                Collapse();
            }
            else //uitklappen
            {
                Expand();
            }
            
        }

        public void Collapse()
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
                cs.Refresh();
            }
            pbServerSettings.Location = new Point(pbServerSettings.Location.X, pbServerSettings.Location.Y - colapseSize);
            pbServerSettings.Image = global::TeamPraat.Properties.Resources.ic_keyboard_arrow_down_black_24dp_2x1;
            Refresh();
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
                cs.Refresh();
            }
            pbServerSettings.Location = new Point(pbServerSettings.Location.X, pbServerSettings.Location.Y + colapseSize);
            pbServerSettings.Image = global::TeamPraat.Properties.Resources.ic_keyboard_arrow_up_black_24dp_2x;
            Refresh();
        }

        private void pbDisconnect_Click(object sender, EventArgs e)
        {
            Collapse();
            mainServer.ConnecedPeople--;
            mainServer.OpenServer = null;
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

            foreach (Control c in main.scMainScreen.Panel1.Controls)
            {
                c.Hide();
            }

            if (main.scMainScreen.Panel1.Controls.OfType<FirstScreen>().Any())
            {
                main.scMainScreen.Panel1.Controls.OfType<FirstScreen>().First().Show();
            }
            else
            {
                main.scMainScreen.Panel1.Controls.Add(new FirstScreen());
            }
            Dispose();
        }
    }
}
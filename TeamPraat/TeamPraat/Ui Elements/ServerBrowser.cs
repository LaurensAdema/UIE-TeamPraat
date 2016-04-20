using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TeamPraat.Ui_Elements
{
    public partial class ServerBrowser : UserControl
    {
        private MainForm main;
        private List<Server> servers;
        private Random r;

        public ServerBrowser(MainForm main)
        {
            InitializeComponent();

            this.main = main;
            servers = new List<Server>();
            r = new Random();
            int almount = 50 + r.Next(50);
            Names rnames = new Names();

            for (int i = 0; i < almount; i++)
            {
                var s = new Server {bookmark = r.Next(50) == 1, ServerName = "ServerNr: " + rnames.names[r.Next(rnames.names.Count - 1)] + rnames.names[r.Next(rnames.names.Count - 1)], ConnecedPeople = r.Next(1000)};
                servers.Add(s);
            }

            pnlBookmark.Controls.AddRange(servers.Where(s => s.bookmark).ToArray());
            pnlServers.Controls.AddRange(servers.Where(s => !s.bookmark).ToArray());
        }

        private void pnlBookmark_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.Location = new Point(0, (pnlBookmark.Controls.Count - 1) * e.Control.Height + 20);
            pnlBookmark.Height = (pnlBookmark.Controls.Count)*e.Control.Height + 20;
            lblServers.Location = new Point(lblServers.Location.X,
                pnlBookmark.Height + pnlBookmark.Location.Y + lblServers.Height);
            pnlServers.Location = new Point(pnlServers.Location.X, lblServers.Location.Y + 20);
            Console.WriteLine("Controls " + pnlBookmark.Controls.Count + " Height " + pnlBookmark.Height);
        }

        private void pnlServers_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.Location = new Point(0, (pnlServers.Controls.Count - 1) * e.Control.Height + 20);
            pnlServers.Height = (pnlServers.Controls.Count - 1) * e.Control.Height + 20;
        }
    }
}
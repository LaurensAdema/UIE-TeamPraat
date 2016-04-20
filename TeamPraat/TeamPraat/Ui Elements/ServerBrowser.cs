using System;
using System.Collections.Generic;
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
            int almount = r.Next(100);

            for (int i = 0; i < almount; i++)
            {
                var s = new Server {bookmark = r.Next(10) == 1, ServerName = "ServerNr: " + i, ConnecedPeople = r.Next(1000)};
                servers.Add(s);
            }

            pnlBookmark.Controls.AddRange(servers.Where(s => s.bookmark).ToArray());
            pnlServers.Controls.AddRange(servers.Where(s => !s.bookmark).ToArray());
        }
    }
}
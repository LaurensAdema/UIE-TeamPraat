using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamPraat.Ui_Elements
{
    public partial class ServerBrowser : UserControl
    {
        private MainForm main;
        private int DefaultHeight = 12;

        public ServerBrowser(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            main.pbEmpty.Location = new Point(main.pbEmpty.Location.X, main.pbEmpty.Location.Y + main.pbEmpty.Height + DefaultHeight);

            var cs = new ConnectedServer(main);
            cs.Location = new Point(main.pbEmpty.Location.X, (main.defaultHeight + cs.Height) * main.Servers + DefaultHeight);
            main.Servers++;

            main.plConnected.Controls.Add(cs);
        }
    }
}

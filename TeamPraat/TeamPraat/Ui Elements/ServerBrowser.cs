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
    }
}

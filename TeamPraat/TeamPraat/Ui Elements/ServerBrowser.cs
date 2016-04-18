using System.Windows.Forms;

namespace TeamPraat.Ui_Elements
{
    public partial class ServerBrowser : UserControl
    {
        private MainForm main;

        public ServerBrowser(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }
    }
}
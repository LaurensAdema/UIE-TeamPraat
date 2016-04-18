using System.Windows.Forms;

namespace TeamPraat.Ui_Elements
{
    public partial class Channel : UserControl
    {
        public Channel()
        {
            InitializeComponent();
            lbl_ChannelName.Text = "Channel " + Location.Y;
        }
    }
}
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TeamPraat.Ui_Elements
{
    public partial class Channel : UserControl
    {
        public static Channel SelectedChannel;
        public static List<Channel> Allchannels = new List<Channel>();
        private Color border;
        private Color BorderColor
        {
            get { return border; }
            set { border = value; Refresh(); }
        }

        public Channel()
        {
            InitializeComponent();
            lbl_ChannelName.Text = "Channel " + Location.Y;
            BorderColor = Color.Red;
            Allchannels.Add(this);
        }

        private void Channel_Load(object sender, System.EventArgs e)
        {

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

        private void Channel_Click(object sender, System.EventArgs e)
        {
            
            if (SelectedChannel == this)
            {
                SelectedChannel = null;
                BorderColor = Color.Red;
            }
            else
            {
                foreach (var c in Allchannels)
                {
                    c.BorderColor = Color.Red;
                }
                SelectedChannel = this;
                BorderColor = Color.GreenYellow;
            }
            
        }
    }
}
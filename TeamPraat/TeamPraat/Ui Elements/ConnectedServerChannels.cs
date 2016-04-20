using System;
using System.Windows.Forms;

namespace TeamPraat.Ui_Elements
{
    public partial class ConnectedServerChannels : UserControl
    {
        public ConnectedServerChannels()
        {
            InitializeComponent();
            Names name = new Names();
            Random r = new Random();
            int B = r.Next(150);
            for (int i = 0; i < B; i++){
                
                ChatHistory.Text += name.RandomName() + ":Lorem ipsum dolor sit amet, consectetur. \n";
            }
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                String ChatHistString = ChatHistory.Text;
                ChatHistory.Text = "Me:" + textBox1.Text+ "\n" + ChatHistString;
                textBox1.Clear();
            }
        }
    }
}
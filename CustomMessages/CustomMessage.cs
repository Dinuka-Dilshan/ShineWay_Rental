using System;
using ShineWay.Beautify;
using System.Windows.Forms;

namespace ShineWay.CustomMessages
{
    public partial class CustomMessage : Form
    {
        public CustomMessage(string message)
        {
            InitializeComponent();
            new DropShadow().ApplyShadows(this);
            setMessage(message);
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setMessage(string message)
        {
            txtMessage.Text = message;
        }
    }
}

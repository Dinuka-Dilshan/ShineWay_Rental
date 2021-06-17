using System;
using System.Windows.Forms;
using ShineWay.UserInterfaces;
namespace ShineWay
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ;
            this.Hide();
            var form2 = new HomeRceptionist();
            form2.Closed += (s, args) => this.Close();
            form2.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

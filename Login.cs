using System;
using System.Windows.Forms;
using ShineWay.CustomMessages;
using ShineWay.Beautify;
using ShineWay.dbConnection;
using MySql.Data.MySqlClient;
using ShineWay.UserInterfaces;

namespace ShineWay
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            new DropShadow().ApplyShadows(this);
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

            this.Hide();
            var form2 = new HomeRceptionist();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
          /* if(txtPassword.Text.Trim()==""|| txt_UserName.Text.Trim() == "")
            {
                new CustomMessage("User name or password is Empty..!").Show();
            }
            else
            {
              
                string query = " SELECT `Username`,`UserType` FROM `users`   WHERE Username = '" + txt_UserName.Text.Trim() + "' AND Password = '" + txtPassword.Text.Trim() + "';";
                MySqlDataReader reader = DbConnection.readData(query);
                

                if (reader == null)
                {
                    new CustomMessage("User name or password is Incorrect..!").Show();
                }
                while (reader.Read())
                {
                    if(reader[0].ToString().Equals(txt_UserName.Text.Trim()))
                    {
                        this.Hide();
                        var form2 = new HomeRceptionist(reader[1].ToString());
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                }
            }

        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

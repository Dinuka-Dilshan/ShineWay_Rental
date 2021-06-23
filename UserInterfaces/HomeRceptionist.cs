using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShineWay.Beautify;

namespace ShineWay.UserInterfaces
{
    public partial class HomeRceptionist : Form
    {
      
        public HomeRceptionist(string userType)
        {
            StartTimer();
            InitializeComponent();
            new DropShadow().ApplyShadows(this);
            txtUserType.Text = userType;
            
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setSelector(btnHome);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setSelector(btnBooking);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setSelector(btnCustomers);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setSelector(btnPayments);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setSelector(btnUsers);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setSelector(btnVehicleOwners);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setSelector(btnOwnerPayment);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setSelector(btnVehicles);
        }

        private void setSelector(Button btn)
        {
            //set the selector panel to the current selected buton
            pnlSelector.Left = btn.Left;
            pnlSelector.Width = btn.Width;
        }

        System.Windows.Forms.Timer t = null;
        private void StartTimer()
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("hh:mm:ss tt"); ;
        }
    }
}

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
            setUserControl(homeUserControl1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setSelector(btnBooking);
            setUserControl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setSelector(btnCustomers);
            setUserControl();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setSelector(btnPayments);
            setUserControl();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setSelector(btnUsers);
            setUserControl();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setSelector(btnVehicleOwners);
            setUserControl();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setSelector(btnOwnerPayment);
            setUserControl();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setSelector(btnVehicles);
            setUserControl();
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


        void setUserControl(UserControl userControlVisible)
        {
            homeUserControl1.Hide();
            userControlVisible.Show();
        }

        //temporory: until other usercontrols are add.
        void setUserControl()
        {
            homeUserControl1.Hide();
        }

        private void homeUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void HomeRceptionist_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.S)
            {
                homeUserControl1.searchFocus();
            }
        }

    }
}

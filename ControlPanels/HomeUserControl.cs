using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShineWay.ControlPanels
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }


        public void searchFocus()
        {
            txt_search.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox_searchedVehicle.Image = Image.FromFile("C:\\Users\\Dinuka Dilshan\\Desktop\\lady-img.jpg");

        }
    }
}

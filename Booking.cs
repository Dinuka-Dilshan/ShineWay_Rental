using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShineWay
{
    public partial class Booking : UserControl
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void txtDis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSO_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVRN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void txtSea_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t******** SHINEWAY ******     \n\n\tVehicle Renal Company\n\t      +94712345678\n\n"+"Booking ID : " + txtBID.Text+"\nVehicle Number : "+txtVRN.Text+"\nCustomer ID : "+txtCNIC.Text+"\nStart Date : "+dtpSD.Value+"\nEnd Date : "+dtpED.Value+"\nAdvance Payment : "+txtAP.Text + "\nAllowable KM : "+"\nPrice per extra KM : "+"\n\n********************************\n\tImportant \n\n"+"getfrom database"+ "\n\n********************************\n\nTime  :  " +DateTime.Now.ToString("hh:mm:ss tt"));
        }
    }
}

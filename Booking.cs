using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShineWay.dbConnection;
using MySql.Data.MySqlClient;


namespace ShineWay
{
    public partial class Booking : UserControl
    {
        public Booking()
        {
            InitializeComponent();
        }

        /// ///////////////////////////
        String packagetypecombo = null;       // to store the converted combo box value



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
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            
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
            btnSubmit.ForeColor = Color.Green;
            packagetypecombo = cbPT.SelectedItem.ToString();
            MessageBox.Show("\t******** SHINEWAY ******     \n\n\tVehicle Renal Company\n\t      +94712345678\n\n"+"Booking ID : " + txtBID.Text+"\nVehicle Number : "+txtVRN.Text+"\nCustomer ID : "+txtCNIC.Text+"\nStart Date : "+dtpSD.Value.Date.ToString("dd/MM/yyyy") + "\nEnd Date : "+dtpED.Value.Date.ToString("dd/MM/yyyy") + "\nAdvance Payment : "+txtAP.Text + "\nAllowable KM : "+"\nPrice per extra KM : "+"\n\n********************************\n\tImportant \n\n"+"getfrom database"+ "\n\n********************************\n\nTime  :  " +DateTime.Now.ToString("hh:mm:ss tt"));
            //  MySqlDataReader reader = DbConnection.readData("INSERT INTO `booking` ( `Booking_ID`,  `Start_date`,  `Cus_NIC`, `Discription`) VALUES ( Default, '"+dtpSD.Value+ "' ,'"+txtCNIC.Text+"' , '"+txtDis.Text+"');");
            // MySqlDataReader reader = DbConnection.readData("INSERT INTO `booking` (`Vehicle_num`, `Booking_ID`, `Licen_num`, `Start_date`, `Start_ODO`, `Package_Type`, `Cus_NIC`, `Discription`) VALUES ('"+txtVRN.Text+"', null, '"+txtLN.Text+"', '"+dtpSD.Value+"', '"+txtSO.Text+"', '"+cbPT.Text+"', '"+txtCNIC.Text+"', '"+txtDis.Text+"');");
            // MySqlDataReader reader = DbConnection.readData("INSERT INTO `booking` (`Vehicle_num`,  `Licen_num`, `Start_ODO` ) VALUES ('" + txtVRN.Text+"','"+txtLN.Text+"','"+txtSO.Text+"');");
            //MySqlDataReader reader = DbConnection.readData("INSERT INTO `booking` (`Vehicle_num`, `Cus_NIC`, `Licen_num`, `Start_ODO` ) VALUES ('" + txtVRN.Text + "','"+txtCNIC.Text+"','" + txtLN.Text + "','" + txtSO.Text + "');");
            // MySqlDataReader reader = DbConnection.readData("INSERT INTO `booking` (`Vehicle_num`,  `Licen_num`,`Start_ODO`, `Discription` ) VALUES ('" + txtVRN.Text+"','"+txtLN.Text+"','"+txtSO.Text+"','"+txtDis.Text+"' );");
            //MySqlDataReader reader = DbConnection.readData("INSERT INTO `booking` (`Vehicle_num`,  `Licen_num`,`Start_ODO`, `Discription`,  `Cus_NIC` ) VALUES ('" + txtVRN.Text + "','" + txtLN.Text + "','" + txtSO.Text + "','" + txtDis.Text + "' , '"+txtCNIC.Text+"');");
            MySqlDataReader reader1 = DbConnection.readData("INSERT INTO `booking` (`Vehicle_num`,  `Licen_num`,`Start_ODO`, `Discription`,  `Cus_NIC`, `Start_date`, `Package_Type`  ) VALUES ('" + txtVRN.Text + "','" + txtLN.Text + "','" + txtSO.Text + "','" + txtDis.Text + "' , '" + txtCNIC.Text + "','"+dtpSD.Text+"','"+packagetypecombo+"');");
           // MySqlDataReader reader2 = DbConnection.readData("");

        }

        private void butReset_Click(object sender, EventArgs e)
        {
            txtBID.Text = "";
            txtVRN.Text = "";
            txtCNIC.Text = "";
            txtLN.Text = "";
            txtSO.Text = "";
            txtDA.Text = "";
            txtAP.Text = "";
            txtDis.Text = "";
            cbPT.Text = "";
            dtpSD.Text = DateTime.Now.ToString("hh:mm:ss tt");
            dtpED.Text = DateTime.Now.ToString("hh:mm:ss tt");

        }

        private void txtCNIC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtVRN_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSO_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtSea_TextChanged(object sender, EventArgs e)
        {
            MySqlDataReader searchfill = DbConnection.readData("SELECT Deposit_Amount FROM `vehicle` WHERE Vehicle_num = '" + txtVRN.Text + "';");

            while (searchfill.Read())
            {
                txtDA.Text = searchfill[0].ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butReset_MouseHover(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.Red;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.White;
        }

        private void btnSubmit_MouseHover(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Green;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.White;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Yellow;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtVRN_MouseLeave(object sender, EventArgs e)
        {
           
            
        }

        private void txtVRN_MouseLeave_1(object sender, EventArgs e)
        {
           
        }

        private void txtVRN_TextChanged_1(object sender, EventArgs e)
        {
                MySqlDataReader depositefill = DbConnection.readData("SELECT Deposit_Amount FROM `vehicle` WHERE Vehicle_num = '" + txtVRN.Text + "';");
           
                while (depositefill.Read())
                {
                    txtDA.Text = depositefill[0].ToString();
                   
                }
           
        }

        private void txtVRN_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////////////////////////////
            /*
            MySqlDataReader searchfill = DbConnection.readData("SELECT * FROM `booking`;");

            while (searchfill.Read())
            {

            }
            */
            ///////////////////////////////////////////////////////////////////////////////////
        }

    }
}

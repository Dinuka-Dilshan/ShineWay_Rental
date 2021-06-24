using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShineWay
{
    class dbVehicle
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=shineway";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("MySqlconnection!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }
        public static void AddVehicle(VehicleControl vcl)
        {
            string sql = "INSERT INTO `vehicle`(`vehicle_num`, `Brand`, `Model`, `Type`, `Engine_Num`, `Chassis_Num`, `Owner_NIC`, " +
                "`Reg_Date`, `Owner Condition`, `Rent_price`, `Daily_price`, `Daily_KM`, `Weekly_price`, `Weekly_KM`, `Owner_payment`, " +
                "`Starting_odo`, `Monthly_price`, `Monthly_KM`, `Hourly_KM`, `Hourly_price`, `overallview_image`, `insideview_image`) VALUES " +
                "(@vehicleNum, @brand, @model, @type, @engineNum, @chassisNum, @ownerNIC, @regDate, @ownerCondition, @rentprice, @dailyprice, @dailykm," +
                " @weeklyprice,@weeklykm,@ownerpayment,@startingodo,@monthlyprice,@monthlykm, @hourlykm,@hourlyprice, @overallviewimg,@insideviewimg)";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
           // cmd.Parameters.Add("@vehicleNum", MySqlDbType.VarChar).Value = vcl.msktxtVe;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfullly!", "Information", MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Vehicle not insert!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void UpdateVehicle(VehicleControl vcl)
        {
            string sql = "INSERT INTO `vehicle`VALUES (@vehicleNum, @brand, @model, @type, @engineNum, @chassisNum, @ownerNIC, @regDate," +
                " @ownerCondition, @rentprice,@ownerpayment, @startingodo, @dailyprice, @dailykm, @weeklyprice,@weeklykm,@monthlyprice,@monthlykm, @hourlykm,@hourlyprice, @overallviewimg,@insideviewimg)";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
           // cmd.Parameters.Add("@vehicleNum", MySqlDbType.VarChar).Value = vcl.msktxtVe;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfullly!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Vehicle not insert!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}

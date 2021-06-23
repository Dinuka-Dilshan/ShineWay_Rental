using System;
using MySql.Data.MySqlClient;

namespace ShineWay.dbConnection
{
    class DbConnection
    {

        private static MySqlConnection SqlConnection;

        //change here according to your database
        const string str = "datasource=localhost; username=root; password=; database=vehicle_rental";



        //pass the sql query. then the method will return a reader object with the data .
        public static MySqlDataReader readData(String query)
        {
            //create a new conncetion
            SqlConnection = new MySqlConnection(str);
            MySqlDataReader reader = null;

            try
            {
                SqlConnection.Open();//open the connction
                MySqlCommand command = new MySqlCommand(query, SqlConnection);
                reader = command.ExecuteReader();
                return reader;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return reader;
            }

        }

    }
}

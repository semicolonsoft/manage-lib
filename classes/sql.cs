
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Data.SqlClient;
using System.Linq;


namespace LIBRARY.classes
{
    class Dbclass
    {
        public static string getconection()
        {
            string strcon = ConfigurationManager.ConnectionStrings["constring"].ToString();
            return strcon;
        }

        public static string sql;
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand("", con);
        public static SqlDataReader rd;
        public static DataTable dt;

        public static SqlDataAdapter da;


        public static void openconnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = getconection();

                    con.Open();

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("can not connect to data base" + Environment.NewLine
                                 + "description" + ex.Message.ToString());


            }



        }
        public static void closeconnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("can not close data base" + Environment.NewLine
                                 + "description" + ex.Message.ToString());


            }



        }


    }
}


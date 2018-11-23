using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace Query
{
    class MySqlHelper
    {
        public DataTable QueryDB(string sqlStr)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["conMySqlDbCSBG"].ConnectionString.ToString();
            string connectionString = "server=192.168.78.152;userid=root;password=foxlink;database=;charset=utf8";
            using (MySqlConnection sqlconn = new MySqlConnection(connectionString))
            {
                //sqlconn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlStr, sqlconn))
                {
                    cmd.CommandTimeout = 600;
                    MySqlDataAdapter da1 = new MySqlDataAdapter();
                    da1.SelectCommand = cmd;
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "datatable1");
                    DataTable dt1 = ds1.Tables[0];
                    return dt1;
                }
            }
        }

        public DataTable QueryDbAsbg(string sqlStr)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["conMySqlDbASBG"].ConnectionString.ToString();
            string connectionString = "server=192.168.78.153;userid=root;password=foxlink;database=;charset=utf8";
            using (MySqlConnection sqlconn = new MySqlConnection(connectionString))
            {
                //sqlconn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlStr, sqlconn))
                {
                    cmd.CommandTimeout = 600;
                    MySqlDataAdapter da1 = new MySqlDataAdapter(sqlStr, sqlconn);
                    da1.SelectCommand = cmd;
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "datatable1");
                    DataTable dt1 = ds1.Tables[0];
                    return dt1;
                }
            }
        }

        //public DataTable QueryDbAsbg(string sqlStr)
        //{
        //    //string connectionString = ConfigurationManager.ConnectionStrings["conMySqlDbASBG"].ConnectionString.ToString();
        //    string connectionString = "server=192.168.60.112;userid=qr;password=realtime_qr;database=;charset=utf8";
        //    using (MySqlConnection sqlconn = new MySqlConnection(connectionString))
        //    {
        //        //sqlconn.Open();
        //        MySqlDataAdapter da1 = new MySqlDataAdapter(sqlStr, sqlconn);
        //        DataSet ds1 = new DataSet();
        //        da1.Fill(ds1, "datatable1");
        //        DataTable dt1 = ds1.Tables[0];
        //        return dt1;
        //    }
        //}

        public int executeNonQuery111(string sql)
        {
            string connectionString = "server=192.168.78.152;userid=root;password=foxlink;database=;charset=utf8";
           
            using (MySqlConnection sqlconn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(sql, sqlconn);
                //sqlconn.Open();
                int n = cmd.ExecuteNonQuery();
                return n;
            }
        }

        public int executeNonQuery112(string sql)
        {
            string connectionString = "server=192.168.78.153;userid=root;password=foxlink;database=;charset=utf8";

            using (MySqlConnection sqlconn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(sql, sqlconn);
                //sqlconn.Open();
                int n = cmd.ExecuteNonQuery();
                return n;
            }
        }



        public int executeUpdate(string strSQL, List<MySqlParameter> args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conMySqlDB"].ConnectionString.ToString();
            int i = 0;
            using (MySqlConnection sqlconn = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand(strSQL, sqlconn))
                {
                    if (sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();
                    }
                    foreach (MySqlParameter para in args)
                    {
                        cmd.Parameters.Add(para);
                    }

                    i = cmd.ExecuteNonQuery();
                }
            }
            return i;
        }

        public int executeUpdate(string strSQL)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conMySqlDB"].ConnectionString.ToString();
            int i = 0;
            using (MySqlConnection sqlconn = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand(strSQL, sqlconn))
                {
                    i = cmd.ExecuteNonQuery();
                }
            }
            return i;
        }

        public int UpdateDB(string sqlStr)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conMySqlDB"].ConnectionString.ToString();
            int i = 0;
            MySqlConnection sqlconn = new MySqlConnection(connectionString);
            sqlconn.Open();
            MySqlCommand mysqlcom = new MySqlCommand(sqlStr, sqlconn);
            i = mysqlcom.ExecuteNonQuery();
            mysqlcom.Dispose();
            sqlconn.Close();
            sqlconn.Dispose();
            return i;

        }
    }
}

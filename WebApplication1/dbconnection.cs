using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public class dbconnection
    {
        public void InsertSalesman(string salesmanname ,string city,string commission)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("insert into salesman(name,city,commission) values('" + salesmanname + "','" + city + "'," + commission + ")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public void UpdateSalesman(int salesman_id,string salesmanname,string city,string commission)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("update salesman set  name='" + salesmanname + "',city='" + city + "',commission=" + commission + " where salesman_id="+salesman_id+"" ,sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetSalesmans()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from  salesman", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable GetSalesmanbyId(int salesman_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from  salesman where salesman_id="+salesman_id+"", sqlConnection);
            
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable GetSalesmanbyIdToDelete(int salesman_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("delete from  salesman where salesman_id=" + salesman_id + " select * from salesman", sqlConnection);
            
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            //sqlConnection.Close();
            //SqlCommand sqlCommand1 = new SqlCommand("select * from  salesman", sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader dr1 = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;

        }
       

    }
}
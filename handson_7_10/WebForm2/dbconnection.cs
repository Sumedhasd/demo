using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace WebForm2
{
    public class dbconnection
    {
        public void InsertCus(string cusname, string city, string grade,string salesman_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("insert into customer(cus_name,city,grade,salesman_id) values('" + cusname + "','" + city + "'," + grade + ","+ salesman_id+")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public void UpdateCus(int customer_id, string cusname, string city, string grade ,string salesman_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("update customer set  cus_name='" + cusname + "',city='" + city + "',grade=" + grade + ",salesman_id="+salesman_id+" where customer_id=" + customer_id + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetCus()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from  customer", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable GetCusbyId(int customer_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from  customer where customer_id=" + customer_id + "", sqlConnection);

            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable GetCusIdToDelete(int customer_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("delete from  customer where customer_id=" + customer_id + " select * from customer", sqlConnection);

            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
           
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;

        }
        public DataTable GetSalesmanIds()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select salesman_id,name from  salesman", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
          
        }
       
    }
}
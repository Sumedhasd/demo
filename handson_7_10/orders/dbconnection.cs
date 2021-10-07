using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace orders
{
    public class dbconnection
    {
        public void InsertOrd(string purch_amt, string ord_date,  string salesman_id, string customer_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("insert into orders( purch_amt , ord_date ,salesman_id , customer_id ) values(" + purch_amt + ",'" + ord_date + "'," + salesman_id + "," + customer_id + ")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public void UpdateOrd(int ord_no,string purch_amt, string ord_date, string salesman_id, string customer_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("update orders set  purch_amt=" + purch_amt + ",ord_date ='" + ord_date + "',salesman_id =" + salesman_id + ", customer_id =" + customer_id + " where ord_no=" + ord_no+ "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetOrd()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from  orders", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable GetOrdbyId(int ord_no)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from  orders where ord_no=" + ord_no + "", sqlConnection);

            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable GetOrdIdToDelete(int ord_no)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("delete from  orders where ord_no=" +ord_no+ " select * from orders", sqlConnection);

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
        public DataTable GetCustomerIds()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select customer_id,cus_name from  customer", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace webapp
{
    public class dbconnection
    {

        public void InsertOrd(string purch_amt, string ord_date, string salesman_id, string customer_id)
        {
            
            string query="insert into orders( purch_amt , ord_date ,salesman_id , customer_id ) values(" + purch_amt + ",'" + ord_date + "'," + salesman_id + "," + customer_id + ")";
            ExecuteQry(query);

        }
        public void UpdateOrd(int ord_no, string purch_amt, string ord_date, string salesman_id, string customer_id)
        {
            
            string query = "update orders set  purch_amt=" + purch_amt + ",ord_date ='" + ord_date + "',salesman_id =" + salesman_id + ", customer_id =" + customer_id + " where ord_no=" + ord_no + "";
            ExecuteQry(query);
        }
        public DataTable GetOrd()
        {
           
            string query ="select * from  orders";
             return ExecuteQry(query);
        }
        public DataTable GetOrdbyId(int ord_no)
        {
           
            string query = "select * from  orders where ord_no=" + ord_no + "";
            return ExecuteQry(query);

        }
        public DataTable GetOrdIdToDelete(int ord_no)
        {
            
            string query = "delete from  orders where ord_no=" + ord_no + " select * from orders";
            return ExecuteQry(query);


        }
        public DataTable GetSalesmanIds()
        {
           
            string query = "select salesman_id,name from  salesman";
            return ExecuteQry(query);

        }
        public DataTable GetCustomerIds()
        {
            string query= "select customer_id,cus_name from  customer";
            return ExecuteQry(query);

        }
        public DataTable ExecuteQry(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-C4VNSL6S\SQLEXPRESS;Initial Catalog=webapp;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
    }
}
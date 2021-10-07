using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace orders
{
    public partial class WebForm4 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            dbconnection dbobj = new dbconnection();
            DataTable dtordResult = dbobj.GetOrd();
            GridView1.DataSource = dtordResult;
            GridView1.DataBind();
            if (!IsPostBack)
            {
                dbconnection dbConnection = new dbconnection();
                DataTable dt = dbConnection.GetSalesmanIds();
                ddlSalesmanid.Items.Add("--Select--");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ddlSalesmanid.Items.Add(new ListItem(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
                }

                DataTable dt1 = dbConnection.GetCustomerIds();
                ddlcusid.Items.Add("--Select--");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ddlcusid.Items.Add(new ListItem(dt1.Rows[i][0].ToString() + " - " + dt1.Rows[i][1].ToString(), dt1.Rows[i][0].ToString()));
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string amt = txtpurch_amt.Text;
            string date = txtord_date.Text;
            
            dbconnection dbobj = new dbconnection();
            dbobj.UpdateOrd(Convert.ToInt32(Label1.Text), amt,date, ddlSalesmanid.SelectedItem.Value,ddlcusid.SelectedItem.Value);
            DataTable dtOrdResult = dbobj.GetOrd();
            GridView1.DataSource = dtOrdResult;
            GridView1.DataBind();


        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            string amt = txtpurch_amt.Text;
            string date = txtord_date.Text;


            dbconnection dbobj = new dbconnection();
            dbobj.InsertOrd(amt, date, ddlSalesmanid.SelectedItem.Value, ddlcusid.SelectedItem.Value);
            DataTable dtOrdResult = dbobj.GetOrd();
            GridView1.DataSource = dtOrdResult;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int ord_no = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Edit")
            {

                dbconnection db = new dbconnection();
                DataTable dt = db.GetOrdbyId(ord_no);
                txtpurch_amt.Text = dt.Rows[0][1].ToString();
                txtord_date.Text = dt.Rows[0][2].ToString();
               
                Label1.Text = dt.Rows[0][0].ToString();


            }
            if (e.CommandName == "Delete")
            {

                dbconnection db = new dbconnection();
                DataTable dt = db.GetOrdIdToDelete(ord_no);

                txtpurch_amt.Text = "";
                txtord_date.Text = "";
                Label1.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
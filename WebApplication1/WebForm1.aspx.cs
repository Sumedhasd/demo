using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbconnection dbobj = new dbconnection();
            DataTable dtSalesmanResult = dbobj.GetSalesmans();
            GridView1.DataSource = dtSalesmanResult;
            GridView1.DataBind();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            string salesmanname = txtSalesmanname.Text;
            string city = txtSalesmancity.Text;
            string commission = txtSalesmancommission.Text;
            dbconnection dbobj = new dbconnection();
            dbobj.InsertSalesman(salesmanname, city, commission);
            DataTable dtSalesmanResult = dbobj.GetSalesmans();
            GridView1.DataSource = dtSalesmanResult;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string salesmanname = txtSalesmanname.Text;
            string city = txtSalesmancity.Text;
            string commission = txtSalesmancommission.Text;
            dbconnection dbobj = new dbconnection();
            dbobj.UpdateSalesman(Convert.ToInt32(Label1.Text),salesmanname, city, commission);
            DataTable dtSalesmanResult = dbobj.GetSalesmans();
            GridView1.DataSource = dtSalesmanResult;
            GridView1.DataBind();


        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int salesman_id = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Edit")
            {

                dbconnection db = new dbconnection();
                DataTable dt = db.GetSalesmanbyId(salesman_id);
                txtSalesmanname.Text = dt.Rows[0][1].ToString();
                txtSalesmancity.Text = dt.Rows[0][2].ToString();
                txtSalesmancommission.Text = dt.Rows[0][3].ToString();
                Label1.Text = dt.Rows[0][0].ToString();

            }
            if (e.CommandName == "Delete")
            {

                dbconnection db = new dbconnection();
                DataTable dt = db.GetSalesmanbyIdToDelete(salesman_id);

                txtSalesmanname.Text = "";
                txtSalesmancity.Text = "";
                txtSalesmancommission.Text = "";
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
    }
}
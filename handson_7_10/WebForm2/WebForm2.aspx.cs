using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace WebForm2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbconnection dbobj = new dbconnection();
            DataTable dtCusResult = dbobj.GetCus();
            GridView1.DataSource = dtCusResult;
            GridView1.DataBind();
            if (!IsPostBack)
            {
               dbconnection dbConnection = new dbconnection();
                DataTable dt = dbConnection.GetSalesmanIds();
                ddlSalesmanid.Items.Add("--Select--");
                //ddlSalesmanid.DataSource = dt;
                //ddlSalesmanid.DataTextField = "name";
                //ddlSalesmanid.DataValueField = "salesman_id";
                //ddlSalesmanid.DataBind();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //ddlSalesmanid.Items.Add(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString());
                    ddlSalesmanid.Items.Add(new ListItem(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cusname = txtcusname.Text;
            string city = txtcity.Text;
            string grade = txtgrade.Text;
            dbconnection dbobj = new dbconnection();
            dbobj.UpdateCus(Convert.ToInt32(Label1.Text), cusname, city, grade, ddlSalesmanid.SelectedItem.Value);
            DataTable dtCusResult = dbobj.GetCus();
            GridView1.DataSource = dtCusResult;
            GridView1.DataBind();


        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            string cusname = txtcusname.Text;
            string city = txtcity.Text;
            string grade = txtgrade.Text;

            
            dbconnection dbobj = new dbconnection();
            dbobj.InsertCus(cusname, city, grade, ddlSalesmanid.SelectedItem.Value);
            DataTable dtCusResult = dbobj.GetCus();
            GridView1.DataSource = dtCusResult;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int customer_id = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Edit")
            {

                dbconnection db = new dbconnection();
                DataTable dt = db.GetCusbyId(customer_id);
                txtcusname.Text = dt.Rows[0][1].ToString();
                txtcity.Text = dt.Rows[0][2].ToString();
                txtgrade.Text = dt.Rows[0][3].ToString();
                Label1.Text = dt.Rows[0][0].ToString();
                

            }
            if (e.CommandName == "Delete")
            {

                dbconnection db = new dbconnection();
                DataTable dt = db.GetCusIdToDelete(customer_id);

                txtcusname.Text = "";
                txtcity.Text = "";
                txtgrade.Text = "";
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
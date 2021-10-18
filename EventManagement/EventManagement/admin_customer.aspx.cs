using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EventManagement_Business;
using EventManagement_Data;

namespace EventManagement
{
    public partial class admin_customer : System.Web.UI.Page
    {
        EM_business businessobj = new EM_business();
        EM_data dataobject = new EM_data();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {

            if (txtadmincus.Text == "Customer")
            {
                string userobj = txtusername.Text;

                string password = txtpassword.Text;
                string[] result = businessobj.VerifyUserDetails(userobj);

                if (result== null)
                {
                    lblresult.Text = "Wrong username.Try again.";

                }
                else
                {
                    if (password != result[0])
                    {
                        lblresult.Text = "Wrong password.Try again.";
                    }
                    else
                    {
                        Response.Redirect("Foodorderpage.aspx?id="+result[1]);
                        
                    }
                }
                
            }
            else
            {
                string userobj = txtusername.Text;

                string password = txtpassword.Text;
                if (password == businessobj.VerifyAdminDetails(userobj))
                {
                    lblresult.Text = "signed in successfully";
                    Response.Redirect("AdminVerification.aspx");
                }
                else
                    lblresult.Text = "Wrong username and password.Try again.";
            }
        }
    }
}
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
    public partial class User_registration_page : System.Web.UI.Page
    {
        EM_business businessobj = new EM_business();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            userregistration userreg = new userregistration();
            userreg.Firstname = txtfirstname.Text;
            userreg.Lastname = txtlastname.Text;
            userreg.password = txtpassword.Text;
            userreg.Email = txtemailid.Text;
            userreg.Phone = Convert.ToInt32(txtphone.Text);
            userreg.Address = txtaddress.Text;
            lbltext.Text = businessobj.InsertUserDetails(userreg);
            
            Response.Redirect("admin_customer.aspx");
        }
    }
}
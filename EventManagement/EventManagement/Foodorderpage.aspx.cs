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
    public partial class Foodorderpage : System.Web.UI.Page
    {
        EM_business busobj = new EM_business();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnbookevent_click(object sender, EventArgs e)
        {
            bookvenue bookvenueobj = new bookvenue();
            bookvenueobj.id = Convert.ToInt32(Request.QueryString["id"]) ;
            bookvenueobj.eventtype = eventtype.SelectedValue;
            bookvenueobj.venuetype = venuetype.SelectedValue;
            bookvenueobj.noofguest = Convert.ToInt32(txtnoofguest.Text);
            bookvenueobj.Bookingdate = Convert.ToDateTime(txtbookingdate.Text);
            lblapproval.Text = busobj.InsertVenueDetails(bookvenueobj);
            //Response.Redirect("Booking details.aspx?id=" + bookvenueobj.id);
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            eventtype.SelectedValue = "select";
            venuetype.SelectedValue = "select";
            txtnoofguest.Text = "";
            txtbookingdate.Text = "";
        }

        protected void btnsavedish_Click(object sender, EventArgs e)
        {

        }

        protected void tncanceldish_Click(object sender, EventArgs e)
        {
           
        }
    }
}
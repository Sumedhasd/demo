﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventManagement
{
    public partial class Booking_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtbookingdet.Text = Request.QueryString["id"];
        }
    }
}
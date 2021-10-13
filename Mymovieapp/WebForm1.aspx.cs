using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mymoviebusiness;
using Mymoviedata;
using System.Data;
using System.Data.Entity;

namespace Mymovieapp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        moviebusiness moviedata = new moviebusiness();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            movie movie = new movie();
            movie.Name = txtname.Text;
            movie.MovieType = txtmovietype.Text;
            movie.MovieDesc = txtmoviedes.Text;
            lbltext.Text=moviedata.InsertMovie(movie);

            DataTable dtresult = new DataTable();
            dtresult = moviedata.SelectMovie();
            GridView1.DataSource = dtresult;
            GridView1.DataBind();
        }
    }
}
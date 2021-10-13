using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mymoviedata;
using System.Data;

namespace Mymoviebusiness
{
    public class moviebusiness
    {
        moviedata moviedata = new moviedata();
        public string InsertMovie(movie movie)
        {
            return moviedata.InsertMovie(movie);
        }
        public DataTable SelectMovie()
        {
            return moviedata.SelectMovie();
        }
    }
}

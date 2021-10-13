using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Reflection;

namespace Mymoviedata
{
    public class moviedata
    {
        project_12_10Entities entobj = new project_12_10Entities();
        public string InsertMovie(movie movie)
        {
           
            entobj.movies.Add(movie);
            entobj.SaveChanges();
            return "Movie Added successfully!";
        }
        public DataTable SelectMovie()
        {
            var res = entobj.movies.ToList();
            DataTable dtres = new DataTable();
            dtres = ToDataTable<movie>(res);
            return dtres;
        }
        public DataTable ToDataTable<T>(List<T> items)
        {

            DataTable dt = new DataTable(typeof(T).Name);
            PropertyInfo[] pros = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach(PropertyInfo prop in pros)
            {
                dt.Columns.Add(prop.Name);
            }
            foreach(T item in items)
            {
                var values = new object[pros.Length];
                for(int i=0;i<pros.Length;i++)
                {
                    values[i] = pros[i].GetValue(item, null);
                }
                dt.Rows.Add(values);

            }

            return dt;
            
        }
    }
}

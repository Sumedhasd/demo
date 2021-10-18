using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement_Data
{
    public class EM_data
    {
        EventManagementSystemEntities entobj = new EventManagementSystemEntities();
       
        public string InsertUserDetails(userregistration userreg)
        {
            entobj.userregistrations.Add(userreg);
            entobj.SaveChanges();
            return "Details Added Successfully!!";
        }
        public string[] VerifyUserDetails(string userobj)
        {

            var result = entobj.userregistrations.ToList().Find(obj => obj.Email == userobj);
            if (result == null)
            {
                string[] op = null;
                return op;
            }
            else
            {
                string[] op = { result.password, Convert.ToString(result.id) };
                return op;
            }
            
                
          

               
        }
        public string VerifyAdminDetails(string userobj)
        {

            var result = entobj.admindetails.ToList().Find(obj => obj.Email == userobj);

            string res = result.password;
            return res;
        }
        public string InsertVenueDetails(bookvenue bookvenueobj)
        {
            entobj.bookvenues.Add(bookvenueobj);
            entobj.SaveChanges();
            return "Waiting for admin approval";
        }
    }
}

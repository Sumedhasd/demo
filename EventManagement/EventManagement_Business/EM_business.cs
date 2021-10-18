using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement_Data;

namespace EventManagement_Business
{
    public class EM_business
    {
        EM_data dataobj = new EM_data();
        public string InsertUserDetails(userregistration userreg)
        {
            return dataobj.InsertUserDetails(userreg);
        }
        public string[] VerifyUserDetails(string userobj)
        {
            string[] res = dataobj.VerifyUserDetails(userobj);
            return res;
        }
        public string VerifyAdminDetails(string userobj)
        {
            string res = dataobj.VerifyAdminDetails(userobj);
            return res;
        }
        public string InsertVenueDetails(bookvenue bookvenueobj)
        {
            return dataobj.InsertVenueDetails(bookvenueobj);
        }
    }
}

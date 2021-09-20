using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class bookTickets
    {
       public void ticketbooking()
    {
        Console.WriteLine("normal ticket booked");
    }
      }
public class bookEtickets : bookTickets
{
    public void eticketbooking()
    {
        Console.WriteLine("e ticket booked");
    }
}
public class viewMaintenance
    {
    public void details()
    {
        Console.WriteLine("Maintenance Details ");
    }
}


namespace asssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            bookEtickets obj = new bookEtickets();
            Console.WriteLine("Do you want to book normal ticket or e ticket:");
            string response = Console.ReadLine();
            if (response == "normal ticket")

            { obj.ticketbooking();
            }
            else
            { 
                        obj.eticketbooking();
        }

            viewMaintenance obj1 = new viewMaintenance();
            obj1.details();

            Console.ReadLine();
        }
    }
}

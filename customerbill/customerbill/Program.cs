using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            var consumerno = new List<int>();
            var consumername = new List<string>();
            var totalunits = new List<int>();
            var totalamount = new List<int>();

            int unitpercost = 10;

            Console.WriteLine("Enter the total no of Customers:");
            int totalcustomer = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(totalcustomer);
            for (int i = 0; i < totalcustomer; i++)
            {
                Console.WriteLine($"Enter the customerno of Customer{i+1}");
                consumerno.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"Enter the customername of Customer{i + 1}");
                string a = Console.ReadLine();
                consumername.Add(a);
                Console.WriteLine($"Enter the totalunits of Customer{i + 1}");
                int b = Convert.ToInt32(Console.ReadLine());
                totalunits.Add(b);
                totalamount.Add(unitpercost * totalunits[i]);

            }
            StreamWriter sw = new StreamWriter(@"C:\Users\Sumedha Desai\Documents\My files\customerbill.txt");

            for (int i = 0; i < totalcustomer; i++)
            {
                sw.WriteLine($"billno of Customer{i + 1}:{i + 1}");
                sw.WriteLine($"customerno of Customer{i + 1}:{consumerno[i]}");
                sw.WriteLine($"Totalamount of Customer{i + 1}:{totalamount[i]}");
                sw.WriteLine( "Due date: 24/09/2021");
                sw.WriteLine("*******************");
            }

            sw.Close();
            Console.ReadLine();

        }
    }
}

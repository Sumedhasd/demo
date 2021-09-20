using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight;
            string pclass;
            float amount=0;
            Console.WriteLine("Total Weight of the Luggage:");
            weight=float.Parse(Console.ReadLine());
          
            Console.WriteLine("Enter the class of the passenger:");
            pclass = Console.ReadLine().ToLower();
            
            if (pclass =="first class" )
            {
                if (weight > 50)
                {
                    amount = (weight - 50) * 2;
                }
            }
            else if (pclass == "business class")
            {
                if (weight > 40)
                {
                    amount = (weight - 40) * 2;
                }
            }
            else
            {
                if (weight > 20)
                {
                    amount = (weight - 20) * 2;
                }
            }
            Console.WriteLine(amount);
            Console.ReadLine();

            
        }
    }
}

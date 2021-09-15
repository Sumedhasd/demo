using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Handon2
{
    class Class1
    {

        int n;
        string r;
        string c;
        string ct;
        public string Writefile()
        {

            Console.WriteLine("Course details:");
            Console.WriteLine("Enter no of courses:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            FileStream fs = new FileStream(@"C:\Users\Sumedha Desai\Training\demo folder\file handling\test.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Course details:");
            sw.WriteLine("Enter the no of courses:" + n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Regno:");
                r = Console.ReadLine();
                Console.WriteLine("Enter Course:");

                c = Console.ReadLine();
                Console.WriteLine("Enter Course title:");
                ct = Console.ReadLine();
                Console.WriteLine();


                sw.WriteLine("Reg no:" + r);
                sw.WriteLine("course:" + c);
                sw.WriteLine("coursetitle:" + ct);



            }
            sw.Close();
            fs.Close();





            return " welcome";
        }
    }
}

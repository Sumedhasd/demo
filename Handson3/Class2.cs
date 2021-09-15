using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Handson3
{
    class Class2
    {
        public string Readfile()

        {
            Console.WriteLine("Mobile Network performance");
            Console.WriteLine("******************************************************");
            Console.WriteLine("Source" + "\t\t" + "Destination \tDate and time\t\tcall-status");
            FileStream fs = new FileStream(@"C:\Users\Sumedha Desai\Training\demo folder\file handling\network.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int i = 0;
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                if (line.Contains(":"))
                {

                    string[] data = line.Split(':');
                    if (data.Length > 2)
                    {
                        Console.Write(data[1] + ":" + data[2] + ":" + data[3] + "\t");
                    }
                    else
                    {
                        Console.Write(data[1] + "\t");
                    }
                    i++;
                    if (i % 4 == 0)
                    {
                        Console.WriteLine();
                    }
                }


            }
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uncomment the codes to run
            //file creation
            //FileStream fs = new FileStream(@"C:\Users\Sumedha Desai\Training\demo folder\file handling\mytest.txt", FileMode.Create, FileAccess.ReadWrite);
            //Console.WriteLine("File is created");
            //Console.Read();

            //file deletion
            //File.Delete(@"C:\Users\Sumedha Desai\Training\demo folder\file handling\mytest1.txt");
            //Console.WriteLine("File is deleted");
            //Console.Read();

            //program3
            //if (File.Exists(@"C:\Users\Sumedha Desai\Training\demo folder\file handling\mytest1.txt"))
            //{
            //    Console.WriteLine("File is created with the same name already");
            //}
            //else
            //{
            //    FileStream fs = new FileStream(@"C:\Users\Sumedha Desai\Training\demo folder\file handling\mytest1.txt", FileMode.Create, FileAccess.ReadWrite);
            //    Console.WriteLine("File is created");
            //}
            //Console.Read();

            //Program4
            FileStream fs = new FileStream(@"C:\Users\Sumedha Desai\Training\demo folder\file handling\mytest6.txt", FileMode.Create, FileAccess.Write);
            StreamWriter obj = new StreamWriter(fs);
            obj.WriteLine("Hello Everyone :)");
            obj.Close();
            Console.ReadLine();

            //Program5

            //FileStream fs = new FileStream(@"C:\Users\Sumedha Desai\Training\demo folder\file handling\mytest7.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter obj = new StreamWriter(fs);
            //obj.WriteLine("Hello Everyone");
            //obj.Close();
            //StreamReader ob = new StreamReader(@"C:\Users\Sumedha Desai\Training\demo folder\file handling\mytest7.txt");
            //string sr = ob.ReadLine();
            //Console.WriteLine(sr);
            //ob.Close();
            //Console.ReadLine();









        }
    }
}

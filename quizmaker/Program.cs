using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace quizmaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Sumedha Desai\Downloads\sample-quiz-file.txt");
            int x = 1,count=0;
            foreach (string line in lines)
            {
                string s = line;
                int m = 0;
                foreach (char c in s)
                {   
                    if (x==5)
                    {
                        x = 1;
                    }
                    if (c is '|')
                    {
                        Console.WriteLine();
                        Console.Write(x+" ");
                        x = x + 1;
                    }
                    else if (c is '*')
                    {
                        m = x-1;
                    
                    }
                   
                    else
                    {
                        Console.Write(c);
                    }
                    
                }
                Console.WriteLine();

                int res = Convert.ToInt32(Console.ReadLine());
                Console.Write(res);
                Console.WriteLine();
                if (m==res)
                {
                    Console.WriteLine("Right!!");
                    count++;
                }
                else
                {
                    Console.WriteLine("Sorry that isnt right answer");

                }


            }
            Console.WriteLine($"You got {count} answer/s among {lines.Length} questions asked");
            Console.ReadLine();
        }
    }
}

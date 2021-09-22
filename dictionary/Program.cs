using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Dictionary<int, string> dictionaryplayer = new Dictionary<int, string>();
        dictionaryplayer.Add(1,"player 5");
        dictionaryplayer.Add(2, "player 1");
        dictionaryplayer.Add(3, "player 3");
        dictionaryplayer.Add(4, "player 2");
        dictionaryplayer.Add(5, "player 4");
        Console.WriteLine(dictionaryplayer.Count);
        
        
        
        dictionaryplayer[1] = "player 4";
        dictionaryplayer[5] = "player 5";
        
        for(int i=0;i< dictionaryplayer.Count; i++)
            {
                Console.WriteLine(i + 1 + ":" + dictionaryplayer[i+1]);
                
            }
            Console.ReadLine();



        }
    }
}

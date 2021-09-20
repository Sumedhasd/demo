using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace serial
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public City City = new City();
        
    }
    [Serializable]
    public class City 
    {
        public string name { get; set; }
        public int population { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

           
            City  city1 =new City(){name = "Spain", population = 13456766 } ;
            Person person = new Person() { Name = "Nauj", Age = 26, City = city1};


            BinaryFormatter formatter = new BinaryFormatter();
            
            Stream stream = new FileStream(@"C:\Users\Sumedha Desai\Documents\My files\example.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, person);
            stream.Close();

           
  
            stream = new FileStream(@"C:\Users\Sumedha Desai\Documents\My files\example.txt", FileMode.Open, FileAccess.Read);
            
            Person obj = (Person)formatter.Deserialize(stream);
            
            Console.WriteLine(obj.Name.ToString());
            Console.WriteLine(obj.Age.ToString());
            Console.WriteLine(obj.City.name);
            Console.WriteLine(obj.City.population);
            

            Console.ReadLine();

        }
    }
}

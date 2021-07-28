using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Denzel";
            person.LastName = "Bledsoe";
            person.DOB = new DateTime(1991, 2, 11);
            person.Favorites = new List<string> { "Games", "Movies"};

            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}

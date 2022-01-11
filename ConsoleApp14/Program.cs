using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ananya", "Bhannu", "Chinnu", "Candy", "Daniel", "Grace", "Joel", "Kamal", "Nikki", "Ruben", "Riyansh", "Sneha", "Thaiba" };
            
            UsingLinq(names);
            
        }

        private static void UsingLinq(string[] names)
        {
            IEnumerable<string> query = from s in names                                        
                                        where s.Length == 5
                                        orderby s
                                        select s.ToUpper();
                                        

            foreach (string item in query)
                Console.WriteLine(item);

            Console.Read();
        }
    }
}

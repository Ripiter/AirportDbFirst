using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Done");
            Console.ReadKey();

        }

        static void AddAirport()
        {
            using (var context = new DbFirstEntities())
            {
                var airport = new Airport()
                {
                    City = "Warsaw",
                    Iata = "Waw"
                };
                context.Airports.Add(airport);

                context.SaveChanges();
            }
        }
    }
}

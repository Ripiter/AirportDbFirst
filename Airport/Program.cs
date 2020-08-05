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
            using (var context = new DbFirstEntities1())
            {
                var result = context.GetCompanyNameByID(2);

                Console.WriteLine(result.First());
                

                var result2 = context.GetPlanesFromDestination("CPH");

                foreach (var item in result2)
                {
                    Console.WriteLine(item.Company.CompanyName);
                }


            }

            Console.WriteLine("Done");
            Console.ReadKey();

        }
    }
}

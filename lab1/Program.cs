using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new Lab1Context())
            {
                db.Cinemas.Add(new Cinemas { CityId=1, Name="NewKino" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All cinemas in database:");
                foreach (var cinema in db.Cinemas)
                {
                    Console.WriteLine(" - {0}", cinema.Name);
                }
                Console.ReadLine();
            }

        }
    }
}

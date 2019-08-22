using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCF.DAL;

namespace EFCF
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new AndrewContext())
            {
                var customers = context.Customers.ToList();

                Console.WriteLine("Done");
                Console.ReadLine();
            }
        }
    }
}

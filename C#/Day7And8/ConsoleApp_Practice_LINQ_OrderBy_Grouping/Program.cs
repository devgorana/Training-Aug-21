using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice_LINQ_OrderBy_Grouping
{
    class Practice_LINQ_OrderBy_Grouping
    {
        static void Main(string[] args)
        {
            var query = from method in typeof(double).GetMethods()
                        orderby method.Name
                        group method by method.Name into groups
                        select new { MethodName = groups.Key, NumberOfOverloads = groups.Count() };

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

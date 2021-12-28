using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Practice on Linq
namespace ConsoleApp_Day_7_And_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var primes = new List<int> { 1, 2, 3, 5, 7, 11, 13, 17, 19, 23 };

            //print value using LINQ Query
            var query = from val in primes
                        where val < 13
                        select val;
            foreach( var val in query)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("\n");

            //print value using LINQ Methods
            var methodQuery = primes.Where(x => x < 11);
            foreach (var val in methodQuery)
            {
                Console.WriteLine(val);
            }

            Console.ReadLine();
        }
    }
}

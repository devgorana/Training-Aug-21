using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a list which will store 5 student names and then display it search it index number

namespace ConsoleApp_Day_5_Practice_1
{
    class student
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Devendra", "Raj", "Bhavik", "Sanjay", "Pankaj" };

            Console.Write("Enter The Index Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(names[num]);
            /*foreach (var name in names)
            {
                Console.WriteLine($" {name.ToUpper()}!");
            }*/
            Console.ReadLine();
        }
    }
}

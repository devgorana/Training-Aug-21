using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assingment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accept Age from user, if age is more than 18 eligible for vote otherwise it should be displayed as not eligible. Do it with ternary operator
            Console.Write("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            var result = age > 18 ? "You are Eligible to give Vote." : "You are Not Eligible to give Vote.";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

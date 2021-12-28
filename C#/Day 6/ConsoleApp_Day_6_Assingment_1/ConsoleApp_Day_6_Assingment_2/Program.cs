using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Compute add of two number using lambda expression
namespace ConsoleApp_Day_6_Assingment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Func<int, int, int> sum = (x, y) => x + y;
            //int ans => num1 + num2;
            Console.WriteLine("Sum of tow Number is " + sum.Invoke(num1, num2));
            Console.ReadLine();
        }
    }
}

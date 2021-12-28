using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assingment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print sum of all the even numbers
            int i, number, Sum = 0;

            Console.WriteLine("Please Enter the Maximum Limit Value :");
            number = Convert.ToInt32(Console.ReadLine());
            

            Console.Write("Even Numbers Between 0 And " + number + " Are : ");
            for (i = 2; i <= number; i = i + 2)
            {
                Sum = Sum + i;
                Console.Write(i + " ");
            }
            Console.WriteLine("\nThe Sum of All Even Numbers upto" + number + " is " + Sum);
            Console.ReadLine();
        }
    }
}

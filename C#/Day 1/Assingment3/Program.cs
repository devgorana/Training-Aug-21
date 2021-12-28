using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assingment_3
{
    class Program
    {
        enum weekday
        {
            Monday=1,
            Tuesday,
            Wenesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Week day : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num >0 && num < 8)
            {
                weekday weekname = (weekday)num;
                Console.WriteLine("Day is " + weekname);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Input!");
                Console.ReadLine();
            }
            
        }
    }
}

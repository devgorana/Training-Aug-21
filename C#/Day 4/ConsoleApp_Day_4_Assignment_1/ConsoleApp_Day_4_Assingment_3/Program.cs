using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a user defined Exception DateException class which will validate date should not be less than the current date.
//If date is less than current date it should throw an exception.

namespace ConsoleApp_Day_4_Assingment_3
{

    public class DateException : Exception
    {
        public DateException(string message)
           : base(message)
        {
            Console.Write("ErrorInvalidDate : ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date formate Should be dd/mm/yyyy.");
            Console.Write("Enter Date : ");
            var date = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
            var todaysDate = DateTime.Today;
            //string date = Console.ReadLine();
            
            try
            {
                if (date < todaysDate)
                {
                    throw new DateException("Access denied - Please enter Valid Date.");
                }
                else
                {
                    Console.WriteLine("Date is " + date + ".");
                    Console.ReadLine();
                }
            }
            catch (DateException e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}

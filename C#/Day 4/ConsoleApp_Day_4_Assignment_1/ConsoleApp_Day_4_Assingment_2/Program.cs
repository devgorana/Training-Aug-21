using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a user defined exception class NameException which will validate a Name and name should contain only character.
//If name does not contain proper value it should throw an exception. You need to handle exception in student class.

namespace ConsoleApp_Day_4_Assingment_2
{

    public class NameException : Exception
    {
        public NameException(string message)
           : base(message)
        {
            Console.Write("ErrorInvalidName : ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();
            bool result = name.All(Char.IsLetter);
            try
            {
                if (result == false)
                {
                    throw new NameException("Access denied - Please enter all char.");
                }
                else
                {
                    Console.WriteLine("You are name is " + name + ".");
                    Console.ReadLine();
                }
            }
            catch (NameException e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}

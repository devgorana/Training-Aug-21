using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Create a user defined Exception Class AgeException. If Age is less than 0 it should be thrown an exception. And you need to handle that exception in student class.
//Note to create a user defined exception class you need to derive it from System.Exception class.

namespace ConsoleApp_Day_4_Assignment_1
{
    public class AgeException : Exception
    {
        public AgeException(string message)
           : base(message)
        {
            Console.Write("ErrorInvalidAge : ");
        }
    }

    

    class student
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (age <= 0)
                {
                    throw new AgeException("Access denied - You must be at least 1 years old.");
                }
                else
                {
                    Console.WriteLine("You are " + age + " years old.");
                    Console.ReadLine();
                }
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}

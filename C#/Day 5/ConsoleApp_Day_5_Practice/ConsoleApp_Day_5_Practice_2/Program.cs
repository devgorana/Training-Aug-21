using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Create a stack which will store Age of person and display it last in first out order.

namespace ConsoleApp_Day_5_Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new Stack.
            Stack age = new Stack();
            age.Push("18");
            age.Push("19");
            age.Push("20");
            age.Push("27");
            age.Push("25");
            age.Push("24");
            age.Push("32");
            //myStack.Pop();
            //Console.WriteLine(age.Peek());
            
            // Displays the properties and values of the Stack.
            //Console.WriteLine("myStack");
            //Console.WriteLine("\tCount:    {0}", age.Count);
            //Console.Write("\tValues:");
            PrintValues(age);
            Console.ReadLine();
        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
          
        }
    }
}

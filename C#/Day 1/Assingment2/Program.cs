using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assingment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Store your name in one string and find out how many vowel characters are there in your name.
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            int namelen = name.Length;
            int numofvowel = 0;

            for (int i = 0; i < namelen ; i++)
            {
                if (name[i] == 'a' || name[i] == 'A' || name[i] == 'e' || name[i] == 'E' || name[i] == 'i' || name[i] == 'I' || name[i] == 'o' || name[i] == 'O' || name[i] == 'u' || name[i] == 'U')
                {
                    numofvowel++;
                }
            }

            Console.WriteLine("Total Number of Vowels in Given Name is " + numofvowel);
            Console.ReadLine();
        }
    }
}

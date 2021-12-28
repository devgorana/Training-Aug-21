using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Assingment
namespace ConsoleApp_Day_5_Assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter total number of data you want to insert : ");
            int totalNumofData = Convert.ToInt32(Console.ReadLine());
            List<string> Mobike = new List<string>();

            input(totalNumofData,Mobike);
            display(totalNumofData, Mobike);

            Console.ReadLine();
            
            /*foreach (string element in Mobike)
            {
                
                Console.Write(element + "\t");
            }*/
            
            /*Mobike[] mbdata = new Mobike[totalNumofData];
            for (int i = 0; i < totalNumofData; i++)
            {
                //student[] data = new student[i];
                Console.WriteLine("\nEnter Customer " + (i + 1) + " Data ");

                mbdata[i] = new Mobike();
                Console.Write("Enter Bike Number : ");
                mbdata[i].bikeNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Phone Number : "); 
                mbdata[i].phoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name : ");
                mbdata[i].name = Console.ReadLine();
                Console.Write("Enter Day : ");
                mbdata[i].day = Convert.ToInt32(Console.ReadLine());

                string[] demo = { Convert.ToString(mbdata[i].bikeNumber), Convert.ToString(mbdata[i].phoneNumber), mbdata[i].name, Convert.ToString(mbdata[i].day) };
                //Console.WriteLine(demo[i]);

                foreach (string j in demo)
                {
                    Console.Write(j + "\t");
                }
                //Console.WriteLine(data[i].name);
                //Console.WriteLine(data[i].address);
                //Console.WriteLine(data[i].hindiMarks);
                //Console.WriteLine(data[i].englishMarks);
                //Console.WriteLine(data[i].mathsMarks);
                //Console.WriteLine(data[i].totalMarks);
                //Console.WriteLine(data[i].grade);

            }*/
        }

        public static void input(int totalNumofData, List<string> Mobike)
        {
            for (int i = 0; i < totalNumofData; i++)
            {
                Console.WriteLine("\nEnter Customer " + (i + 1) + " Data \n");
                Console.Write("Enter Bike Number : "); 
                int a = Convert.ToInt32(Console.ReadLine());
                Mobike.Add(Convert.ToString(a));
                Console.Write("Enter Phone Number : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Mobike.Add(Convert.ToString(b));
                Console.Write("Enter Name : ");
                string c = Console.ReadLine();
                Mobike.Add(c);
                Console.Write("Enter Day : ");
                int d = Convert.ToInt32(Console.ReadLine());
                Mobike.Add(Convert.ToString(d));
                int charge = compute(d);
                Mobike.Add(Convert.ToString(charge));
            }
        }
        public static void display(int totalNumofData, List<string> Mobike)
        {
            Console.WriteLine("\n\nBike No.\tPhoneNo\t\tNames\t\tNo. of days\tCharge");
            int m = 0;
            int n = 5;
            for (int k = 0; k < totalNumofData; k++)
            {

                for (int j = m; j < n; j++)
                {
                    Console.Write(Mobike[j] + "\t\t");
                }
                Console.WriteLine("\n");
                m += 5;
                n += 5;
            }
        }
        public static int compute(int day)
        {

            if (day <= 5)
            {
                return day * 500;
            }
            else if (day > 5 && day <= 10)
            {
                return day * 400;
            }
            else
            {
                return day * 200;
            }
        }
    }
}



    



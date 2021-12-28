using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assingment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accept 10 student Name,Address,Hindi,English,Maths Marks ,do the total and compute Grade. Note do it with Array and display the result in grid format
           
            Console.Write("Enter total number of data you want to insert : ");
            int totalNumofData = Convert.ToInt32(Console.ReadLine());
            student[] data = new student[totalNumofData];
            for (int i = 0; i < totalNumofData; i++)
            {
                //student[] data = new student[i];
                Console.WriteLine("\nEnter Student " + (i+1) + " Data ");
                
                data[i] = new student();
                Console.Write("Enter Name : ");
                data[i].name = Console.ReadLine();
                Console.Write("Enter Address : ");
                data[i].address = Console.ReadLine();
                Console.Write("Enter Marks of Hindi Subject : ");
                data[i].hindiMarks = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Marks of English Subject : ");
                data[i].englishMarks = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Marks of Maths Subject : ");
                data[i].mathsMarks = Convert.ToInt32(Console.ReadLine());

                data[i].totalMarks = data[i].hindiMarks + data[i].englishMarks + data[i].mathsMarks;

                if (data[i].totalMarks >= 225 && data[i].totalMarks <=300)
                {
                    data[i].grade = "A";
                    //Console.WriteLine(data[i].grade);
                }
                else if (data[i].totalMarks >= 150 && data[i].totalMarks < 225)
                {
                    data[i].grade = "B";
                    //Console.WriteLine(data[i].grade);
                }
                else if (data[i].totalMarks >= 95 && data[i].totalMarks < 150)
                {
                    data[i].grade = "C";
                    //Console.WriteLine(data[i].grade);
                }
                else
                {
             
                    data[i].grade = "E";
                    //Console.WriteLine(data[i].grade);
                }


                string[] demo = { data[i].name, data[i].address, Convert.ToString(data[i].hindiMarks), Convert.ToString(data[i].englishMarks), Convert.ToString(data[i].mathsMarks), Convert.ToString(data[i].totalMarks), data[i].grade};
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

            }
            Console.ReadLine();
        }
    }
    class student
    {
        public string name;
        public string address;
        public int hindiMarks;
        public int englishMarks;
        public int mathsMarks;
        public int totalMarks;
        public string grade;
    }

    
}

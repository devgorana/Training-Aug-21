using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice_LINQ_OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
			// Student collection
			IList<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
				new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
				new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
			};

			var orderByResult = from s in studentList
								orderby s.StudentName //Sorts the studentList collection in ascending order
								select s;

			//with use of method syntax
			var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

			//use thenBy method
			var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

			var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
										  orderby s.StudentName descending
										  select s;

			//with use of method syntax
			var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);

			//use thenBy method
			var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

			Console.WriteLine("Ascending Order:");

			foreach (var std in orderByResult)
				Console.WriteLine(std.StudentName);

            Console.WriteLine("\n");

			foreach (var std in studentsInAscOrder)
				Console.WriteLine(std.StudentName);

			Console.WriteLine("\n");

			Console.WriteLine("ThenBy:");

			foreach (var std in thenByResult)
				Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

			Console.WriteLine("\n");

			Console.WriteLine("Descending Order:");

			foreach (var std in orderByDescendingResult)
				Console.WriteLine(std.StudentName);

			Console.WriteLine("\n");

			foreach (var std in studentsInDescOrder)
				Console.WriteLine(std.StudentName);

			Console.WriteLine("\n");

			Console.WriteLine("ThenByDescending:");

			foreach (var std in thenByDescResult)
				Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

			Console.ReadLine();
		}
	}

	public class Student
	{
		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }

	}
}

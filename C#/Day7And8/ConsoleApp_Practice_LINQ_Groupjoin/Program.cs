using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice_LINQ_Groupjoin
{
    class Program
    {
        static void Main(string[] args)
        {
			// Student collection
			IList<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
				new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
			};

			IList<Standard> standardList = new List<Standard>() {
				new Standard(){ StandardID = 1, StandardName="Standard 1"},
				new Standard(){ StandardID = 2, StandardName="Standard 2"},
				new Standard(){ StandardID = 3, StandardName="Standard 3"}
			};

			/*var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
									std => std.StandardID, //outerKeySelector 
									s => s.StandardID,     //innerKeySelector
									(std, studentsGroup) => new // resultSelector 
								{
										Students = studentsGroup,
										StandardName = std.StandardName
									});

			*/

			//using query syntax
			var groupJoin = from std in standardList
							join s in studentList
							on std.StandardID equals s.StandardID
							into studentGroup
							select new
							{
								Students = studentGroup,
								StandardName = std.StandardName
							};

			foreach (var item in groupJoin)
			{
				Console.WriteLine(item.StandardName);

				foreach (var stud in item.Students)
					Console.WriteLine(stud.StudentName);
			}

            Console.WriteLine("\n\n");

			//use all operators
			bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);

			Console.WriteLine(areAllStudentsTeenAger);

            Console.WriteLine("\n");
			//use Any operators
			bool isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);
			Console.WriteLine(isAnyStudentTeenAger);

            Console.WriteLine("\n");
			//use Contains operators
			Student std1 = new Student() { StudentID = 3, StudentName = "Bill" };
			bool result = studentList.Contains(std1); //returns false
			Console.WriteLine(result);

            Console.WriteLine("\n");
			//use Aggregate operators
			string commaSeparatedStudentNames = studentList.Aggregate<Student, string, string>(
											String.Empty, // seed value
											(str, s) => str += s.StudentName + ",", // returns result using seed value, String.Empty goes to lambda expression as str
											str => str.Substring(0, str.Length - 1)); // result selector that removes last comma

			Console.WriteLine(commaSeparatedStudentNames);

            Console.WriteLine("\n");
			//use Aggregate operators average
			IList<int> intList = new List<int>() { 10, 20, 35 };

			var avg = intList.Average();

			Console.WriteLine("Average: {0}", avg);

            Console.WriteLine("\n");
			//use Count
			var totalElements = intList.Count();

			Console.WriteLine("Total Elements: {0}", totalElements);

			var evenElements = intList.Count(i => i % 2 == 0);

			Console.WriteLine("Even Elements: {0}", evenElements);

            Console.WriteLine("\n");
			//use max
			var largest = intList.Max();

			Console.WriteLine("Largest Element: {0}", largest);

			var largestEvenElements = intList.Max(i => {
				if (i % 2 == 0)
					return i;

				return 0;
			});

			Console.WriteLine("Largest Even Element: {0}", largestEvenElements);

			Console.WriteLine("\n");
			//use min
			var minimum = intList.Min();

			Console.WriteLine("Minimum Element: {0}", minimum);

			var MinimumEvenElements = intList.Min(i => {
				if (i % 2 == 0)
					return i;

				return 0;
			});

			Console.WriteLine("Minimum Even Element: {0}", MinimumEvenElements);

            Console.WriteLine("\n");
			//use sum()
			var total = intList.Sum();

			Console.WriteLine("Sum: {0}", total);

			var sumOfEvenElements = intList.Sum(i => {
				if (i % 2 == 0)
					return i;

				return 0;
			});

			Console.WriteLine("Sum of Even Elements: {0}", sumOfEvenElements);

            Console.WriteLine("\n");
			//use DefaultIfEmpty()
			IList<string> emptyList = new List<string>();

			var newList1 = emptyList.DefaultIfEmpty();
			var newList2 = emptyList.DefaultIfEmpty("None");

			Console.WriteLine("Count: {0}", newList1.Count());
			Console.WriteLine("Value: {0}", newList1.ElementAt(0));

			Console.WriteLine("Count: {0}", newList2.Count());
			Console.WriteLine("Value: {0}", newList2.ElementAt(0));


            Console.WriteLine("\n");
			//use Intersect
			IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
			IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

			var result1 = strList1.Intersect(strList2);

			foreach (string str in result1)
				Console.WriteLine(str);

            Console.WriteLine("\n");
			//use Union
			var result3 = strList1.Union(strList2);

			foreach (string str in result3)
				Console.WriteLine(str);

            Console.WriteLine("\n");
			//use Take()
			IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

			var newList = strList.Take(4);

			foreach (var str in newList)
				Console.WriteLine(str);

			Console.WriteLine("\n");
			//use TakeWhile()
			//var resultList = strList.TakeWhile(s => s.Length > 5);
			var resultList = strList.TakeWhile((s, i) => s.Length > i);

			foreach (string str in resultList)
				Console.WriteLine(str);

            Console.WriteLine("\n");
			//use let keyword
			var lowercaseStudentNames = from s in studentList
										let lowercaseStudentName = s.StudentName.ToLower()
										where lowercaseStudentName.StartsWith("r")
										select lowercaseStudentName;

			foreach (var name in lowercaseStudentNames)
				Console.WriteLine(name);

            Console.WriteLine("\n");
			//use into keyword
			var teenAgerStudents = from s in studentList
								   where s.Age > 12 && s.Age < 20
								   select s
								into teenStudents
								   where teenStudents.StudentName.StartsWith("B")
								   select teenStudents;


			foreach (Student std in teenAgerStudents)
			{
				Console.WriteLine(std.StudentName);
			}

				Console.ReadLine();
		}
	}

	public class Student
	{

		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }
		public int StandardID { get; set; }
	}

	public class Standard
	{

		public int StandardID { get; set; }
		public string StandardName { get; set; }
	}
}

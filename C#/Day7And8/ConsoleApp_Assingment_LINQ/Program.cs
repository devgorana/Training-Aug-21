using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assingment_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() {
                new Employee() { ID = 1, FirstName = "John", LastName = "Abraham",Salary=100000,JoiningDate=new DateTime(2013,1,1),Deparment="Banking" },
                new Employee() { ID = 2, FirstName = "Michael", LastName = "Clarke",Salary=800000,JoiningDate=new DateTime(),Deparment="Insurance" },
                new Employee() { ID = 3, FirstName = "oy", LastName = "Thomas",Salary=700000,JoiningDate=new DateTime() ,Deparment="Insurance" },
                new Employee() { ID = 4, FirstName = "Tom", LastName = "Jose",Salary=600000,JoiningDate=new DateTime() ,Deparment="Banking" },
            };

            List<Incentive> incentives = new List<Incentive>() {
                new Incentive(){ ID=1, IncentiveAmount=5000, IncentiveDate=new DateTime(2013,02,02) },
                new Incentive(){ ID=2, IncentiveAmount=10000, IncentiveDate=new DateTime(2013,02,4) },
                new Incentive(){ ID=1, IncentiveAmount=6000, IncentiveDate=new DateTime(2012,01,5) },
                new Incentive(){ ID=2, IncentiveAmount=3000, IncentiveDate=new DateTime(2012,01,5) }
            };

            //1. Get employee details from employees object whose employee name is “John” (note restrict operator)
            /*var query1 = from s in employees
                                  where s.FirstName == "John"
                                  select s;*/

            var query1 = employees.Where(x => x.FirstName == "John");

            foreach (Employee emp in query1)
            {
                Console.WriteLine("ID : " + emp.ID);
                Console.WriteLine("FirstName : " + emp.FirstName);
                Console.WriteLine("LastName : " + emp.LastName);
                Console.WriteLine("Salary : " + emp.Salary);
                Console.WriteLine("Joining Date : " + emp.JoiningDate);
                Console.WriteLine("Department : " + emp.Deparment);
            }

            Console.WriteLine("\n");
            //2. Get FIRSTNAME,LASTNAM from employees object(note project operator)

            var query2 = from s in employees
                         select s.FirstName +" "+ s.LastName;

            foreach (var i in query2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
            //3. Select FirstName, IncentiveAmount from employees and incentives object for those employees who have incentives.(join operator)

            var query3 = employees.Join(
                      incentives, 
                      emp => emp.ID,
                      inc => inc.ID,
                      (emp, inc) => new 
                      {
                          FirstName = emp.FirstName,
                          IncentiveAmount = inc.IncentiveAmount
                      });

            foreach (var q in query3)
            {
                Console.WriteLine("{0} {1}", q.FirstName, q.IncentiveAmount);
            }

            Console.WriteLine("\n");
            //4. Get department wise maximum salary from employee table order by salary ascending (note group by)
            
            var query4 = from s in employees
                         orderby s.Salary
                         group s by s.Deparment;

            foreach (var q in query4)
            {
                Console.WriteLine("\nDepartment Name : {0}", q.Key); //Each group has a key 

                foreach (var s in q) // Each group has inner collection
                    Console.WriteLine("{0} {1}", s.FirstName, s.Salary);
            }

            Console.WriteLine("\n");
            //5. Select department, total salary with respect to a department from employees object where total salary greater than 800000 order by TotalSalary descending(group by having)

            var query5 = from s in employees
                         orderby s.Salary
                         group s by s.Deparment
                         ;
            

            foreach (var q in query5)
            {
                Console.WriteLine("\nDepartment Name : {0}", q.Key); //Each group has a key 
                
                foreach (var s in q) // Each group has inner collection
                Console.WriteLine("{0}", s.Salary);
            }

            Console.ReadLine();
        }
    }

    class Employee

    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Deparment { get; set; }
    }

    class Incentive

    {
        public int ID { get; set; }
        public double IncentiveAmount { get; set; }
        public DateTime IncentiveDate { get; set; }
    }
}

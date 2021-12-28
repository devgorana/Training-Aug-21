using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day3_Assignment
{
    // Interface
    interface Iemp
    {
        void getdata();
        void displaydata();
        void salary();
    }

    //abstract class
    abstract class employee : Iemp
    {
        int id, pannumber;
        string name, address;

        public virtual void getdata()
        {
            Console.Write("Enter ID : ");

            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Address : ");
            address = Console.ReadLine();
            Console.Write("Enter Pan Card Number : ");
            pannumber = Convert.ToInt32(Console.ReadLine());

        }

        public virtual void displaydata()
        { 
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Adress : " + address);
            Console.WriteLine("Pan Card Number : " + pannumber);
        }

        //abstract method
        public abstract void salary();
    }

    class parttime : employee
    {
        int noofhour, saleperhour, Salary;
        
        public override void getdata()
        {
            base.getdata();
            Console.Write("Enter Number of Hours : ");
            noofhour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Salary Per Hour : ");
            saleperhour = Convert.ToInt32(Console.ReadLine());
        }
       
        public override void salary()
        {
            Salary = noofhour * saleperhour;
        }

        public override void displaydata()
        {
            base.displaydata();
            Console.WriteLine("Salary : " + Salary);
        }
    }

    class fulltime : employee
    {
        int basic, hra, ta, da, Salary;
        public override void getdata()
        {
            base.getdata();
            Console.Write("Enter Basic : ");
            basic = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter HRA : ");
            hra = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter TA : ");
            ta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter DA  : ");
            da = Convert.ToInt32(Console.ReadLine());

        }
        
        public override void salary()
        {
            Salary = basic + hra + ta + da;
        }

        public override void displaydata()
        {
            base.displaydata();
            Console.WriteLine("Salary : " + Salary);
        }
    }
    
    class Program
    {
        public void FuncionInvoke(Iemp employee)
        {
                
                employee.getdata();
                employee.salary();
                employee.displaydata();
        }
        static void Main(string[] args)
        {
            Iemp employee = null;

            Console.Write("Enter 1 for Parttime Employee Enter 2 for Fulltime Employee : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:employee = new parttime();
                    break;
                case 2:employee = new fulltime();
                    break;
                default:Console.WriteLine("Invalid choice");
                    break;
            }
            var program = new Program();
            program.FuncionInvoke(employee);

            Console.ReadLine();           
        }
    }
}



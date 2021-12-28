using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp_Bank_Management.Model;
using Microsoft.Data.SqlClient;

namespace ConsoleApp_Bank_Management
{
    class Program
    {
        

        static void Main(string[] args)
        {
            static void OpenAccount()
            {
                Console.Write("\nEnter Name : ");
                string User_Name = Console.ReadLine();
                Console.Write("Enter Age : ");
                int User_Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Gender : ");
                char User_Gender = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter Phone Number : ");
                string User_PhoneNumber = Console.ReadLine();
                Console.Write("Enter City : ");
                string User_City = Console.ReadLine();
                Console.Write("Enter Branch Name : ");
                string User_BranchName = Console.ReadLine();
                Console.Write("Enter Account Type : ");
                string User_AccountType = Console.ReadLine();
                Console.Write("Enter Account Opening Amount : ");
                int User_Balance = Convert.ToInt32(Console.ReadLine());

                using (var context = new BankContext())
                {

                    var std = new Users()
                    {
                        UserName = User_Name,
                        Age = User_Age,
                        Gender = User_Gender,
                        PhoneNumber = User_PhoneNumber,
                        City = User_City,
                        BranchName = User_BranchName,
                        AccountType = User_AccountType,
                        Balance = User_Balance
                    };

                    context.Users.Add(std);
                    context.SaveChanges();
                }

                using (var context = new BankContext())
                {
                    var UserData = context.Users.Where(s => s.UserName == User_Name).ToList();
                    foreach (var p in UserData)
                    {
                        Console.WriteLine("\nYour Account is Successfully Open.\nYour Account Number is {0}.",p.UserId);
                        var std = new Transactions()
                        {
                            //UserId = context.Users.FromSql("SELECT COUNT(UserId) FROM Users"),
                            UserId = p.UserId,
                            TransactionType = "Deposit",
                            TransactionAmt = User_Balance,
                            TransactionDateTime = DateTime.Now
                        };

                        context.Transaction.Add(std);
                        context.SaveChanges();
                    }
                }
            }

            static void DepositMoney()
            {
                Console.Write("Enter Account Number : ");
                int User_Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Amount : ");
                int Tran_Amt = Convert.ToInt32(Console.ReadLine());

                using (var context = new BankContext())
                {
                    var UserData = context.Users.Where(s => s.UserId == User_Id).ToList();
                    foreach (var p in UserData)
                    {
                        //Update User Balance
                        Users dep;
                        dep = context.Users.Where(d => d.UserId == User_Id).First();
                        dep.Balance = p.Balance + Tran_Amt;
                        context.SaveChanges();
                        Console.WriteLine("\nYour Transaction is Successfully Complete.\nClosing Balance : {0}", dep.Balance);
                    }
                }

                using (var context = new BankContext())
                {
                    var std = new Transactions()
                    {
                        UserId = User_Id,
                        TransactionType = "Deposit",
                        TransactionAmt = Tran_Amt,
                        TransactionDateTime = DateTime.Now
                    };

                    context.Transaction.Add(std);
                    context.SaveChanges();
                }

                /*using (var context = new BankContext())
                {
                    
                    //var UserData = context.Transaction.Where( s => s.UserId == User_Id ).ToList();
                    var UserData = (from c in context.Transaction orderby c.TransactionId descending where c.UserId == User_Id select c ).FirstOrDefault();

                    foreach (var p in UserData)
                    {
                        Console .WriteLine("Transaction Number : {0}", p.TransactionId);
                    }

                }*/
            }

            static void WithdrawMoney()
            {
                Console.Write("Enter Account Number : ");
                int User_Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Amount : ");
                int Tran_Amt = Convert.ToInt32(Console.ReadLine());

                using (var context = new BankContext())
                {
                    var UserData = context.Users.Where(s => s.UserId == User_Id).ToList();
                    foreach (var p in UserData)
                    {
                        //Update User Balance
                        Users dep;
                        dep = context.Users.Where(d => d.UserId == User_Id).First();
                        dep.Balance = p.Balance - Tran_Amt;
                        context.SaveChanges();
                        Console.WriteLine("\nYour Transaction is Successfully Complete.\nClosing Balance : {0}", dep.Balance);
                    }
                }

                using (var context = new BankContext())
                {
                    var std = new Transactions()
                    {
                        UserId = User_Id,
                        TransactionType = "Withdraw",
                        TransactionAmt = Tran_Amt,
                        TransactionDateTime = DateTime.Now
                    };

                    context.Transaction.Add(std);
                    context.SaveChanges();
                }
            }

            static void ViewAccountDetails()
            {
                Console.WriteLine("\nEnter Account Number : ");
                int User_Id = Convert.ToInt32(Console.ReadLine());
                using (var context = new BankContext())
                {
                    var UserData = context.Users.Where(s => s.UserId == User_Id).ToList();
                    foreach (var p in UserData)
                    {
                        Console.WriteLine("\nName : {0} \nAge : {1} \nGender : {2} \nPhoneNumber : {3} \nCity : {4} \nBranchName : {5} \nAccount Type : {6} \nTotal Balance : {7} \n", p.UserName, p.Age, p.Gender, p.PhoneNumber, p.City, p.BranchName, p.AccountType, p.Balance);
                    }
                    Console.WriteLine("Transaction Id \t Transaction Type \t Amount \t Transaction DateTime");
                    var TransactionData = context.Transaction.Where(s => s.UserId == User_Id).ToList();
                    foreach (var q in TransactionData)
                    {
                        Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t {3} ", q.TransactionId, q.TransactionType, q.TransactionAmt, q.TransactionDateTime);
                    }
                }
            }


            Console.WriteLine("---------- Detroit United Bank ----------");
            char opt ='Y';
            while (opt != 'N')
            {
                
                Console.WriteLine("\n1.Open a Bank Account");
                Console.WriteLine("2.Perform transactions for an account");
                Console.WriteLine("3.View Account Details");
                Console.WriteLine("4.Exit the application");

                Console.Write("\nEnter Choice : ");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        OpenAccount();
                        break;
                    case 2:
                        Console.WriteLine("\n---------- Transaction ----------");
                        char op = 'Y';
                        while (op != 'N')
                        {
                            Console.WriteLine("\n1.Deposit Money");
                            Console.WriteLine("2.Withdraw Money");
                            Console.WriteLine("3.Back To Main Menu");

                            Console.Write("\nEnter Choice : ");
                            int Ch = Convert.ToInt32(Console.ReadLine());
                            switch (Ch)
                            {
                                case 1:
                                    DepositMoney();
                                    break;
                                case 2:
                                    WithdrawMoney();
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.WriteLine("Please Enter Valid Choice.");
                                    break;
                            }
                            Console.Write("\nYou Want to Continue Transaction Y/N : ");
                            op = Convert.ToChar(Console.ReadLine());
                        }
                        
                        break;
                    case 3:
                        ViewAccountDetails();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice.");
                        break;
                }
                Console.Write("\nYou Want to Continue Y/N : ");
                opt = Convert.ToChar(Console.ReadLine());
            }
            


            Console.ReadLine();
        }
    }
}

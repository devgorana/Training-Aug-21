using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp_Bank_Management.Model
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string BranchName { get; set; }
        public string AccountType { get; set; }
        public int Balance { get; set; }
    }
}

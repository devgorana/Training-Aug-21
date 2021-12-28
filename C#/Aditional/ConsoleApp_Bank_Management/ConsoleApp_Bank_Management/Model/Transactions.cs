using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp_Bank_Management.Model
{
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; }
        public string TransactionType { get; set; }
        public int TransactionAmt { get; set; }
        public DateTime TransactionDateTime { get; set; }
        
        [Display(Name = "Users")]
        public virtual int UserId { get; set; }
        
        [ForeignKey("UserId")]
        public virtual Users Users { get; set; }

    }
}

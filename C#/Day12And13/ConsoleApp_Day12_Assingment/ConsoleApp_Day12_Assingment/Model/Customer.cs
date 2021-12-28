using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp_Day12_Assingment.Model
{
    class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(25)]
        public string CustomerName { get; set; }

        public byte Age { get; set; }

        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}

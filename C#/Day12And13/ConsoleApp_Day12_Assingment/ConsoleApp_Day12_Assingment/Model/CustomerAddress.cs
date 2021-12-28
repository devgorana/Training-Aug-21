﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp_Day12_Assingment.Model
{
    class CustomerAddress
    {
        public int CustomerAddressId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [MaxLength(6)]
        public string Pincode { get; set; }

        [Required]
        [MaxLength(25)]
        public string State { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}

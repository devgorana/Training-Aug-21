using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp_Day12_Assingment.Model
{
    class Toys
    {
        public int ToysId { get; set; }

        [Required]
        [MaxLength(25)]
        public string ToyName { get; set; }

        public int UnitPrice { get; set; }

        public int ToyQuantity { get; set; }

        public bool AvailabilityStatus { get; set; }

        public int PlantId { get; set; }
        public Plant Plant { get; set; }

        public ICollection<OrderItems> OrderItems { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Model
{
    public class Resident_Sale
    {
        [Key]
        public int Resident_Sale_Id { get; set; }
        public string Apartment_Type { get; set; }
        public string BHK_Type { get; set; }
        public string Ownership_Type { get; set; }
        public long Built_Up_Area { get; set; }
        public long Carpet_Area { get; set; }
        public string Property_Age { get; set; }
        public string Facing { get; set; }
        public string Floor_Type { get; set; }
        public int Floor { get; set; }
        public int Total_Floor { get; set; } 
        public string City { get; set; }
        public string Locality { get; set; }
        public string Landmark { get; set; }
        public long Expected_Price { get; set; }
        public long Maintenance_Cost { get; set; }
        public DateTime Available_From { get; set; }
        public string Kitchen_Type { get; set; }
        public string Furnishing { get; set; }
        public string Parking { get; set; }
        public string Description { get; set; }
        public int Number_Of_Bathrooms { get; set; }
        public int Number_Of_Balcony { get; set; }
        public string Type_Of_Water_Supply { get; set; }
        public Boolean Gym { get; set; }
        public string Power_Backup { get; set; }
        public Boolean Gated_Security { get; set; }
        public string Who_Will_Show_The_House { get; set; }
        public long Secondary_Number { get; set; }

        //Select the available amenities

        //Select the images
        public Post_Ad Post_Ad { get; set; }
        
    }
}

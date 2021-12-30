using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Model
{
    public class Flatmates_Rent
    {
        [Key]
        public int Flatmates_Rent_Id { get; set; }
        public string Apartment_Type { get; set; }
        public string BHK_Type { get; set; }
        public int Floor { get; set; }
        public int Total_Floor { get; set; }
        public string Room_Type { get; set; }
        public string Tenant_Type { get; set; }
        public string Property_Age { get; set; }
        public string Facing { get; set; }
        public long Built_Up_Area { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }
        public string Landmark { get; set; }
        public string Available_For { get; set; }
        public long Expected_Rent { get; set; }
        public long Expected_Deposit { get; set; }
        public string Rent_Negotiable { get; set; }
        public string Monthly_Maintenance { get; set; }
        public DateTime Available_From { get; set; }
        
        public string Furnishing { get; set; }
        public string Parking { get; set; }
        public string Description { get; set; }
        public int Number_Of_Bathrooms { get; set; }
        public int Number_Of_Balcony { get; set; }
        public string Type_Of_Water_Supply { get; set; }
        public Boolean Gym { get; set; }
        public Boolean Non_Veg_Allowed { get; set; }
        public Boolean Gated_Security { get; set; }
        public string Who_Will_Show_The_House { get; set; }
        public long Secondary_Number { get; set; }

        //Select the available amenities

        //Select the images

        public Post_Ad Post_Ad { get; set; }

    }
}

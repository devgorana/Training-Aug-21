using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Model
{
    public class Commercial_Sale
    {
        [Key]
        public int Commercial_Sale_Id { get; set; }
        public string Property_Type { get; set; }
        public string Building_Type { get; set; }
        public string Age_Of_Property { get; set; }
        public int Floor { get; set; }
        public int Total_Floor { get; set; }
        public long Super_Built_Up_Area { get; set; }
        public string Furnishing { get; set; }
        public string Other_Features { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }
        public string Landmark { get; set; }
        public long Expected_Price { get; set; }
        public Boolean Price_Negotiable { get; set; }
        public string Ownership_Type { get; set; }
        public DateTime Available_From { get; set; }

        public string Ideal_For { get; set; }
        public string Power_Backup { get; set; }
        public string Lift { get; set; }
        public string Parking { get; set; }
        public string Washroom { get; set; }
        public Boolean Water_Storage_Facility { get; set; }
        public Boolean Security { get; set; }
        public Boolean Wifi { get; set; }

        //Select the images

        public Post_Ad Post_Ad { get; set; }

    }
}

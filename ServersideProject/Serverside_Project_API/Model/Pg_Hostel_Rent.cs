using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Model
{
    public class Pg_Hostel_Rent
    {
        [Key]
        public int Pg_Hostel_Rent_Id { get; set; }
        public string Type_Of_Rooms { get; set; }
        public long Rent_Per_Person { get; set; }
        public long Deposit_Per_Person { get; set; }
        
        //Select the Room available amenities


        public string City { get; set; }
        public string Locality { get; set; }
        public string Landmark { get; set; }
        public string Place_Available_For { get; set; }
        public string Preferred_Guests { get; set; }
        public DateTime Available_From { get; set; }
        public Boolean Food_Included { get; set; }
        
        //pg/hostel Rules 

        public DateTime Gate_Clossing_Time { get; set; }
        public string Description { get; set; }
        public Boolean Laundry_Service_Available { get; set; }
        public Boolean Room_Cleaning_Service_Available { get; set; }
        public Boolean Warden_Facility_Service_Available { get; set; }

        //Available Amenities

        public string Parking { get; set; }

        //Select the images

        public Post_Ad Post_Ad { get; set; }

    }
}

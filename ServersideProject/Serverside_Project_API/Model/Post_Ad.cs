using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Model
{
    public class Post_Ad
    {
        [Key]
        public int Post_Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Mobile_No { get; set; }
        public string City { get; set; }
        public string Property_Type { get; set; }
        public string Property_Ad_Type { get; set; }
    }
}

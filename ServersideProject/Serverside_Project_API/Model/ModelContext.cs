using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Model
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {
        }
        public DbSet<Commercial_Rent> Commercial_Rents { get; set; }
        public DbSet<Commercial_Sale> Commercial_Sales { get; set; }
        public DbSet<Flatmates_Rent> Flatmates_Rents { get; set; }
        public DbSet<Pg_Hostel_Rent> Pg_Hostel_Rents { get; set; }
        public DbSet<Resident_Rent> Resident_Rents { get; set; }
        public DbSet<Resident_Sale> Resident_Sales { get; set; }
        public DbSet<Post_Ad>  Post_Ads { get; set; }
        

    }
}

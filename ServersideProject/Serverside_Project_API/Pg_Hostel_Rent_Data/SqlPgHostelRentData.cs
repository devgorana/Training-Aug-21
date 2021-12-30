using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Pg_Hostel_Rent_Data
{
    public class SqlPgHostelRentData : IPgHostelRentData
    {
        private ModelContext _modelContext;
        public SqlPgHostelRentData(ModelContext modelContext)
        {
            _modelContext = modelContext;
        }
        public Pg_Hostel_Rent AddPgHostelRent(Pg_Hostel_Rent pgHostelRent)
        {
            _modelContext.Pg_Hostel_Rents.Add(pgHostelRent);
            _modelContext.SaveChanges();
            return pgHostelRent;
        }

        public void DeletePgHostelRent(Pg_Hostel_Rent pgHostelRent)
        {
            _modelContext.Pg_Hostel_Rents.Remove(pgHostelRent);
            _modelContext.SaveChanges();
        }

        public Pg_Hostel_Rent EditPgHostelRent(Pg_Hostel_Rent pgHostelRent)
        {
            var existingPgHostelRentData = _modelContext.Pg_Hostel_Rents.Find(pgHostelRent.Pg_Hostel_Rent_Id);
            if (existingPgHostelRentData != null)
            {
                
                existingPgHostelRentData.Type_Of_Rooms = pgHostelRent.Type_Of_Rooms;
                existingPgHostelRentData.Rent_Per_Person = pgHostelRent.Rent_Per_Person;
                existingPgHostelRentData.Deposit_Per_Person = pgHostelRent.Deposit_Per_Person;
                existingPgHostelRentData.City = pgHostelRent.City;
                existingPgHostelRentData.Locality = pgHostelRent.Locality;
                existingPgHostelRentData.Landmark = pgHostelRent.Landmark;
                existingPgHostelRentData.Place_Available_For = pgHostelRent.Place_Available_For;
                existingPgHostelRentData.Preferred_Guests = pgHostelRent.Preferred_Guests;
                existingPgHostelRentData.Available_From = pgHostelRent.Available_From;
                existingPgHostelRentData.Food_Included = pgHostelRent.Food_Included;
                existingPgHostelRentData.Gate_Clossing_Time = pgHostelRent.Gate_Clossing_Time;
                existingPgHostelRentData.Description = pgHostelRent.Description;
                existingPgHostelRentData.Laundry_Service_Available = pgHostelRent.Laundry_Service_Available;
                existingPgHostelRentData.Room_Cleaning_Service_Available = pgHostelRent.Room_Cleaning_Service_Available;
                existingPgHostelRentData.Warden_Facility_Service_Available = pgHostelRent.Warden_Facility_Service_Available;
                existingPgHostelRentData.Parking = pgHostelRent.Parking;
                existingPgHostelRentData.Post_Ad = pgHostelRent.Post_Ad;

                _modelContext.Pg_Hostel_Rents.Update(existingPgHostelRentData);
                _modelContext.SaveChanges();
            }
            return pgHostelRent;
            //throw new NotImplementedException();
        }

        public Pg_Hostel_Rent GetPgHostelRent(int id)
        {
            var data = _modelContext.Pg_Hostel_Rents.Find(id);
            return data;
        }

        public List<Pg_Hostel_Rent> GetPgHostelRents()
        {
            return _modelContext.Pg_Hostel_Rents.ToList();
        }
    }
}

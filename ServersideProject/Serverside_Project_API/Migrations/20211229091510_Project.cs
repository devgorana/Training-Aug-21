using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Serverside_Project_API.Migrations
{
    public partial class Project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Post_Ads",
                columns: table => new
                {
                    Post_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile_No = table.Column<long>(type: "bigint", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property_Ad_Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_Ads", x => x.Post_Id);
                });

            migrationBuilder.CreateTable(
                name: "Commercial_Rents",
                columns: table => new
                {
                    Commercial_Rent_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Property_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Building_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age_Of_Property = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Total_Floor = table.Column<int>(type: "int", nullable: false),
                    Super_Built_Up_Area = table.Column<long>(type: "bigint", nullable: false),
                    Furnishing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other_Features = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expected_Rent = table.Column<long>(type: "bigint", nullable: false),
                    Rent_Negotiable = table.Column<bool>(type: "bit", nullable: false),
                    Deposit = table.Column<long>(type: "bigint", nullable: false),
                    Lease_Duration_Years = table.Column<int>(type: "int", nullable: false),
                    Lockin_Period_Years = table.Column<int>(type: "int", nullable: false),
                    Available_From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ideal_For = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Power_Backup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Washroom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Water_Storage_Facility = table.Column<bool>(type: "bit", nullable: false),
                    Security = table.Column<bool>(type: "bit", nullable: false),
                    Wifi = table.Column<bool>(type: "bit", nullable: false),
                    Post_AdPost_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commercial_Rents", x => x.Commercial_Rent_Id);
                    table.ForeignKey(
                        name: "FK_Commercial_Rents_Post_Ads_Post_AdPost_Id",
                        column: x => x.Post_AdPost_Id,
                        principalTable: "Post_Ads",
                        principalColumn: "Post_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Commercial_Sales",
                columns: table => new
                {
                    Commercial_Sale_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Property_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Building_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age_Of_Property = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Total_Floor = table.Column<int>(type: "int", nullable: false),
                    Super_Built_Up_Area = table.Column<long>(type: "bigint", nullable: false),
                    Furnishing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other_Features = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expected_Price = table.Column<long>(type: "bigint", nullable: false),
                    Price_Negotiable = table.Column<bool>(type: "bit", nullable: false),
                    Ownership_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Available_From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ideal_For = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Power_Backup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Washroom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Water_Storage_Facility = table.Column<bool>(type: "bit", nullable: false),
                    Security = table.Column<bool>(type: "bit", nullable: false),
                    Wifi = table.Column<bool>(type: "bit", nullable: false),
                    Post_AdPost_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commercial_Sales", x => x.Commercial_Sale_Id);
                    table.ForeignKey(
                        name: "FK_Commercial_Sales_Post_Ads_Post_AdPost_Id",
                        column: x => x.Post_AdPost_Id,
                        principalTable: "Post_Ads",
                        principalColumn: "Post_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Flatmates_Rents",
                columns: table => new
                {
                    Flatmates_Rent_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apartment_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BHK_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Total_Floor = table.Column<int>(type: "int", nullable: false),
                    Room_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tenant_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property_Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Built_Up_Area = table.Column<long>(type: "bigint", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Available_For = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expected_Rent = table.Column<long>(type: "bigint", nullable: false),
                    Expected_Deposit = table.Column<long>(type: "bigint", nullable: false),
                    Rent_Negotiable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Monthly_Maintenance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Available_From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Furnishing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number_Of_Bathrooms = table.Column<int>(type: "int", nullable: false),
                    Number_Of_Balcony = table.Column<int>(type: "int", nullable: false),
                    Type_Of_Water_Supply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gym = table.Column<bool>(type: "bit", nullable: false),
                    Non_Veg_Allowed = table.Column<bool>(type: "bit", nullable: false),
                    Gated_Security = table.Column<bool>(type: "bit", nullable: false),
                    Who_Will_Show_The_House = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secondary_Number = table.Column<long>(type: "bigint", nullable: false),
                    Post_AdPost_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flatmates_Rents", x => x.Flatmates_Rent_Id);
                    table.ForeignKey(
                        name: "FK_Flatmates_Rents_Post_Ads_Post_AdPost_Id",
                        column: x => x.Post_AdPost_Id,
                        principalTable: "Post_Ads",
                        principalColumn: "Post_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pg_Hostel_Rents",
                columns: table => new
                {
                    Pg_Hostel_Rent_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_Of_Rooms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rent_Per_Person = table.Column<long>(type: "bigint", nullable: false),
                    Deposit_Per_Person = table.Column<long>(type: "bigint", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place_Available_For = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preferred_Guests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Available_From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Food_Included = table.Column<bool>(type: "bit", nullable: false),
                    Gate_Clossing_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Laundry_Service_Available = table.Column<bool>(type: "bit", nullable: false),
                    Room_Cleaning_Service_Available = table.Column<bool>(type: "bit", nullable: false),
                    Warden_Facility_Service_Available = table.Column<bool>(type: "bit", nullable: false),
                    Parking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post_AdPost_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pg_Hostel_Rents", x => x.Pg_Hostel_Rent_Id);
                    table.ForeignKey(
                        name: "FK_Pg_Hostel_Rents_Post_Ads_Post_AdPost_Id",
                        column: x => x.Post_AdPost_Id,
                        principalTable: "Post_Ads",
                        principalColumn: "Post_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resident_Rents",
                columns: table => new
                {
                    Resident_Rent_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apartment_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BHK_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Total_Floor = table.Column<int>(type: "int", nullable: false),
                    Property_Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Built_Up_Area = table.Column<long>(type: "bigint", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Available_For = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expected_Rent = table.Column<long>(type: "bigint", nullable: false),
                    Expected_Deposit = table.Column<long>(type: "bigint", nullable: false),
                    Rent_Negotiable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Monthly_Maintenance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Available_From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Preferred_Tenants = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Furnishing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number_Of_Bathrooms = table.Column<int>(type: "int", nullable: false),
                    Number_Of_Balcony = table.Column<int>(type: "int", nullable: false),
                    Type_Of_Water_Supply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gym = table.Column<bool>(type: "bit", nullable: false),
                    Non_Veg_Allowed = table.Column<bool>(type: "bit", nullable: false),
                    Gated_Security = table.Column<bool>(type: "bit", nullable: false),
                    Who_Will_Show_The_House = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secondary_Number = table.Column<long>(type: "bigint", nullable: false),
                    Post_AdPost_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resident_Rents", x => x.Resident_Rent_Id);
                    table.ForeignKey(
                        name: "FK_Resident_Rents_Post_Ads_Post_AdPost_Id",
                        column: x => x.Post_AdPost_Id,
                        principalTable: "Post_Ads",
                        principalColumn: "Post_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resident_Sales",
                columns: table => new
                {
                    Resident_Sale_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apartment_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BHK_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ownership_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Built_Up_Area = table.Column<long>(type: "bigint", nullable: false),
                    Carpet_Area = table.Column<long>(type: "bigint", nullable: false),
                    Property_Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Total_Floor = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expected_Price = table.Column<long>(type: "bigint", nullable: false),
                    Maintenance_Cost = table.Column<long>(type: "bigint", nullable: false),
                    Available_From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kitchen_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Furnishing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number_Of_Bathrooms = table.Column<int>(type: "int", nullable: false),
                    Number_Of_Balcony = table.Column<int>(type: "int", nullable: false),
                    Type_Of_Water_Supply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gym = table.Column<bool>(type: "bit", nullable: false),
                    Power_Backup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gated_Security = table.Column<bool>(type: "bit", nullable: false),
                    Who_Will_Show_The_House = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secondary_Number = table.Column<long>(type: "bigint", nullable: false),
                    Post_AdPost_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resident_Sales", x => x.Resident_Sale_Id);
                    table.ForeignKey(
                        name: "FK_Resident_Sales_Post_Ads_Post_AdPost_Id",
                        column: x => x.Post_AdPost_Id,
                        principalTable: "Post_Ads",
                        principalColumn: "Post_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commercial_Rents_Post_AdPost_Id",
                table: "Commercial_Rents",
                column: "Post_AdPost_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Commercial_Sales_Post_AdPost_Id",
                table: "Commercial_Sales",
                column: "Post_AdPost_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Flatmates_Rents_Post_AdPost_Id",
                table: "Flatmates_Rents",
                column: "Post_AdPost_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pg_Hostel_Rents_Post_AdPost_Id",
                table: "Pg_Hostel_Rents",
                column: "Post_AdPost_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Resident_Rents_Post_AdPost_Id",
                table: "Resident_Rents",
                column: "Post_AdPost_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Resident_Sales_Post_AdPost_Id",
                table: "Resident_Sales",
                column: "Post_AdPost_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commercial_Rents");

            migrationBuilder.DropTable(
                name: "Commercial_Sales");

            migrationBuilder.DropTable(
                name: "Flatmates_Rents");

            migrationBuilder.DropTable(
                name: "Pg_Hostel_Rents");

            migrationBuilder.DropTable(
                name: "Resident_Rents");

            migrationBuilder.DropTable(
                name: "Resident_Sales");

            migrationBuilder.DropTable(
                name: "Post_Ads");
        }
    }
}

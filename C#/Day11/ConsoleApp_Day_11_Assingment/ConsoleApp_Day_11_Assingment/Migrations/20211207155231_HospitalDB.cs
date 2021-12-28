using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp_Day_11_Assingment.Migrations
{
    public partial class HospitalDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false),
                    DepartmentName = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    MedicineId = table.Column<int>(nullable: false),
                    MedicineName = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.MedicineId);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false),
                    DoctorName = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.DoctorId);
                    table.ForeignKey(
                        name: "FK__Doctor__Departme__267ABA7A",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assistent",
                columns: table => new
                {
                    AssistentId = table.Column<int>(nullable: false),
                    AssistentName = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    DoctorId = table.Column<int>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assistent", x => x.AssistentId);
                    table.ForeignKey(
                        name: "FK__Assistent__Depar__2A4B4B5E",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Assistent__Docto__29572725",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientId = table.Column<int>(nullable: false),
                    PatientName = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    AssistentId = table.Column<int>(nullable: true),
                    DoctorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK__Patient__Assiste__2D27B809",
                        column: x => x.AssistentId,
                        principalTable: "Assistent",
                        principalColumn: "AssistentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Patient__DoctorI__2E1BDC42",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoctorPatient",
                columns: table => new
                {
                    DoctorPatientId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: true),
                    DoctorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatient", x => x.DoctorPatientId);
                    table.ForeignKey(
                        name: "FK__DoctorPat__Docto__33D4B598",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__DoctorPat__Patie__32E0915F",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientMedicineList",
                columns: table => new
                {
                    PatientMedicineListId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: true),
                    MedicineId = table.Column<int>(nullable: true),
                    DayPart = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicineList", x => x.PatientMedicineListId);
                    table.ForeignKey(
                        name: "FK__PatientMe__Medic__37A5467C",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "MedicineId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__PatientMe__Patie__36B12243",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientReport",
                columns: table => new
                {
                    PatientReportId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: true),
                    BloodPressure = table.Column<int>(nullable: true),
                    Sugar = table.Column<int>(nullable: true),
                    Hearbit = table.Column<int>(nullable: true),
                    HealthStatus = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientReport", x => x.PatientReportId);
                    table.ForeignKey(
                        name: "FK__PatientRe__Patie__3A81B327",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assistent_DepartmentId",
                table: "Assistent",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Assistent_DoctorId",
                table: "Assistent",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_DepartmentId",
                table: "Doctor",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatient_DoctorId",
                table: "DoctorPatient",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatient_PatientId",
                table: "DoctorPatient",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_AssistentId",
                table: "Patient",
                column: "AssistentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_DoctorId",
                table: "Patient",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicineList_MedicineId",
                table: "PatientMedicineList",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicineList_PatientId",
                table: "PatientMedicineList",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientReport_PatientId",
                table: "PatientReport",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorPatient");

            migrationBuilder.DropTable(
                name: "PatientMedicineList");

            migrationBuilder.DropTable(
                name: "PatientReport");

            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Assistent");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}

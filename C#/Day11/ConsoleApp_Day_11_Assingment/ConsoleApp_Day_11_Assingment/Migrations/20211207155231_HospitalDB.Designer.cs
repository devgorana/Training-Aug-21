﻿// <auto-generated />
using System;
using HospitalDbFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp_Day_11_Assingment.Migrations
{
    [DbContext(typeof(HospitalDBContext))]
    [Migration("20211207155231_HospitalDB")]
    partial class HospitalDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalDbFirst.Models.Assistent", b =>
                {
                    b.Property<int>("AssistentId")
                        .HasColumnType("int");

                    b.Property<string>("AssistentName")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.HasKey("AssistentId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Assistent");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorName")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("DoctorId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.DoctorPatient", b =>
                {
                    b.Property<int>("DoctorPatientId")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("DoctorPatientId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("DoctorPatient");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<string>("MedicineName")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("MedicineId");

                    b.ToTable("Medicine");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int?>("AssistentId")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("PatientId");

                    b.HasIndex("AssistentId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.PatientMedicineList", b =>
                {
                    b.Property<int>("PatientMedicineListId")
                        .HasColumnType("int");

                    b.Property<int?>("DayPart")
                        .HasColumnType("int");

                    b.Property<int?>("MedicineId")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("PatientMedicineListId");

                    b.HasIndex("MedicineId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientMedicineList");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.PatientReport", b =>
                {
                    b.Property<int>("PatientReportId")
                        .HasColumnType("int");

                    b.Property<int?>("BloodPressure")
                        .HasColumnType("int");

                    b.Property<int?>("HealthStatus")
                        .HasColumnType("int");

                    b.Property<int?>("Hearbit")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<int?>("Sugar")
                        .HasColumnType("int");

                    b.HasKey("PatientReportId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientReport");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.Assistent", b =>
                {
                    b.HasOne("HospitalDbFirst.Models.Department", "Department")
                        .WithMany("Assistent")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("FK__Assistent__Depar__2A4B4B5E");

                    b.HasOne("HospitalDbFirst.Models.Doctor", "Doctor")
                        .WithMany("Assistent")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK__Assistent__Docto__29572725");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.Doctor", b =>
                {
                    b.HasOne("HospitalDbFirst.Models.Department", "Department")
                        .WithMany("Doctor")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("FK__Doctor__Departme__267ABA7A");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.DoctorPatient", b =>
                {
                    b.HasOne("HospitalDbFirst.Models.Doctor", "Doctor")
                        .WithMany("DoctorPatient")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK__DoctorPat__Docto__33D4B598");

                    b.HasOne("HospitalDbFirst.Models.Patient", "Patient")
                        .WithMany("DoctorPatient")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("FK__DoctorPat__Patie__32E0915F");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.Patient", b =>
                {
                    b.HasOne("HospitalDbFirst.Models.Assistent", "Assistent")
                        .WithMany("Patient")
                        .HasForeignKey("AssistentId")
                        .HasConstraintName("FK__Patient__Assiste__2D27B809");

                    b.HasOne("HospitalDbFirst.Models.Doctor", "Doctor")
                        .WithMany("Patient")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK__Patient__DoctorI__2E1BDC42");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.PatientMedicineList", b =>
                {
                    b.HasOne("HospitalDbFirst.Models.Medicine", "Medicine")
                        .WithMany("PatientMedicineList")
                        .HasForeignKey("MedicineId")
                        .HasConstraintName("FK__PatientMe__Medic__37A5467C");

                    b.HasOne("HospitalDbFirst.Models.Patient", "Patient")
                        .WithMany("PatientMedicineList")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("FK__PatientMe__Patie__36B12243");
                });

            modelBuilder.Entity("HospitalDbFirst.Models.PatientReport", b =>
                {
                    b.HasOne("HospitalDbFirst.Models.Patient", "Patient")
                        .WithMany("PatientReport")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("FK__PatientRe__Patie__3A81B327");
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalDbFirst.Models
{
    public partial class HospitalDBContext : DbContext
    {
        public HospitalDBContext()
        {
        }

        public HospitalDBContext(DbContextOptions<HospitalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assistent> Assistent { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<DoctorPatient> DoctorPatient { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientMedicineList> PatientMedicineList { get; set; }
        public virtual DbSet<PatientReport> PatientReport { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=Hospital_Managment;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assistent>(entity =>
            {
                entity.Property(e => e.AssistentId).ValueGeneratedNever();

                entity.Property(e => e.AssistentName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Assistent)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Assistent__Depar__2A4B4B5E");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Assistent)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__Assistent__Docto__29572725");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).ValueGeneratedNever();

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.DoctorId).ValueGeneratedNever();

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Doctor__Departme__267ABA7A");
            });

            modelBuilder.Entity<DoctorPatient>(entity =>
            {
                entity.Property(e => e.DoctorPatientId).ValueGeneratedNever();

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorPatient)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__DoctorPat__Docto__33D4B598");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DoctorPatient)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__DoctorPat__Patie__32E0915F");
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.MedicineId).ValueGeneratedNever();

                entity.Property(e => e.MedicineName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.PatientId).ValueGeneratedNever();

                entity.Property(e => e.PatientName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Assistent)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.AssistentId)
                    .HasConstraintName("FK__Patient__Assiste__2D27B809");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__Patient__DoctorI__2E1BDC42");
            });

            modelBuilder.Entity<PatientMedicineList>(entity =>
            {
                entity.Property(e => e.PatientMedicineListId).ValueGeneratedNever();

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.PatientMedicineList)
                    .HasForeignKey(d => d.MedicineId)
                    .HasConstraintName("FK__PatientMe__Medic__37A5467C");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMedicineList)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__PatientMe__Patie__36B12243");
            });

            modelBuilder.Entity<PatientReport>(entity =>
            {
                entity.Property(e => e.PatientReportId).ValueGeneratedNever();

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientReport)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__PatientRe__Patie__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
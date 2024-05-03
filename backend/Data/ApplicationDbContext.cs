using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<DoctorService> DoctorServices { get; set; }

        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-3MIQ4HF;Initial Catalog=HospitalManagement;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DoctorService>()
                .HasKey(ds => new { ds.DoctorId, ds.ServiceId });
            modelBuilder.Entity<DoctorService>()
                .HasOne(d => d.Doctor)
                .WithMany(ds => ds.DoctorServices)
                .HasForeignKey(d => d.DoctorId);
            modelBuilder.Entity<DoctorService>()
                .HasOne(s => s.Service)
                .WithMany(ds => ds.DoctorServices)
                .HasForeignKey(s => s.ServiceId);
        }
    }
}

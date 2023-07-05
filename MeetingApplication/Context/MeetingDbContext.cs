using MeetingApplication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApplication.Context
{
    public class MeetingDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                   "server=.; database=MeetingDb;trusted_connection=true");
        }

        public DbSet<MeetingReport> MeetingReports { get; set; }
        public DbSet<Meeting> Meetings { get; set; }

        public DbSet<MeetingPlatform>MeetingPlatforms { get; set; }

        public DbSet<MeetingSubject>MeetingSubjects { get; set; }

        public DbSet<MeetingPerson>MeetingPersons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>()
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<MeetingPerson>().HasKey(x => new { x.TcNo, x.Id });
        }

        //FLUENT API ile configrasyon işlemi yaptık. ara tablomuzdaki propertyleri haskey de kullandık.!!
       
    }
}

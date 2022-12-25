using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using University.Models;
using University.Models;
using University.Configurations;
using University.Models;


namespace University
{
    public class UniversityDbContext : DbContext
    {

        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {

        }
        #region DbSet
      
        public DbSet<Address> Addresses { get; set; }
     
        public DbSet<Balance> Balances { get; set; }
      
        public DbSet<Department> Departments { get; set; }
      
        public DbSet<Room> Rooms { get; set; }
      
        public DbSet<Schedule> Schedules { get; set; }
      
        public DbSet<ScheduleRoom> ScheduleRooms { get; set; }

        public DbSet<ScheduleSubject> ScheduleSubjects { get; set; }
     
        public DbSet<Semester> Semesters { get; set; }
     
        public DbSet<Student> Students { get; set; }

        public DbSet<StudentSubject>? StudentSubjects { get; set; }

        public DbSet<Subject> Subjects { get; set; }
       
        public DbSet<Teacher> Teachers { get; set; }
        
        public DbSet<Responce> Responces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AddressConfiguration).Assembly);
        }


    }
}

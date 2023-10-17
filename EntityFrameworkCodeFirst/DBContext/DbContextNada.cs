using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCodeFirst.DBContext
{
    public class DbContextNada : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=. ;database=EfITI ;trusted_connection=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //one to many relationship between Department and Instructor "contains"
            modelBuilder.Entity<Department>()
                .HasMany(D => D.instructors)
                .WithOne(ins => ins.Department)
                .IsRequired(true);

           // one to one relationship between Department and Instructor "manage"
            modelBuilder.Entity<Department>()
                .HasOne(D => D.instructor)
                .WithOne()
                .IsRequired(false).HasForeignKey<Department>(d=>d.InstructorId);

            modelBuilder.Entity<CourseInst>()
              .HasKey("InstructorId", "CourseId");



            modelBuilder.Entity<StudCrs>()
                .HasKey("StudentId", "CourseId");


            base.OnModelCreating(modelBuilder);
        }

       // public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseInst> CourseInsts { get; set; }
        public DbSet<StudCrs> StudCrses { get; set; }
        public DbSet<Topic> Topics { get; set; }

        public DbSet<Course> Courses { get; set; }




    }
}

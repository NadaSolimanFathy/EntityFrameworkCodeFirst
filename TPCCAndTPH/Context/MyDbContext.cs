using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCCAndTPH.Entities;

namespace TPCCAndTPH.Context
{
    internal class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=. ;database=EmpTPCC ;trusted_connection=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FullTimeEmployee>().HasBaseType(typeof(Employee));
            // modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();

            modelBuilder.Entity<PartTimeEmployee>().HasBaseType(typeof(Employee));
            // modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();

            base.OnModelCreating(modelBuilder);
        }


        //by convension it's understood that both of them have parent.
        //Table Per Concrete Class Approach
        //public DbSet<FullTimeEmployee>fullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee>partTimeEmployees { get; set; }



        //Table Per Hirerchy

        public DbSet<Employee> Employees { get; set; }


    }
}

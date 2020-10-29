using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerBlazor.Models;

namespace tuseTheProgrammer.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity(typeof(Department)).HasData(
                new Department()
                {
                    DepartmentId = 1,
                    DepartmentName = "IT"
                },
                new Department()
                {
                    DepartmentId = 2,
                    DepartmentName = "HR"
                },
                 new Department()
                 {
                     DepartmentId = 3,
                     DepartmentName = "Payroll"
                 },
                  new Department()
                  {
                      DepartmentId = 4,
                      DepartmentName = "Admin"
                  }
                );

            modelBuilder.Entity(typeof(Employee)).HasData(
               new Employee()
               {
                   EmployeeId = 1,
                   FirstName = "David",
                   LastName = "James",
                   Email = "david@tuseTheProgrammer.com",
                   BirthDate = new DateTime(1980, 12, 10),
                   Gender = Gender.Male,
                   PhotoPath = "images/david.png",
                   DepartmentId = 1
               },
               new Employee()
               {
                   EmployeeId = 2,
                   FirstName = "Sara",
                   LastName = "Peters",
                   Email = "sara@tuseTheProgrammer.com",
                   BirthDate = new DateTime(1990, 10, 05),
                   DepartmentId = 2,
                   Gender = Gender.Female,
                   PhotoPath = "images/sara.png"
               },
                new Employee()
                {
                    EmployeeId = 3,
                    FirstName = "Freya",
                    LastName = "Holland",
                    Email = "freya@tuseTheProgrammer.com",
                    BirthDate = new DateTime(1996, 05, 11),
                    DepartmentId = 4,
                    Gender = Gender.Female,
                    PhotoPath = "images/freya.png"
                },
                 new Employee()
                 {
                     EmployeeId = 4,
                     FirstName = "Prince",
                     LastName = "Solo",
                     Email = "price@tuseTheProgrammer.com",
                     BirthDate = new DateTime(1985, 08, 10),
                     DepartmentId = 3,
                     Gender = Gender.Male,
                     PhotoPath = "images/car.jpg"
                 }
               );
        }
    }
}

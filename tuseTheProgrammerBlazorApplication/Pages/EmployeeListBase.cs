using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerBlazor.Models;

namespace tuseTheProgrammerBlazorApplication.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }
        protected override Task OnInitializedAsync()
        {
            LoadAllEmployees();
            return base.OnInitializedAsync();
        }
        private void LoadAllEmployees()
        {
            Employee emp1 = new Employee()
            {
                EmployeeId = 101,
                FirstName = "David",
                LastName = "James",
                Email = "david@tuseTheProgrammer.com",
                BirthDate = new DateTime(1980, 12, 10),
                Department = new Department() { DepartmentId = 1, DepartmentName = "IT" },
                Gender = Gender.Male,
                PhotoPath = "images/david.png"
            };

            Employee emp2 = new Employee()
            {
                EmployeeId = 102,
                FirstName = "Sara",
                LastName = "Peters",
                Email = "sara@tuseTheProgrammer.com",
                BirthDate = new DateTime(1990, 10, 05),
                Department = new Department() { DepartmentId = 2, DepartmentName = "HR" },
                Gender = Gender.Female,
                PhotoPath = "images/sara.png"
            };

            Employee emp3 = new Employee()
            {
                EmployeeId = 103,
                FirstName = "Freya",
                LastName = "Holland",
                Email = "freya@tuseTheProgrammer.com",
                BirthDate = new DateTime(1996, 05, 11),
                Department = new Department() { DepartmentId = 3, DepartmentName = "MGT" },
                Gender = Gender.Female,
                PhotoPath = "images/freya.png"
            };

            Employee emp4 = new Employee()
            {
                EmployeeId = 104,
                FirstName = "Prince",
                LastName = "Solo",
                Email = "price@tuseTheProgrammer.com",
                BirthDate = new DateTime(1985, 08, 10),
                Department = new Department() { DepartmentId = 4, DepartmentName = "IT" },
                Gender = Gender.Male,
                PhotoPath = "images/car.jpg"
            };


            List<Employee> listOfEmployees = new List<Employee>()
           {
               emp1, emp2, emp3, emp4
           };

            Employees = listOfEmployees;
        }
    }
}

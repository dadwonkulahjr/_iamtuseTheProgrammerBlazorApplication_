using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerBlazor.Models;
using tuseTheProgrammerBlazorApplication.Services;

namespace tuseTheProgrammerBlazorApplication.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeService.GetEmployees();
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
                DepartmentId = 1,
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
                DepartmentId = 2,
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
                DepartmentId = 1,
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
                DepartmentId = 3,
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

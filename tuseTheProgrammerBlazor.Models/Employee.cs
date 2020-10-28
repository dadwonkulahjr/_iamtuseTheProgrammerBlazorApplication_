using System;
using System.Collections.Generic;
using System.Text;

namespace tuseTheProgrammerBlazor.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public DateTime BirthDate { get; set; }
        public Department Department { get; set; }
        public Gender Gender { get; set; }
    }
}

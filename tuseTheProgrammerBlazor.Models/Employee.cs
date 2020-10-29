using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace tuseTheProgrammerBlazor.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage ="Minimun character should be two.")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public DateTime BirthDate { get; set; }
        public int DepartmentId { get; set; }
        public Gender Gender { get; set; }
    }
}

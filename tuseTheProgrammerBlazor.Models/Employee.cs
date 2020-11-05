using System;
using System.ComponentModel.DataAnnotations;
using tuseTheProgrammerBlazor.Models.CustomValidator;

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
        [EmailAddress]
        [EmailValidator(allowEmailDomain:"tuseTheProgrammer.com", ErrorMessage ="Only tuseTheProgrammer.com email is allowed.")]
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public DateTime BirthDate { get; set; }
        public int DepartmentId { get; set; }
        public Gender Gender { get; set; }
        [ValidateComplexType]
        public Department Department { get; set; } 
    }
}

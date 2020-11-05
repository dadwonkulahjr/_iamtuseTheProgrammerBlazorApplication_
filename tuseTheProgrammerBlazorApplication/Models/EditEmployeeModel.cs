using System;
using System.ComponentModel.DataAnnotations;
using tuseTheProgrammerBlazor.Models;
using tuseTheProgrammerBlazor.Models.CustomValidator;

namespace tuseTheProgrammerBlazorApplication.Models
{
    public class EditEmployeeModel
    {
        public int EmployeeId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Minimun character should be two.")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [EmailValidator(allowEmailDomain: "tuseTheProgrammer.com", ErrorMessage = "Only tuseTheProgrammer.com email is allowed.")]
        public string Email { get; set; }
        [CompareProperty(nameof(Email), ErrorMessage ="Email and confirm email must match")]
        public string ConfirmedEmail { get; set; }
        public string PhotoPath { get; set; }
        public DateTime BirthDate { get; set; }
        public int DepartmentId { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; } = new Department();
    }
}

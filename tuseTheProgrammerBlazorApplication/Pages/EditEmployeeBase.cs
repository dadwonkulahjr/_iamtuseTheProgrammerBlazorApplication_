using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerBlazor.Models;
using tuseTheProgrammerBlazorApplication.Services;

namespace tuseTheProgrammerBlazorApplication.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
        public Employee Employee { get; set; } = new Employee();
        [Parameter]
        public string Id { get; set; }
        public string DepartmentId { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployeeById(int.Parse(Id));
            Departments = (await DepartmentService.GetAllDepartments()).ToList();
            DepartmentId = Employee.DepartmentId.ToString();
        }
    }
}

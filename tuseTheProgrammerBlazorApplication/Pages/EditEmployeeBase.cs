using AutoMapper;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammer.Component;
using tuseTheProgrammerBlazor.Models;
using tuseTheProgrammerBlazorApplication.Models;
using tuseTheProgrammerBlazorApplication.Services;

namespace tuseTheProgrammerBlazorApplication.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        #region Services and Properties...
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IMapper Mapper { get; set; }
        protected DeleteConfirmation DeleteConfirmationComplete { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
        public string PageTextHeader { get; set; }
        private Employee Employee { get; set; } = new Employee();
        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();
        [Parameter]
        public string Id { get; set; }
        #endregion
        #region Methods and Logic...
        protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int employeeId);
            if (employeeId != 0)
            {
                PageTextHeader = "Edit Employee";
                Employee = await EmployeeService.GetEmployeeById(int.Parse(Id));
            }
            else
            {
                PageTextHeader = "Create new record";
                Employee = new Employee()
                {
                    BirthDate = DateTime.Now,
                    DepartmentId = 1,
                    PhotoPath = "/images/employees.png"
                };


            }
            Departments = (await DepartmentService.GetAllDepartments()).ToList();

            Mapper.Map(Employee, EditEmployeeModel);

        }
        protected async Task SubmitValid()
        {
            Mapper.Map(EditEmployeeModel, Employee);
            Employee result = null;

            if (Employee.EmployeeId != 0)
            {
                result = await EmployeeService.UpdateEmployee(Employee);
            }
            else
            {
                result = await EmployeeService.CreateEmployee(Employee);
            }

            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
        protected async Task HandleDeleteAction()
        {
            await EmployeeService.DeleteEmployee(Employee.EmployeeId);
            NavigationManager.NavigateTo("/");
        }

        protected void DeleteEmployee()
        {
            DeleteConfirmationComplete.Show();
        }

        protected async Task Delete_Click(bool confirmDelete)
        {
            if (confirmDelete)
            {
                await EmployeeService.DeleteEmployee(Employee.EmployeeId);
                NavigationManager.NavigateTo("/");
            }
        }

    }
    #endregion
}

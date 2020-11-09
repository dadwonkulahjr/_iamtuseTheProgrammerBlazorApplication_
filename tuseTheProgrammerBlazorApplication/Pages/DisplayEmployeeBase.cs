using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammer.Component;
using tuseTheProgrammerBlazor.Models;
using tuseTheProgrammerBlazorApplication.Services;

namespace tuseTheProgrammerBlazorApplication.Pages
{
    public class DisplayEmployeeBase : ComponentBase
    {
        [Parameter]
        public Employee Employee { get; set; }
        [Parameter]
        public bool ShowFooter { get; set; }
        [Parameter]
        public EventCallback<bool> OnCheckBoxSelectedChanged { get; set; }

        [Parameter]
        public EventCallback<int> OnEmployeeDeleted { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected DeleteConfirmation DeleteConfirmationComplete { get; set; }
        protected async Task CheckBox_Checked(ChangeEventArgs e)
        {
            await OnCheckBoxSelectedChanged.InvokeAsync((bool)e.Value);
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
                await OnEmployeeDeleted.InvokeAsync(Employee.EmployeeId);
            }
        }
    }
}

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammer.Component;
using tuseTheProgrammerBlazor.Models;
using tuseTheProgrammerBlazorApplication.Services;

namespace tuseTheProgrammerBlazorApplication.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }
        public Employee Employee { get; set; } = new Employee();
        protected string Coordinates { get; set; } = null;
        protected string ButtonText { get; set; } = "Hide Footer";
        protected DeleteConfirmation DeleteConfirmationComplete { get; set; }
        protected string CssClass { get; set; } = null;
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
       
        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Employee = await EmployeeService.GetEmployeeById(int.Parse(Id));
        }
        protected void Dynamic_Button()
        {
            if(ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            }
            else
            {
                CssClass = null;
                ButtonText = "Hide Footer";
               
            }
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
        //protected void Move_Mouse(MouseEventArgs e)
        //{
        //    Coordinates = $"X = {e.ClientX} Y = {e.ClientY}";
        //}
    }
}

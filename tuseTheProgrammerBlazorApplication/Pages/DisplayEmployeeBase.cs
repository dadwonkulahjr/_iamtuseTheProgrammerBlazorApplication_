using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerBlazor.Models;

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

        protected async Task CheckBox_Checked(ChangeEventArgs e)
        {
            await OnCheckBoxSelectedChanged.InvokeAsync((bool)e.Value);
        }
    }
}

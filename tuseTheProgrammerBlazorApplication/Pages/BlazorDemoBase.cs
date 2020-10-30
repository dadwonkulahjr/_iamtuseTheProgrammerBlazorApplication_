using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tuseTheProgrammerBlazorApplication.Pages
{
    public class BlazorDemoBase : ComponentBase
    {
        protected string Name { get; set; } = "tuseTheProgrammer";
        protected string Gender { get; set; } = "Male";
    }
}

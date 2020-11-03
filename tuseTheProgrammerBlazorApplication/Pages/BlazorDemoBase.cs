using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace tuseTheProgrammerBlazorApplication.Pages
{
    public class BlazorDemoBase : ComponentBase
    {
        protected string Description { get; set; } = string.Empty;
    }
}

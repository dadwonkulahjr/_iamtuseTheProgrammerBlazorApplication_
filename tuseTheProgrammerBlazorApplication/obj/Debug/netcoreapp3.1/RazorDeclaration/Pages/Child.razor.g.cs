#pragma checksum "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\Child.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "896aa62cabd1897cc16cd547fd39862c818ae097"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace tuseTheProgrammerBlazorApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\_Imports.razor"
using tuseTheProgrammerBlazorApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\_Imports.razor"
using tuseTheProgrammerBlazorApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\_Imports.razor"
using tuseTheProgrammer.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\_Imports.razor"
using tuseTheProgrammerBlazor.Models;

#line default
#line hidden
#nullable disable
    public partial class Child : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\Child.razor"
       

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> InputAttribute { get; set; }
    = new Dictionary<string, object>()
    {
        {"required","required" },
        {"placeholder", "I am from the child component" },
        {"maxsize", "5" },
        {"size", "10" }
    };
    [Parameter]
    public string Value { get; set; } = "Child Value";
    //[Parameter]
    //public string PlaceHolder { get; set; } = "I am the Child Component";
    //[Parameter]
    //public string Required { get; set; } = "required";
    //[Parameter]
    //public string MaxLength { get; set; } = "5";
    //[Parameter]
    //public string Size { get; set; } = "4";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
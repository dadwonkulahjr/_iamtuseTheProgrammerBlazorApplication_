#pragma checksum "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3adfeb53e0b0f5c1a28ae17822e64a38dc627320"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Select Employees Count - ");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeList.razor"
                              EmployeeTotalCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "checkbox");
            __builder.AddAttribute(6, "id", "showFooter");
            __builder.AddAttribute(7, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeList.razor"
                                              ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ShowFooter = __value, ShowFooter));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.AddMarkupContent(10, "<label for=\"showFooter\">Show Footer</label>\r\n");
#nullable restore
#line 6 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeList.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 9 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-deck");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 13 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeList.razor"
         foreach (var employee in Employees)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "           ");
            __builder.OpenComponent<tuseTheProgrammerBlazorApplication.Pages.DisplayEmployee>(17);
            __builder.AddAttribute(18, "Employee", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<tuseTheProgrammerBlazor.Models.Employee>(
#nullable restore
#line 15 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeList.razor"
                                      employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeList.razor"
                                                            ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OnCheckBoxSelectedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 16 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeList.razor"
                                                      EmployeeSelectionChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 17 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeList.razor"

       
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 23 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

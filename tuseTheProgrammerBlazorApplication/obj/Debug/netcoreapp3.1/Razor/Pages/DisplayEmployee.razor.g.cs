#pragma checksum "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca40ee7b95a4d2108e146f04ea4917dada255c15"
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
    public partial class DisplayEmployee : DisplayEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card mt-2");
            __builder.AddAttribute(2, "style", "min-width:18rem;max-width:30.5%");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "h3");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "checkbox");
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor"
                                              CheckBox_Checked

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddContent(13, 
#nullable restore
#line 7 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor"
             Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " ");
            __builder.AddContent(15, 
#nullable restore
#line 7 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor"
                                 Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "class", "card-img-top imageThumbanail");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 10 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor"
                                                    Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 11 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor"
     if (ShowFooter)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-footer text-center text-white");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "class", "btn btn-primary mt-1");
            __builder.AddAttribute(29, "href", 
#nullable restore
#line 14 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor"
                                                    $"employeeDetails/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "class", "btn btn-primary mt-1");
            __builder.AddAttribute(34, "href", 
#nullable restore
#line 15 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor"
                                                    $"editEmployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "btn btn-danger mt-1");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor"
                                                                        DeleteEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 18 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.OpenComponent<tuseTheProgrammer.Component.DeleteConfirmation>(45);
            __builder.AddAttribute(46, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor"
                                          $"Are you sure you want to delete employee {Employee.LastName + "," + Employee.FirstName}?"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 20 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor"
                                                                                                                                                                                              Delete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(48, (__value) => {
#nullable restore
#line 20 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\DisplayEmployee.razor"
                                                                                                                                             DeleteConfirmationComplete = (tuseTheProgrammer.Component.DeleteConfirmation)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

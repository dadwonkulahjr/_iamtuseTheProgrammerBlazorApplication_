#pragma checksum "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4e5e07d8586fa87e927f03d0e617fe6b1053590"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeDetails/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeDetails")]
    public partial class EmployeeDetails : EmployeeDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
 if (Employee == null || Employee.Department == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 9 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-center");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-8");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-header");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "h3");
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.AddContent(16, 
#nullable restore
#line 17 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                         Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.AddContent(18, 
#nullable restore
#line 17 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                                             Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, " ");
            __builder.AddContent(20, 
#nullable restore
#line 17 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                                                                Coordinates

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-body text-center");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "img");
            __builder.AddAttribute(28, "src", 
#nullable restore
#line 21 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                               Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "class", "card-img-top img-thumbnail");
            __builder.AddAttribute(30, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                                         e => Coordinates = $"X = {e.ClientX} Y = {e.ClientY}"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "h4");
            __builder.AddMarkupContent(33, "\r\n                        Gender :  ");
            __builder.AddContent(34, 
#nullable restore
#line 24 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                                   Employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "h4");
            __builder.AddMarkupContent(38, "\r\n                        Date Of Birth :  ");
            __builder.AddContent(39, 
#nullable restore
#line 27 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                                          Employee.BirthDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "h4");
            __builder.AddMarkupContent(43, "\r\n                        Email :  ");
            __builder.AddContent(44, 
#nullable restore
#line 30 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                                  Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "h4");
            __builder.AddMarkupContent(48, "\r\n                        Department Name :  ");
            __builder.AddContent(49, 
#nullable restore
#line 33 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                                            Employee.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "class", "btn btn-primary");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                                                               Dynamic_Button

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(55, 
#nullable restore
#line 35 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                                                                                ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "card-footer" + " text-center" + " text-white" + " " + (
#nullable restore
#line 37 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                                                                CssClass

#line default
#line hidden
#nullable disable
            ) + " mb-4");
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.AddMarkupContent(61, "<a class=\"btn btn-primary mt-1\" href=\"/\">Back</a>\r\n                    ");
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "class", "btn btn-primary mt-1");
            __builder.AddAttribute(64, "href", 
#nullable restore
#line 39 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"
                                                            $"editEmployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.AddMarkupContent(67, "<a class=\"btn btn-danger mt-1\">Delete</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#nullable restore
#line 48 "C:\Users\Dad S. Wonkulah Jr\source\repos\tuseTheProgrammerBlazorApplication\tuseTheProgrammerBlazorApplication\Pages\EmployeeDetails.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

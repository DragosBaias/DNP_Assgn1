#pragma checksum "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4e0d79585a4a14b517751d236267171b0560ccd"
// <auto-generated/>
#pragma warning disable 1591
namespace FamilyManagerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\_Imports.razor"
using FamilyManagerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\_Imports.razor"
using FamilyManagerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Person/{id:int}/{Firstname}/{Lastname}")]
    public partial class PersonDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-6 mb-6 p-6 my-auto h-100 w-50");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card p-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", " image d-flex flex-column justify-content-center align-items-center");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex flex-row justify-content-center mt-3");
#nullable restore
#line 11 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
             if (_person.Sex.Equals("F")) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<button class=\"btn btn-secondary mt-3\"><img src=\"/Images/girl.jpg\" height=\"100\" width=\"100\"><br></button>");
#nullable restore
#line 15 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
            }
            else {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<button class=\"btn btn-secondary mt-3\"><img src=\"/Images/boy.png\" height=\"100\" width=\"100\"><br></button>");
#nullable restore
#line 20 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n            ");
            __builder.OpenElement(11, "div");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "mt-3");
            __builder.AddContent(14, 
#nullable restore
#line 23 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                                    _person.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 23 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                                                       _person.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n            ");
            __builder.OpenElement(18, "div");
            __builder.OpenElement(19, "span");
            __builder.AddAttribute(20, "class", "mt-3");
            __builder.AddContent(21, "Age: ");
            __builder.AddContent(22, 
#nullable restore
#line 26 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                                         _person.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "d-flex flex-row justify-content-center align-items-center mt-3");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "class", "idd1");
            __builder.AddContent(28, "Height: ");
            __builder.AddContent(29, 
#nullable restore
#line 29 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                                            _person.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "d-flex flex-row justify-content-center align-items-center mt-3");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "class", "idd1");
            __builder.AddContent(35, "Weight: ");
            __builder.AddContent(36, 
#nullable restore
#line 32 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                                            _person.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "d-flex flex-row justify-content-center align-items-center mt-3 w-25");
            __builder.AddMarkupContent(40, "\n                Sex:\n                ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "checkbox");
            __builder.AddAttribute(43, "checked", 
#nullable restore
#line 36 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                                                 _person.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                ");
            __builder.OpenElement(45, "label");
            __builder.AddContent(46, 
#nullable restore
#line 37 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                        _person.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "<br>");
#nullable restore
#line 38 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                 if (_person.Sex.Equals("F")) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(48, "<input type=\"checkbox\">\n                    ");
            __builder.AddMarkupContent(49, "<label>M</label>");
#nullable restore
#line 41 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                }
                else {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "<input type=\"checkbox\">\n                    ");
            __builder.AddMarkupContent(51, "<label>F</label>");
#nullable restore
#line 45 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "text mt-3");
            __builder.OpenElement(55, "span");
            __builder.AddContent(56, "Eye Color: ");
            __builder.AddContent(57, 
#nullable restore
#line 48 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                                  _person.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "px-2 rounded mt-3");
            __builder.OpenElement(61, "span");
            __builder.AddAttribute(62, "class", "join");
            __builder.AddContent(63, "Hair Color: ");
            __builder.AddContent(64, 
#nullable restore
#line 51 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                                                _person.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
             if (_person is Adult) {
                Adult adult = (Adult) _person;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "px-2 rounded mt-3");
            __builder.OpenElement(67, "span");
            __builder.AddContent(68, "Job title: ");
            __builder.AddContent(69, 
#nullable restore
#line 56 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                                      adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
             if (_person is Child) {
                Child child = (Child) _person;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                 if (child.Pets.Count != 0) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "px-2 rounded mt-3");
            __builder.AddMarkupContent(72, "\n                        Pets:\n");
#nullable restore
#line 64 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                         foreach (var pet in child.Pets) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(73, "span");
            __builder.AddContent(74, 
#nullable restore
#line 65 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                                   pet.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\PersonDetails.razor"
       
    [Parameter]
    public int Id { set; get; }
    [Parameter]
    public string Firstname { set; get; }
    [Parameter]
    public string Lastname { set; get; }

    public string FirstLastName { get; set; }

    private Person _person;

    protected override async Task OnInitializedAsync() {
        _person = _familyData.GetPersonByIdFirstLastName(Id, Firstname,Lastname);
        FirstLastName = $"{Firstname} {Lastname}";
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyData _familyData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591

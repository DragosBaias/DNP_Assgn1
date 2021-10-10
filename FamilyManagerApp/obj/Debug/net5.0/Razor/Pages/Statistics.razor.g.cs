#pragma checksum "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4db8733d5cb499e428f220c56f532d68a67de013"
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
#line 7 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
using FamilyManagerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/statistics")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/stats")]
    public partial class Statistics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card mb-5");
            __builder.AddMarkupContent(2, "<h1 class=\"card-header mb-3\">Statistics</h1>\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-xl-3 col-md-12");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, "Total number of families: ");
            __builder.OpenElement(9, "strong");
            __builder.AddContent(10, 
#nullable restore
#line 14 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
                                                  _families.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n            ");
            __builder.OpenElement(12, "p");
            __builder.AddContent(13, "Total number of adults: ");
            __builder.OpenElement(14, "strong");
            __builder.AddContent(15, 
#nullable restore
#line 15 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
                                                _people.Count(p => p is Adult)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n            ");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, "Total number of children: ");
            __builder.OpenElement(19, "strong");
            __builder.AddContent(20, 
#nullable restore
#line 16 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
                                                  _people.Count(p => p is Child)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n            ");
            __builder.OpenElement(22, "p");
            __builder.AddContent(23, "Total number of pets: ");
            __builder.OpenElement(24, "strong");
            __builder.AddContent(25, 
#nullable restore
#line 17 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
                                              _families.Sum(f => f.Pets.Count())

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-xl-4 col-md-12");
            __builder.OpenElement(29, "p");
            __builder.AddContent(30, "Average number of people per family: ");
            __builder.OpenElement(31, "strong");
            __builder.AddContent(32, 
#nullable restore
#line 20 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
                                                             Math.Round(_families.Average(f => f.Adults.Count() + f.Children.Count()), 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n            ");
            __builder.OpenElement(34, "p");
            __builder.AddContent(35, "Average number of adults per family: ");
            __builder.OpenElement(36, "strong");
            __builder.AddContent(37, 
#nullable restore
#line 21 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
                                                             Math.Round(_families.Average(f => f.Adults.Count()), 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n            ");
            __builder.OpenElement(39, "p");
            __builder.AddContent(40, "Average number of children per family: ");
            __builder.OpenElement(41, "strong");
            __builder.AddContent(42, 
#nullable restore
#line 22 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
                                                               Math.Round(_families.Average(f => f.Children.Count()), 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n            ");
            __builder.OpenElement(44, "p");
            __builder.AddContent(45, "Average number of pets per family: ");
            __builder.OpenElement(46, "strong");
            __builder.AddContent(47, 
#nullable restore
#line 23 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
                                                           Math.Round(_families.Average(f => f.Pets.Count() + f.Children.Sum(c => c.Pets.Count)), 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-xl-5 col-md-12");
            __builder.OpenElement(51, "p");
            __builder.AddContent(52, "Total number of families with single parents: ");
            __builder.OpenElement(53, "strong");
            __builder.AddContent(54, 
#nullable restore
#line 26 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
                                                                      _families.Count(f => f.Adults.Count() == 1)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n            ");
            __builder.OpenElement(56, "p");
            __builder.AddContent(57, "Total number of people with the last name \'Mcclure\': ");
            __builder.OpenElement(58, "strong");
            __builder.AddContent(59, 
#nullable restore
#line 27 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
                                                                             _people.Count(p => p.LastName.Equals("Mcclure"))

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n            ");
            __builder.OpenElement(61, "p");
            __builder.AddContent(62, "Total number of teachers: ");
            __builder.OpenElement(63, "strong");
            __builder.AddContent(64, 
#nullable restore
#line 28 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
                                                  _people.Count(p => p is Adult adult && adult.JobTitle.JobTitle.Equals("Teacher"))

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n            ");
            __builder.OpenElement(66, "p");
            __builder.AddContent(67, "Total number of children with an interest in drawing: ");
            __builder.OpenElement(68, "strong");
            __builder.AddContent(69, 
#nullable restore
#line 29 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
                                                                              _people.Count(p => p is Child child && child.Interests.Any(i => i.Type.Equals("Drawing")))

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Statistics.razor"
       
    private IList<Family> _families;
    private IList<Person> _people;
    
    protected override async Task OnInitializedAsync()
    {
        _families = _model.GetFamilies();
        _people = _model.GetPeople();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyData _model { get; set; }
    }
}
#pragma warning restore 1591
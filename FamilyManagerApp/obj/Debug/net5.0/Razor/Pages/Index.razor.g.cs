#pragma checksum "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0ea8084d6d0d64ddd5483ee6f56fbe3d9dbd163"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<FamilyManagerApp.Pages.LoginPage>(2);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n\n");
            __builder.OpenElement(4, "SurveyPrompt");
            __builder.AddAttribute(5, "Title", "How is Blazor working for you?");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

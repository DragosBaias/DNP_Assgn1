#pragma checksum "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\RegisterPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752b0fd7b60b4410043d948c9c9dd13e88a0c7a3"
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
#line 2 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\RegisterPage.razor"
using FamilyManagerApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegisterPage")]
    public partial class RegisterPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex justify-content-center align-self-center");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card w-50");
            __builder.AddMarkupContent(4, "<h4 class=\"card-header\">Register</h4>\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(7);
            __builder.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label>Username</label>\n                    ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "type", "text");
                __builder2.AddAttribute(15, "placeholder", "Username");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\RegisterPage.razor"
                                                                                                _username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n                ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label>Password</label>\n                    ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "type", "Password");
                __builder2.AddAttribute(25, "placeholder", "Password");
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\RegisterPage.razor"
                                                                                                    _password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _password = __value, _password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "<label>Password</label>\n                    ");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "type", "Password");
                __builder2.AddAttribute(35, "placeholder", "Confirmation password");
                __builder2.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\RegisterPage.razor"
                                                                                                                 _confirmationPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _confirmationPassword = __value, _confirmationPassword));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n                ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "style", "color:red");
                __builder2.AddContent(41, 
#nullable restore
#line 26 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\RegisterPage.razor"
                                        _errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n                ");
                __builder2.OpenElement(43, "button");
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\RegisterPage.razor"
                                  PerformRegistration

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "class", " btn btn-primary mr-1");
                __builder2.AddAttribute(46, "href", "/LoginPage");
                __builder2.AddContent(47, "Register");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Dragos\Desktop\Downloads\DNP-AS-1-main\FamilyManager\FamilyManagerApp\Pages\RegisterPage.razor"
       
    private string _username;
    private string _password;
    private string _confirmationPassword;
    private string _errorMessage;

    private async Task PerformRegistration() {
        _errorMessage = "";
        try {
            ((CustomAuthenticationStateProvider)_authenticationStateProvider).ValidateRegister(_username, _password, _confirmationPassword);
            _username = "";
            _password = "";
            _navigationManager.NavigateTo("/LoginPage");
        }
        catch (Exception e) {
            _errorMessage = e.Message;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "G:\MyWebApplication\Chat\PrivateMessenger\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b9256a615490242aff26aa4ee46947aad758c14"
// <auto-generated/>
#pragma warning disable 1591
namespace PrivateMessenger.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\MyWebApplication\Chat\PrivateMessenger\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\MyWebApplication\Chat\PrivateMessenger\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\MyWebApplication\Chat\PrivateMessenger\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\MyWebApplication\Chat\PrivateMessenger\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\MyWebApplication\Chat\PrivateMessenger\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\MyWebApplication\Chat\PrivateMessenger\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\MyWebApplication\Chat\PrivateMessenger\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\MyWebApplication\Chat\PrivateMessenger\_Imports.razor"
using PrivateMessenger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\MyWebApplication\Chat\PrivateMessenger\_Imports.razor"
using PrivateMessenger.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\MyWebApplication\Chat\PrivateMessenger\_Imports.razor"
using PrivateMessenger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\MyWebApplication\Chat\PrivateMessenger\_Imports.razor"
using BlazorInputFile;

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
                __builder2.AddMarkupContent(2, "\r\n            ");
                __builder2.AddMarkupContent(3, @"<div class=""row mt-4"">
                <div class=""col-md-4"">
                    <div class=""card text-white bg-info mb-3 text-center"">
                        <div class=""card-header"">Login</div>
                        <div class=""card-body"">
                            <h1 class=""card-title""><a href=""/identity/account/login"" class=""text-light display-1""><i class=""bi bi-box-arrow-in-right""></i></a></h1>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""card text-white bg-success mb-3 text-center"">
                        <div class=""card-header"">Register</div>
                        <div class=""card-body"">
                            <h1 class=""card-title""><a href=""/register"" class=""text-light display-1""><i class=""bi bi-person-plus""></i></a></h1>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""card text-white bg-danger mb-3 text-center"">
                        <div class=""card-header"">About</div>
                        <div class=""card-body"">
                            <h1 class=""card-title""><a href=""/About"" class=""text-light display-1""><i class=""bi bi-question-lg""></i></a></h1>
                        </div>
                    </div>
                </div>
            </div>
        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(5);
            __builder.AddAttribute(6, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.AddMarkupContent(8, "<div class=\"row mt-4\">\r\n                <div class=\"col-lg-3 col-6-3 col-sm-6\">\r\n                    <div class=\"card shadow text-white bg-info mb-3 text-center\">\r\n                        <div class=\"card-header\">Reports</div>\r\n                        <div class=\"card-body\">\r\n                            <h1 class=\"card-title\"><a href=\"/reports\" class=\"text-light display-1\"><i class=\"bi bi-card-text\" aria-hidden=\"true\"></i></a></h1>\r\n                        </div>\r\n                        <div class=\"pb-5\">Any report</div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-3 col-6-3 col-sm-6\">\r\n                    <div class=\"card shadow text-white bg-success mb-3 text-center\">\r\n                        <div class=\"card-header\">Profile</div>\r\n                        <div class=\"card-body\">\r\n                            <h1 class=\"card-title\"><a href=\"/userprofile\" class=\"text-light display-1\"><i class=\"bi bi-person-lines-fill\"></i></a></h1>\r\n                        </div>\r\n                        <div class=\"pb-5\">Edit your profile</div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-3 col-6-3 col-sm-6\">\r\n                    <div class=\"card shadow text-white bg-danger mb-3 text-center\">\r\n                        <div class=\"card-header\">Find user</div>\r\n                        <div class=\"card-body\">\r\n                            <h1 class=\"card-title\"><a href=\"/allusers\" class=\"text-light display-1\"><i class=\"bi bi-search\"></i></a></h1>\r\n                        </div>\r\n                        <div class=\"pb-5\">Find user</div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-3 col-6-3 col-sm-6\">\r\n                    <div class=\"card shadow text-white bg-warning mb-3 text-center\">\r\n                        <div class=\"card-header\">Messages</div>\r\n                        <div class=\"card-body\">\r\n                            <h1 class=\"card-title\"><a href=\"/MessagesList\" class=\"text-light display-1\"><i class=\"bi bi-chat\"></i></a></h1>\r\n                        </div>\r\n                        <div class=\"pb-5\">List of messages</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

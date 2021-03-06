#pragma checksum "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2388eaeb156df2ca599f0c5b380d79e214fe3377"
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
#nullable restore
#line 3 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/allusers")]
    public partial class ChatMessage : ChatMessageBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "pt-5");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<h3>Search with email</h3>\r\n        ");
            __builder.AddMarkupContent(4, "<small class=\"text-secondary fw-light\">It shows all the profile users. So if you didn\'t create your profile, you should create it first.</small>\r\n\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row text-center");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-6 offset-md-3");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "input-group mb-3 mt-3");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "placeholder", "Search user name");
            __builder.AddAttribute(18, "aria-label", "Recipient\'s username");
            __builder.AddAttribute(19, "aria-describedby", "button-addon2");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                                                                          EmailForSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EmailForSearch = __value, EmailForSearch));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-outline-info");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                                                                   Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "<i class=\"bi bi-search\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        <hr>\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 19 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
             if (Loading == true)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                ");
            __builder.AddMarkupContent(35, @"<div class=""d-flex justify-content-center"">
                    <div class=""spinner-border"" style=""width: 3rem; height: 3rem;"" role=""status"">
                        <span class=""visually-hidden"">Loading...</span>
                    </div>
                </div>
");
#nullable restore
#line 26 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                 if (Message != null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                    ");
            __builder.OpenElement(37, "h2");
            __builder.AddAttribute(38, "class", "text-danger text-center");
            __builder.AddMarkupContent(39, "<i class=\"bi bi-exclamation-lg\"></i>");
            __builder.AddContent(40, 
#nullable restore
#line 31 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                                                                                             Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 32 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                     foreach (var item in identityUser)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-lg-4 col-md-6 col-sm-6 pb-3 pt-3");
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "card shadow text-center h-100");
            __builder.AddMarkupContent(48, "\r\n                                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card-body");
            __builder.AddMarkupContent(51, "\r\n                                    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "pb-3");
            __builder.AddMarkupContent(54, "\r\n                                        ");
            __builder.OpenElement(55, "img");
            __builder.AddAttribute(56, "src", "/UserProfile/" + (
#nullable restore
#line 41 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                                                                item.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "class", "img-fluid rounded-circle shadow");
            __builder.AddAttribute(58, "width", "120");
            __builder.AddAttribute(59, "height", "120");
            __builder.AddAttribute(60, "alt", 
#nullable restore
#line 41 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                                                                                                                                                   item.User.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                    ");
            __builder.OpenElement(63, "h6");
            __builder.AddAttribute(64, "class", "text-secondary fw-light");
            __builder.AddContent(65, 
#nullable restore
#line 43 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                                                                         item.User.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "card-footer");
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 47 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                                     if (item != null)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "                                        ");
            __builder.OpenElement(72, "a");
            __builder.AddAttribute(73, "href", "/chat/" + (
#nullable restore
#line 49 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                                                        item.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "class", "card-link float-left");
            __builder.AddAttribute(75, "title", "Chat");
            __builder.AddMarkupContent(76, "<i class=\"bi bi-chat-dots\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 50 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 52 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                                     if (item.Private == false)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                                        ");
            __builder.OpenElement(80, "a");
            __builder.AddAttribute(81, "href", "/viewuserdetails/" + (
#nullable restore
#line 54 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                                                                   item.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "class", "card-link text-decoration-none");
            __builder.AddAttribute(83, "title", "Details");
            __builder.AddMarkupContent(84, "<i class=\"bi bi-three-dots-vertical\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
#nullable restore
#line 55 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 59 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\ChatMessage.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

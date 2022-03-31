#pragma checksum "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c985662149d2959f4546b3b684d543cf28f667af"
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
#line 4 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
using PrivateMessenger.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userprofile")]
    public partial class UserProfile : UserProfileBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
 if (UserDetailsExist == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __Blazor.PrivateMessenger.Pages.UserProfile.TypeInference.CreateCascadingValue_0(__builder, 1, 2, 
#nullable restore
#line 7 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                           UserProfile

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<PrivateMessenger.Pages.UserProfileDetails>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 10 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
     if (Toast)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "h2");
            __builder.AddAttribute(10, "class", "text-center text-danger");
            __builder.AddContent(11, 
#nullable restore
#line 15 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                             Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 16 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "shadow");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "p-5");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(20);
            __builder.AddAttribute(21, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                 UserProfileForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                                 HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(25);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "row");
                __builder2.AddMarkupContent(29, "\r\n                        ");
                __builder2.AddMarkupContent(30, "<h3 class=\"text-secondary fw-lighter\">Your basic information</h3>\r\n                        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-md-4");
                __builder2.AddMarkupContent(33, "\r\n                            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "\r\n                                ");
                __builder2.AddMarkupContent(37, "<label for=\"firstName\" class=\"col-form-label\">First Name</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "id", "firstName");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "placeholder", "First name");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                                                                                     UserProfileForm.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserProfileForm.FirstName = __value, UserProfileForm.FirstName))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserProfileForm.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n                                ");
                __Blazor.PrivateMessenger.Pages.UserProfile.TypeInference.CreateValidationMessage_1(__builder2, 46, 47, 
#nullable restore
#line 29 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                          ()=>UserProfileForm.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-md-4");
                __builder2.AddMarkupContent(53, "\r\n                            ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddMarkupContent(56, "\r\n                                ");
                __builder2.AddMarkupContent(57, "<label for=\"lastName\" class=\"col-form-label\">Last Name</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "id", "lastName");
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "placeholder", "First name");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                                                                                    UserProfileForm.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserProfileForm.LastName = __value, UserProfileForm.LastName))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserProfileForm.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n                                ");
                __Blazor.PrivateMessenger.Pages.UserProfile.TypeInference.CreateValidationMessage_2(__builder2, 66, 67, 
#nullable restore
#line 36 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                          ()=>UserProfileForm.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(68, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                        ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "col-md-4");
                __builder2.AddMarkupContent(73, "\r\n                            ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group");
                __builder2.AddMarkupContent(76, "\r\n                                ");
                __builder2.AddMarkupContent(77, "<label for=\"age\" class=\"col-form-label\">Age</label>\r\n                                ");
                __Blazor.PrivateMessenger.Pages.UserProfile.TypeInference.CreateInputNumber_3(__builder2, 78, 79, "age", 80, "form-control", 81, "age", 82, 
#nullable restore
#line 42 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                                                                          UserProfileForm.Age

#line default
#line hidden
#nullable disable
                , 83, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserProfileForm.Age = __value, UserProfileForm.Age)), 84, () => UserProfileForm.Age);
                __builder2.AddMarkupContent(85, "\r\n                                ");
                __Blazor.PrivateMessenger.Pages.UserProfile.TypeInference.CreateValidationMessage_4(__builder2, 86, 87, 
#nullable restore
#line 43 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                          ()=>UserProfileForm.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(88, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                    <hr>\r\n                    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "row");
                __builder2.AddMarkupContent(94, "\r\n                        ");
                __builder2.AddMarkupContent(95, "<h3 class=\"text-secondary\">Bio and others Information</h3>\r\n                        ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col-md-6");
                __builder2.AddMarkupContent(98, "\r\n                            ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group");
                __builder2.AddMarkupContent(101, "\r\n                                ");
                __builder2.AddMarkupContent(102, "<label for=\"bio\" class=\"col-form-label\">Bio</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(103);
                __builder2.AddAttribute(104, "id", "bio");
                __builder2.AddAttribute(105, "class", "form-control");
                __builder2.AddAttribute(106, "placeholder", "bio");
                __builder2.AddAttribute(107, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                                                                            UserProfileForm.Bio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserProfileForm.Bio = __value, UserProfileForm.Bio))));
                __builder2.AddAttribute(109, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserProfileForm.Bio));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\r\n                                ");
                __Blazor.PrivateMessenger.Pages.UserProfile.TypeInference.CreateValidationMessage_5(__builder2, 111, 112, 
#nullable restore
#line 54 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                          ()=>UserProfileForm.Bio

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(113, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                        ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "col-md-6");
                __builder2.AddMarkupContent(118, "\r\n                            ");
                __builder2.OpenElement(119, "div");
                __builder2.AddAttribute(120, "class", "form-group");
                __builder2.AddMarkupContent(121, "\r\n                                ");
                __builder2.AddMarkupContent(122, "<label for=\"gender\" class=\"col-form-label\">Gender</label>\r\n                                ");
                __Blazor.PrivateMessenger.Pages.UserProfile.TypeInference.CreateInputSelect_6(__builder2, 123, 124, "gender", 125, "form-select", 126, 
#nullable restore
#line 60 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                          UserProfileForm.Gender

#line default
#line hidden
#nullable disable
                , 127, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserProfileForm.Gender = __value, UserProfileForm.Gender)), 128, () => UserProfileForm.Gender, 129, (__builder3) => {
                    __builder3.AddMarkupContent(130, "\r\n                                    ");
                    __builder3.AddMarkupContent(131, "<option value=\"Female\">Female</option>\r\n                                    ");
                    __builder3.AddMarkupContent(132, "<option value=\"Male\">Male</option>\r\n                                    ");
                    __builder3.AddMarkupContent(133, "<option value=\"Other\">Other</option>\r\n                                ");
                }
                );
                __builder2.AddMarkupContent(134, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\r\n                    <hr>\r\n                    ");
                __builder2.OpenElement(138, "div");
                __builder2.AddAttribute(139, "class", "row");
                __builder2.AddMarkupContent(140, "\r\n                        ");
                __builder2.AddMarkupContent(141, "<h3 class=\"text-secondary fw-light\"><i class=\"bi bi-lock-fill\"></i> Image and security</h3>\r\n                        <hr>\r\n                        ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "col-md-6");
                __builder2.AddMarkupContent(144, "\r\n                            ");
                __builder2.OpenElement(145, "div");
                __builder2.AddAttribute(146, "class", "form-group pt-3 pb-3");
                __builder2.AddMarkupContent(147, "\r\n                                ");
                __builder2.AddMarkupContent(148, "<p>\r\n                                    <small class=\"fw-light\">If you check Private, your account will be private and it will be invisibled</small>\r\n                                </p>\r\n                                ");
                __builder2.AddMarkupContent(149, "<label for=\"private\" class=\"form-check-label\">Private</label>\r\n\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(150);
                __builder2.AddAttribute(151, "id", "private");
                __builder2.AddAttribute(152, "class", "form-check-input");
                __builder2.AddAttribute(153, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 79 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                                                                  UserProfileForm.Private

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(154, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserProfileForm.Private = __value, UserProfileForm.Private))));
                __builder2.AddAttribute(155, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => UserProfileForm.Private));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(156, "\r\n                                ");
                __Blazor.PrivateMessenger.Pages.UserProfile.TypeInference.CreateValidationMessage_7(__builder2, 157, 158, 
#nullable restore
#line 80 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                          ()=>UserProfileForm.Private

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(159, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n                        ");
                __builder2.OpenElement(162, "div");
                __builder2.AddAttribute(163, "class", "col-md-6");
                __builder2.AddMarkupContent(164, "\r\n                            ");
                __builder2.OpenElement(165, "div");
                __builder2.AddAttribute(166, "class", "form-group");
                __builder2.AddMarkupContent(167, "\r\n                                ");
                __builder2.AddMarkupContent(168, "<label for=\"File\" class=\"col-form-label\">Image</label>\r\n                                ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(169);
                __builder2.AddAttribute(170, "id", "File");
                __builder2.AddAttribute(171, "class", "form-control");
                __builder2.AddAttribute(172, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 86 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
                                                                                    HandleFileSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(173, "\r\n\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(175, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(176, "\r\n                    ");
                __builder2.AddMarkupContent(177, "<div class=\"form-group pt-3 pb-3\">\r\n                        <button class=\"btn btn-primary\" type=\"submit\">Complete</button>\r\n                    </div>\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(178, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n");
#nullable restore
#line 97 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfile.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.PrivateMessenger.Pages.UserProfile
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
#pragma checksum "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "169d07747300981d14355c0968e7d26a839d9604"
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
#line 2 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userprofileedit")]
    public partial class UserProfileEdit : UserProfileEditBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "shadow");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "p-5");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                         UserProfileForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.AddMarkupContent(16, "<h3 class=\"text-secondary fw-lighter\">Your basic information</h3>\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-4");
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.AddMarkupContent(23, "<label for=\"firstName\" class=\"col-form-label\">First Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "id", "firstName");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "placeholder", "First name");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                                                                             UserProfileForm.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserProfileForm.FirstName = __value, UserProfileForm.FirstName))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserProfileForm.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __Blazor.PrivateMessenger.Pages.UserProfileEdit.TypeInference.CreateValidationMessage_0(__builder2, 32, 33, 
#nullable restore
#line 14 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                  ()=>UserProfileForm.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-md-4");
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.AddMarkupContent(43, "<label for=\"lastName\" class=\"col-form-label\">Last Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "lastName");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "placeholder", "First name");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                                                                            UserProfileForm.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserProfileForm.LastName = __value, UserProfileForm.LastName))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserProfileForm.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __Blazor.PrivateMessenger.Pages.UserProfileEdit.TypeInference.CreateValidationMessage_1(__builder2, 52, 53, 
#nullable restore
#line 21 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                  ()=>UserProfileForm.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-md-4");
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group");
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.AddMarkupContent(63, "<label for=\"age\" class=\"col-form-label\">Age</label>\r\n                        ");
                __Blazor.PrivateMessenger.Pages.UserProfileEdit.TypeInference.CreateInputNumber_2(__builder2, 64, 65, "age", 66, "form-control", 67, "age", 68, 
#nullable restore
#line 27 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                                                                  UserProfileForm.Age

#line default
#line hidden
#nullable disable
                , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserProfileForm.Age = __value, UserProfileForm.Age)), 70, () => UserProfileForm.Age);
                __builder2.AddMarkupContent(71, "\r\n                        ");
                __Blazor.PrivateMessenger.Pages.UserProfileEdit.TypeInference.CreateValidationMessage_3(__builder2, 72, 73, 
#nullable restore
#line 28 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                  ()=>UserProfileForm.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n            <hr>\r\n            ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "row");
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.AddMarkupContent(81, "<h3 class=\"text-secondary\">Bio and others Information</h3>\r\n                ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "col-md-6");
                __builder2.AddMarkupContent(84, "\r\n                    ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "form-group");
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.AddMarkupContent(88, "<label for=\"bio\" class=\"col-form-label\">Bio</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(89);
                __builder2.AddAttribute(90, "id", "bio");
                __builder2.AddAttribute(91, "class", "form-control");
                __builder2.AddAttribute(92, "placeholder", "bio");
                __builder2.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                                                                    UserProfileForm.Bio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserProfileForm.Bio = __value, UserProfileForm.Bio))));
                __builder2.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserProfileForm.Bio));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n                        ");
                __Blazor.PrivateMessenger.Pages.UserProfileEdit.TypeInference.CreateValidationMessage_4(__builder2, 97, 98, 
#nullable restore
#line 39 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                  ()=>UserProfileForm.Bio

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(99, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col-md-6");
                __builder2.AddMarkupContent(104, "\r\n                    ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "form-group");
                __builder2.AddMarkupContent(107, "\r\n                        ");
                __builder2.AddMarkupContent(108, "<label for=\"gender\" class=\"col-form-label\">Gender</label>\r\n                        ");
                __Blazor.PrivateMessenger.Pages.UserProfileEdit.TypeInference.CreateInputSelect_5(__builder2, 109, 110, "gender", 111, "form-select", 112, 
#nullable restore
#line 45 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                  UserProfileForm.Gender

#line default
#line hidden
#nullable disable
                , 113, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserProfileForm.Gender = __value, UserProfileForm.Gender)), 114, () => UserProfileForm.Gender, 115, (__builder3) => {
                    __builder3.AddMarkupContent(116, "\r\n                            ");
                    __builder3.AddMarkupContent(117, "<option value=\"Female\">Female</option>\r\n                            ");
                    __builder3.AddMarkupContent(118, "<option value=\"Male\">Male</option>\r\n                            ");
                    __builder3.AddMarkupContent(119, "<option value=\"Other\">Other</option>\r\n                        ");
                }
                );
                __builder2.AddMarkupContent(120, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n            <hr>\r\n            ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "row");
                __builder2.AddMarkupContent(126, "\r\n                ");
                __builder2.AddMarkupContent(127, "<h3 class=\"text-secondary fw-light\"><i class=\"bi bi-lock-fill\"></i> Image and security</h3>\r\n                ");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "col-md-6");
                __builder2.AddMarkupContent(130, "\r\n                    ");
                __builder2.OpenElement(131, "div");
                __builder2.AddAttribute(132, "class", "form-group pt-3 pb-3");
                __builder2.AddMarkupContent(133, "\r\n                        ");
                __builder2.AddMarkupContent(134, "<p>\r\n                            <small class=\"fw-light\">If you check Private, your account will be private and it will be invisibled</small>\r\n                        </p>\r\n                        ");
                __builder2.AddMarkupContent(135, "<label for=\"private\" class=\"form-check-label\">Private</label>\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(136);
                __builder2.AddAttribute(137, "id", "private");
                __builder2.AddAttribute(138, "class", "form-check-input");
                __builder2.AddAttribute(139, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 63 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                                                          UserProfileForm.Private

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(140, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserProfileForm.Private = __value, UserProfileForm.Private))));
                __builder2.AddAttribute(141, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => UserProfileForm.Private));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(142, "\r\n                        ");
                __Blazor.PrivateMessenger.Pages.UserProfileEdit.TypeInference.CreateValidationMessage_6(__builder2, 143, 144, 
#nullable restore
#line 64 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                  ()=>UserProfileForm.Private

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(145, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n                ");
                __builder2.OpenElement(148, "div");
                __builder2.AddAttribute(149, "class", "col-md-6");
                __builder2.AddMarkupContent(150, "\r\n                    ");
                __builder2.OpenElement(151, "div");
                __builder2.AddAttribute(152, "class", "form-group");
                __builder2.AddMarkupContent(153, "\r\n                        ");
                __builder2.AddMarkupContent(154, "<label for=\"File\" class=\"col-form-label\">Image</label>\r\n                        ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(155);
                __builder2.AddAttribute(156, "id", "File");
                __builder2.AddAttribute(157, "class", "form-control");
                __builder2.AddAttribute(158, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 70 "G:\MyWebApplication\Chat\PrivateMessenger\Pages\UserProfileEdit.razor"
                                                                            HandleFileSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(159, "\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n\r\n\r\n\r\n\r\n            ");
                __builder2.AddMarkupContent(163, "<div class=\"form-group pt-3 pb-3\">\r\n                <button class=\"btn btn-warning shadow\" type=\"submit\">Edit Profile</button>\r\n            </div>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(164, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.PrivateMessenger.Pages.UserProfileEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
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
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
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
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e49331b294784147ebe4856b16808a448264446"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_IsEmri_GorevlendirPersonel), @"mvc.1.0.view", @"/Areas/Admin/Views/IsEmri/GorevlendirPersonel.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\_ViewImports.cshtml"
using IsTakip.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e49331b294784147ebe4856b16808a448264446", @"/Areas/Admin/Views/IsEmri/GorevlendirPersonel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d39be6dd7bcabd4e5eb63ac987c09a35506c573", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_IsEmri_GorevlendirPersonel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonelGorevlendirListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtaPersonel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::IsTakip.Web.TagHalpers.GorevAppUserIdTagHelper __IsTakip_Web_TagHalpers_GorevAppUserIdTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
  
    ViewData["Title"] = "GorevlendirPersonel";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e49331b294784147ebe4856b16808a4482644464817", async() => {
                WriteLiteral(@"
            <blockquote class=""blockquote text-center"">

                <p class=""lead text-center"">
                    Aşağıdaki göreve ilgili personel atanacaktır,
                    bu işlemi gerçekleştirmek istediğinizden emin misiniz?
                </p>

                <div class=""form-group text-center"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e49331b294784147ebe4856b16808a4482644465426", async() => {
                    WriteLiteral("Hayır, vazgeç");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                                  WriteLiteral(Model.Gorev.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    <input type=\"hidden\" name=\"PersonelId\"");
                BeginWriteAttribute("value", " value=\"", 775, "\"", 800, 1);
#nullable restore
#line 21 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
WriteAttributeValue("", 783, Model.AppUser.Id, 783, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"GorevId\"");
                BeginWriteAttribute("value", " value=\"", 861, "\"", 884, 1);
#nullable restore
#line 22 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
WriteAttributeValue("", 869, Model.Gorev.Id, 869, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Evet, görevlendir</button>\r\n                </div>\r\n\r\n            </blockquote>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <div class=""col md-4 m-5 d-flex justify-content-center"">
            <div class=""col-md-4 m-1"">

                <div class=""card border border-primary"">
                    <div class=""card-header"">
                        <h3 class=""text-center lead pt-2""> Görev Bilgileri</h3>
                    </div>

                    <div class=""card-body"">

                        <h5 class=""card-title"">");
#nullable restore
#line 40 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                          Write(Model.Gorev.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                        <p class=\"card-text\">");
#nullable restore
#line 42 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                        Write(Model.Gorev.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        <p class=\"card-text\">\r\n                            <strong> Aciliyet Durumu: </strong>\r\n\r\n                            <span class=\"badge badge-primary\">");
#nullable restore
#line 47 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                                         Write(Model.Gorev.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </p>

                    </div>

                </div>
            </div>
        </div>
    </div>
    <div class=""col md-8 m-2"">


        <div class=""card border border-primary mb-3 shadow"">
            <div class=""card-header"">
                <h3 class=""text-center lead""> Personel Bilgileri</h3>
            </div>
            <div class=""row g-0"">
                <div class=""col-md-4"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 2247, "\"", 2280, 2);
            WriteAttributeValue("", 2253, "/img/", 2253, 5, true);
#nullable restore
#line 65 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
WriteAttributeValue("", 2258, Model.AppUser.Picture, 2258, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img w-50 m-5\"");
            BeginWriteAttribute("alt", " alt=\"", 2307, "\"", 2332, 1);
#nullable restore
#line 65 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
WriteAttributeValue("", 2313, Model.AppUser.Name, 2313, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n\r\n                        <h5 class=\"card-title pt-xl-3\" style=\"font-size:x-large\">");
#nullable restore
#line 70 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                                                            Write(Model.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 70 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                                                                                Write(Model.AppUser.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                        <p class=\"card-text\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getirGorevAppUserId", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e49331b294784147ebe4856b16808a44826444614225", async() => {
                WriteLiteral(" ");
            }
            );
            __IsTakip_Web_TagHalpers_GorevAppUserIdTagHelper = CreateTagHelper<global::IsTakip.Web.TagHalpers.GorevAppUserIdTagHelper>();
            __tagHelperExecutionContext.Add(__IsTakip_Web_TagHalpers_GorevAppUserIdTagHelper);
#nullable restore
#line 73 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
__IsTakip_Web_TagHalpers_GorevAppUserIdTagHelper.AppUserId = Model.AppUser.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("app-user-id", __IsTakip_Web_TagHalpers_GorevAppUserIdTagHelper.AppUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </p>\r\n\r\n                        <p class=\"card-text\">\r\n                            <small class=\"text-muted\">");
#nullable restore
#line 77 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                                 Write(Model.AppUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonelGorevlendirListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf7e2da382a26337ae935ada48c8a5da3523241e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Gorev_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Gorev/Index.cshtml")]
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
#line 2 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\_ViewImports.cshtml"
using IsTakip.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf7e2da382a26337ae935ada48c8a5da3523241e", @"/Areas/Member/Views/Gorev/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e94ef3c139b7c04484293e3588428a8ad08dcc42", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Gorev_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GorevListAllViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
 foreach (var gorev in Model)
{
    index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card m-3\">\r\n\r\n        <div class=\"card-header\">\r\n            ");
#nullable restore
#line 14 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
       Write(gorev.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n\r\n            <h5 class=\"card-title\">\r\n                <span class=\"text-danger\">");
#nullable restore
#line 20 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
                                     Write(gorev.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </h5>\r\n\r\n            <p class=\"card-text\">");
#nullable restore
#line 23 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
                            Write(gorev.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <p class=\"text-right\">\r\n\r\n");
#nullable restore
#line 27 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
                 if (gorev.Raporlar.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-outline-primary btn-sm\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 729, "\"", 759, 2);
            WriteAttributeValue("", 736, "#collapseExample-", 736, 17, true);
#nullable restore
#line 29 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
WriteAttributeValue("", 753, index, 753, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                       role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
                        Raporlara Git <i class=""fas fa-caret-down mx-1""></i>
                        <span class=""badge badge-primary p-1"" style=""font-size:12px;"">");
#nullable restore
#line 32 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
                                                                                 Write(gorev.Raporlar.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n");
#nullable restore
#line 34 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n            <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1149, "\"", 1176, 2);
            WriteAttributeValue("", 1154, "collapseExample-", 1154, 16, true);
#nullable restore
#line 38 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
WriteAttributeValue("", 1170, index, 1170, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                <table class=""table table-hover table-bordered table-sm"">
                    <thead class=""table table-striped table-active"">
                        <tr>
                            <th scope=""col"">Tanım</th>
                            <th scope=""col"">Detay</th>
                        </tr>
                    </thead>
");
#nullable restore
#line 47 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
                     foreach (var rapor in gorev.Raporlar)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 50 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
                           Write(rapor.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
                           Write(rapor.Detay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"btn-toolbar float-right\" role=\"toolbar\" aria-label=\"Toolbar with button groups\">\r\n\r\n");
#nullable restore
#line 64 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
     for (int i = 1; i <= ViewBag.ToplamSayfa; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 2050, "\"", 2109, 3);
            WriteAttributeValue("", 2058, "btn-group", 2058, 9, true);
            WriteAttributeValue(" ", 2067, "mr-2", 2068, 5, true);
#nullable restore
#line 66 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
WriteAttributeValue(" ", 2072, ViewBag.AktifSayfa==i?"active":"", 2073, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"group\" aria-label=\"First group\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf7e2da382a26337ae935ada48c8a5da3523241e10694", async() => {
#nullable restore
#line 68 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
                                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-aktifSayfa", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"
                                                                                                       WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["aktifSayfa"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-aktifSayfa", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["aktifSayfa"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 70 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Member\Views\Gorev\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GorevListAllViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69ebd1dfdd64e26e25635a058ef5904f1d7e66a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SallesRecords_SimpleSearch), @"mvc.1.0.view", @"/Views/SallesRecords/SimpleSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SallesRecords/SimpleSearch.cshtml", typeof(AspNetCore.Views_SallesRecords_SimpleSearch))]
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
#line 1 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\_ViewImports.cshtml"
using SalesWebMvc1;

#line default
#line hidden
#line 2 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\_ViewImports.cshtml"
using SalesWebMvc1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69ebd1dfdd64e26e25635a058ef5904f1d7e66a8", @"/Views/SallesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25721e4ef2c72d1f9e6f9a347e5857a2fb31a297", @"/Views/_ViewImports.cshtml")]
    public class Views_SallesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvc1.Models.SallesRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
  
    ViewData["Title"] = "Simple Search";

#line default
#line hidden
            BeginContext(105, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(112, 17, false);
#line 7 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(129, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(218, 664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2114ec25a88e4c8f8fefdafe1e971146", async() => {
                BeginContext(270, 215, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 485, "", 512, 1);
#line 15 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 492, ViewData["minDate"], 492, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(512, 204, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 716, "", 743, 1);
#line 19 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 723, ViewData["maxDate"], 723, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(743, 132, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(882, 136, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Total sales = ");
            EndContext();
            BeginContext(1019, 43, false);
#line 28 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                                         Write(Model.Sum(obj => obj.Amount).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 215, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1278, 38, false);
#line 35 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1396, 40, false);
#line 38 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1516, 42, false);
#line 41 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1638, 53, false);
#line 44 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1771, 42, false);
#line 47 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1813, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1893, 42, false);
#line 50 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 55 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2095, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2180, 37, false);
#line 59 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2217, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2309, 39, false);
#line 62 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2348, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2440, 46, false);
#line 65 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2486, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2578, 57, false);
#line 68 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2635, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2727, 41, false);
#line 71 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2768, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2860, 41, false);
#line 74 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2901, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 77 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\SimpleSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(2980, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvc1.Models.SallesRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591

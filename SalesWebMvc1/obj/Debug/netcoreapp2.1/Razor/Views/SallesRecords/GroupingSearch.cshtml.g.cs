#pragma checksum "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff9627ed6c631435bbfe0afb37b841ef7a9921d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SallesRecords_GroupingSearch), @"mvc.1.0.view", @"/Views/SallesRecords/GroupingSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SallesRecords/GroupingSearch.cshtml", typeof(AspNetCore.Views_SallesRecords_GroupingSearch))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff9627ed6c631435bbfe0afb37b841ef7a9921d3", @"/Views/SallesRecords/GroupingSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25721e4ef2c72d1f9e6f9a347e5857a2fb31a297", @"/Views/_ViewImports.cshtml")]
    public class Views_SallesRecords_GroupingSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Department, SallesRecord>>>
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
  
    ViewData["Title"] = "Grouping Search";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
            BeginContext(252, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(259, 17, false);
#line 9 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(276, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(365, 660, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85198f2d5eb6481699e5400c80905fe3", async() => {
                BeginContext(417, 215, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 632, "", 659, 1);
#line 17 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 639, ViewData["minDate"], 639, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(659, 202, true);
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 861, "", 888, 1);
#line 21 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 868, ViewData["maxDate"], 868, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(888, 130, true);
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
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
            BeginContext(1025, 24, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n");
            EndContext();
#line 29 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
 foreach (var departmentGroup in Model)
{

#line default
#line hidden
            BeginContext(1093, 123, true);
            WriteLiteral("    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"panel-title\">Department ");
            EndContext();
            BeginContext(1217, 24, false);
#line 33 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
                                          Write(departmentGroup.Key.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1241, 16, true);
            WriteLiteral(", Total sales = ");
            EndContext();
            BeginContext(1258, 63, false);
#line 33 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
                                                                                   Write(departmentGroup.Key.TotalSales(minDate, maxDate).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 649, true);
            WriteLiteral(@"</h3>
        </div>
        <div class=""panel-body"">
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr class=""success"">
                        <th>
                            Date
                        </th>
                        <th>
                            Amount
                        </th>
                        <th>
                            Seller
                        </th>
                        <th>
                            Status
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 54 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
                     foreach (var item in departmentGroup)
                    {

#line default
#line hidden
            BeginContext(2053, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2150, 39, false);
#line 58 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2189, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2293, 41, false);
#line 61 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2334, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2438, 46, false);
#line 64 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2484, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2588, 41, false);
#line 67 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2629, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 70 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
                    }

#line default
#line hidden
            BeginContext(2720, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 75 "C:\Users\Henri\source\repos\SalesWebMvc1\SalesWebMvc1\Views\SallesRecords\GroupingSearch.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Department, SallesRecord>>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f3524e143e6968747e025cfbee054b761729528"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publishers_Index), @"mvc.1.0.view", @"/Views/Publishers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Publishers/Index.cshtml", typeof(AspNetCore.Views_Publishers_Index))]
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
#line 1 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\_ViewImports.cshtml"
using SecretaryWebMvc;

#line default
#line hidden
#line 2 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\_ViewImports.cshtml"
using SecretaryWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3524e143e6968747e025cfbee054b761729528", @"/Views/Publishers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22002530ff7f7cd14248cf44b91a24747a38339f", @"/Views/_ViewImports.cshtml")]
    public class Views_Publishers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SecretaryWebMvc.Models.Publisher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
  
    ViewData["Title"] = "Publishers";

#line default
#line hidden
            BeginContext(106, 9, true);
            WriteLiteral("\r\n\r\n<h2> ");
            EndContext();
            BeginContext(116, 17, false);
#line 10 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(133, 18, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(151, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d6cd701727f497f87c426c5afd99419", async() => {
                BeginContext(194, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(208, 138, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table table-striped table-hover\">\r\n\r\n    <thead>\r\n        <tr class=\"success\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(347, 44, false);
#line 21 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(391, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(447, 49, false);
#line 24 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SimpleAddress));

#line default
#line hidden
            EndContext();
            BeginContext(496, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(552, 45, false);
#line 27 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(597, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(653, 46, false);
#line 30 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsAnointed));

#line default
#line hidden
            EndContext();
            BeginContext(699, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(755, 43, false);
#line 33 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsElder));

#line default
#line hidden
            EndContext();
            BeginContext(798, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(854, 56, false);
#line 36 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsMinisterialServant));

#line default
#line hidden
            EndContext();
            BeginContext(910, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(966, 45, false);
#line 39 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ispioneer));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1067, 47, false);
#line 42 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BaptismDate));

#line default
#line hidden
            EndContext();
            BeginContext(1114, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1170, 48, false);
#line 45 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Congregation));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 100, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1367, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1428, 35, false);
#line 56 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
               Write(Html.DisplayFor(x => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1463, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1531, 40, false);
#line 59 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
               Write(Html.DisplayFor(x => item.SimpleAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1639, 36, false);
#line 62 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
               Write(Html.DisplayFor(x => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1675, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1743, 38, false);
#line 65 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
               Write(Html.DisplayFor(x => item.BaptismDate));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
            EndContext();
            BeginContext(1864, 37, false);
#line 68 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
               Write(Html.DisplayFor(x => item.IsAnointed));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
            EndContext();
            BeginContext(1984, 34, false);
#line 71 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
               Write(Html.DisplayFor(x => item.IsElder));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
            EndContext();
            BeginContext(2101, 47, false);
#line 74 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
               Write(Html.DisplayFor(x => item.IsMinisterialServant));

#line default
#line hidden
            EndContext();
            BeginContext(2148, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
            EndContext();
            BeginContext(2231, 36, false);
#line 77 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
               Write(Html.DisplayFor(x => item.Ispioneer));

#line default
#line hidden
            EndContext();
            BeginContext(2267, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2335, 44, false);
#line 80 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
               Write(Html.DisplayFor(x => item.Congregation.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2379, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2446, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b0fd6e6efef4fa19d5d8aacb4b17b16", async() => {
                BeginContext(2491, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2499, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2521, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dccddd315174412197139995e26390fe", async() => {
                BeginContext(2569, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2580, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2602, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bb2f705aa084c1eab0783ab74696fe7", async() => {
                BeginContext(2649, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2659, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 88 "C:\Users\Henri\source\repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2714, 24, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SecretaryWebMvc.Models.Publisher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
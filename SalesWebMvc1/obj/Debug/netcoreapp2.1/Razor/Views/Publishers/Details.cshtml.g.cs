#pragma checksum "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1be1ea69caaaface7fc4c494cdd65fd51a84290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publishers_Details), @"mvc.1.0.view", @"/Views/Publishers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Publishers/Details.cshtml", typeof(AspNetCore.Views_Publishers_Details))]
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
#line 1 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\_ViewImports.cshtml"
using SecretaryWebMvc;

#line default
#line hidden
#line 2 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\_ViewImports.cshtml"
using SecretaryWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1be1ea69caaaface7fc4c494cdd65fd51a84290", @"/Views/Publishers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22002530ff7f7cd14248cf44b91a24747a38339f", @"/Views/_ViewImports.cshtml")]
    public class Views_Publishers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SecretaryWebMvc.Models.Publisher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 48, true);
            WriteLiteral("<h2>Detalhes</h2>\r\n\r\n<div>\r\n    <h4>Publicador: ");
            EndContext();
            BeginContext(135, 40, false);
#line 9 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Details.cshtml"
               Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(175, 141, true);
            WriteLiteral("</h4>\r\n\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            <label>Nome</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(317, 40, false);
#line 17 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(357, 109, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Endereço</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(467, 45, false);
#line 23 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Details.cshtml"
       Write(Html.DisplayFor(model => model.SimpleAddress));

#line default
#line hidden
            EndContext();
            BeginContext(512, 116, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Data Nascimento</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(629, 41, false);
#line 29 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Details.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(670, 113, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Data Batismo</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(784, 43, false);
#line 35 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Details.cshtml"
       Write(Html.DisplayFor(model => model.BaptismDate));

#line default
#line hidden
            EndContext();
            BeginContext(827, 107, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Ungido</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(935, 42, false);
#line 41 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsAnointed));

#line default
#line hidden
            EndContext();
            BeginContext(977, 107, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Ancião</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1085, 39, false);
#line 47 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsElder));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 118, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Servo Ministerial</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1243, 52, false);
#line 53 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsMinisterialServant));

#line default
#line hidden
            EndContext();
            BeginContext(1295, 109, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Pioneiro</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1405, 41, false);
#line 59 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ispioneer));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1493, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1be1ea69caaaface7fc4c494cdd65fd51a842908676", async() => {
                BeginContext(1563, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 64 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\Publishers\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1571, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SecretaryWebMvc.Models.Publisher> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "335d5894fdce8c9447ba1b2e22dbad0d9ce24108"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ActivitiesReports_Delete), @"mvc.1.0.view", @"/Views/ActivitiesReports/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ActivitiesReports/Delete.cshtml", typeof(AspNetCore.Views_ActivitiesReports_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335d5894fdce8c9447ba1b2e22dbad0d9ce24108", @"/Views/ActivitiesReports/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22002530ff7f7cd14248cf44b91a24747a38339f", @"/Views/_ViewImports.cshtml")]
    public class Views_ActivitiesReports_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SecretaryWebMvc.Models.ActivitiesReport>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml"
  
    ViewData["Title"] = "Deletar";

#line default
#line hidden
            BeginContext(93, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(100, 17, false);
#line 7 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(117, 97, true);
            WriteLiteral("</h2>\r\n\r\n<h3>\r\n    Você realmente deseja excluir estas atividades relacionada ao publicador\r\n    ");
            EndContext();
            BeginContext(215, 50, false);
#line 11 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml"
Write(Html.DisplayFor(model => model.Publisher.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(265, 157, true);
            WriteLiteral("?\r\n</h3>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            <label>Publicador</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(423, 50, false);
#line 21 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Publisher.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(473, 112, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Publicações</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(586, 44, false);
#line 27 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Publications));

#line default
#line hidden
            EndContext();
            BeginContext(630, 107, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Videos</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(738, 37, false);
#line 33 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Video));

#line default
#line hidden
            EndContext();
            BeginContext(775, 106, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Horas</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(882, 37, false);
#line 39 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hours));

#line default
#line hidden
            EndContext();
            BeginContext(919, 110, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Revisitas</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1030, 40, false);
#line 45 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Revisits));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 108, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Estudos</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1179, 44, false);
#line 51 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BibleStudies));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 117, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Horas Adicionais</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1341, 41, false);
#line 57 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PlusHours));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 112, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Observações</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1495, 43, false);
#line 63 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Observation));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 78, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Mês</label>\r\n        </dt>\r\n");
            EndContext();
            BeginContext(1706, 17, true);
            WriteLiteral("    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1723, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "335d5894fdce8c9447ba1b2e22dbad0d9ce241089989", async() => {
                BeginContext(1749, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1759, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "335d5894fdce8c9447ba1b2e22dbad0d9ce2410810381", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 74 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1795, 81, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n        ");
                EndContext();
                BeginContext(1876, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "335d5894fdce8c9447ba1b2e22dbad0d9ce2410812300", async() => {
                    BeginContext(1898, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1914, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1927, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SecretaryWebMvc.Models.ActivitiesReport> Html { get; private set; }
    }
}
#pragma warning restore 1591

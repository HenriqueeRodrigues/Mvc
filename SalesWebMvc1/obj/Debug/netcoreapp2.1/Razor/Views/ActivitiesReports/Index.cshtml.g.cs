#pragma checksum "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd854fd10d0bf1f6c1fe226c5c6049c7a378def3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ActivitiesReports_Index), @"mvc.1.0.view", @"/Views/ActivitiesReports/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ActivitiesReports/Index.cshtml", typeof(AspNetCore.Views_ActivitiesReports_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd854fd10d0bf1f6c1fe226c5c6049c7a378def3", @"/Views/ActivitiesReports/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22002530ff7f7cd14248cf44b91a24747a38339f", @"/Views/_ViewImports.cshtml")]
    public class Views_ActivitiesReports_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SecretaryWebMvc.Models.ActivitiesReport>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default bg-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SumAssistance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBatch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link alert-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
  
    ViewData["Title"] = "Atividades Ministeriais";

#line default
#line hidden
            BeginContext(120, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(127, 17, false);
#line 6 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(144, 34, true);
            WriteLiteral("</h2>\r\n\r\n<br />\r\n<br />\r\n<p>\r\n    ");
            EndContext();
            BeginContext(178, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd854fd10d0bf1f6c1fe226c5c6049c7a378def38155", async() => {
                BeginContext(236, 20, true);
                WriteLiteral("Adicionar Atividades");
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
            BeginContext(260, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(266, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd854fd10d0bf1f6c1fe226c5c6049c7a378def39626", async() => {
                BeginContext(331, 19, true);
                WriteLiteral("Assistência Reunião");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(354, 61, true);
            WriteLiteral("\r\n</p>\r\n<br />\r\n<br />\r\n\r\n<div class=\"container-fluid\">\r\n    ");
            EndContext();
            BeginContext(415, 570, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd854fd10d0bf1f6c1fe226c5c6049c7a378def311165", async() => {
                BeginContext(486, 492, true);
                WriteLiteral(@"
        <div class=""form-group"">
            <div class=""form-group"">
                <label>Pesquise por Mês</label>
                <input type=""month"" class=""form-control"" name=""Date"" id=""Date"" style=""margin-left: 20px;"" />
            </div>
        </div>
        <button type=""submit"" class=""btn btn-default"" style=""margin-left: 15px;"">Buscar</button>
        <button type=""submit"" class=""btn btn-primary"" style=""margin-left: 30px;"">Voltar com todos os registros</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(985, 909, true);
            WriteLiteral(@"
</div>
<br />

<table class=""table table-striped table-hover"">

    <thead>
        <tr class=""btn-primary bg-success"">
            <th>
                <label>Nome</label>
            </th>
            <th>
                <label>Publicações</label>
            </th>
            <th>
                <label>Video</label>
            </th>
            <th>
                <label>Horas</label>
            </th>
            <th>
                <label>Revisitas</label>
            </th>
            <th>
                <label>Estudos</label>
            </th>
            <th>
                <label>Horas Adicionais</label>
            </th>
            <th>
                <label>Observações</label>
            </th>
            <th>
                <label>Mês</label>
            </th>
            <th>
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 67 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1943, 75, true);
            WriteLiteral("            <tr>\r\n                <td align=\"center\">\r\n                    ");
            EndContext();
            BeginContext(2019, 45, false);
#line 71 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
               Write(Html.DisplayFor(x => item.Publisher.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2064, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
            EndContext();
            BeginContext(2147, 39, false);
#line 74 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
               Write(Html.DisplayFor(x => item.Publications));

#line default
#line hidden
            EndContext();
            BeginContext(2186, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
            EndContext();
            BeginContext(2269, 32, false);
#line 77 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
               Write(Html.DisplayFor(x => item.Video));

#line default
#line hidden
            EndContext();
            BeginContext(2301, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
            EndContext();
            BeginContext(2384, 32, false);
#line 80 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
               Write(Html.DisplayFor(x => item.Hours));

#line default
#line hidden
            EndContext();
            BeginContext(2416, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
            EndContext();
            BeginContext(2499, 35, false);
#line 83 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
               Write(Html.DisplayFor(x => item.Revisits));

#line default
#line hidden
            EndContext();
            BeginContext(2534, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
            EndContext();
            BeginContext(2617, 39, false);
#line 86 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
               Write(Html.DisplayFor(x => item.BibleStudies));

#line default
#line hidden
            EndContext();
            BeginContext(2656, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
            EndContext();
            BeginContext(2739, 36, false);
#line 89 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
               Write(Html.DisplayFor(x => item.PlusHours));

#line default
#line hidden
            EndContext();
            BeginContext(2775, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
            EndContext();
            BeginContext(2858, 38, false);
#line 92 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
               Write(Html.DisplayFor(x => item.Observation));

#line default
#line hidden
            EndContext();
            BeginContext(2896, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 95 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                     if (item.Date.Month == 1)
                    {
                        

#line default
#line hidden
            BeginContext(3039, 27, false);
#line 97 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                   Write(Html.DisplayName("Janeiro"));

#line default
#line hidden
            EndContext();
#line 97 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                                                    
                    }

#line default
#line hidden
#line 99 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                     if (item.Date.Month == 2)
                    {
                        

#line default
#line hidden
            BeginContext(3187, 29, false);
#line 101 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                   Write(Html.DisplayName("Fevereiro"));

#line default
#line hidden
            EndContext();
#line 101 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                                                      
                    }

#line default
#line hidden
#line 103 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                     if (item.Date.Month == 3)
                    {
                        

#line default
#line hidden
            BeginContext(3337, 25, false);
#line 105 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                   Write(Html.DisplayName("Março"));

#line default
#line hidden
            EndContext();
#line 105 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                                                  
                    }

#line default
#line hidden
#line 107 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                     if (item.Date.Month == 4)
                    {
                        

#line default
#line hidden
            BeginContext(3483, 25, false);
#line 109 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                   Write(Html.DisplayName("Abril"));

#line default
#line hidden
            EndContext();
#line 109 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                                                  
                    }

#line default
#line hidden
#line 111 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                     if (item.Date.Month == 5)
                    {
                        

#line default
#line hidden
            BeginContext(3629, 24, false);
#line 113 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                   Write(Html.DisplayName("Maio"));

#line default
#line hidden
            EndContext();
#line 113 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                                                 
                    }

#line default
#line hidden
#line 115 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                     if (item.Date.Month == 6)
                    {
                        

#line default
#line hidden
            BeginContext(3774, 25, false);
#line 117 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                   Write(Html.DisplayName("Junho"));

#line default
#line hidden
            EndContext();
#line 117 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                                                  
                    }

#line default
#line hidden
#line 119 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                     if (item.Date.Month == 7)
                    {
                        

#line default
#line hidden
            BeginContext(3920, 25, false);
#line 121 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                   Write(Html.DisplayName("Julho"));

#line default
#line hidden
            EndContext();
#line 121 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                                                  
                    }

#line default
#line hidden
#line 123 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                     if (item.Date.Month == 8)
                    {
                        

#line default
#line hidden
            BeginContext(4066, 26, false);
#line 125 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                   Write(Html.DisplayName("Agosto"));

#line default
#line hidden
            EndContext();
#line 125 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                                                   
                    }

#line default
#line hidden
#line 127 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                     if (item.Date.Month == 9)
                    {
                        

#line default
#line hidden
            BeginContext(4213, 28, false);
#line 129 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                   Write(Html.DisplayName("Setembro"));

#line default
#line hidden
            EndContext();
#line 129 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                                                     
                    }

#line default
#line hidden
#line 131 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                     if (item.Date.Month == 10)
                    {
                        

#line default
#line hidden
            BeginContext(4363, 27, false);
#line 133 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                   Write(Html.DisplayName("Outubro"));

#line default
#line hidden
            EndContext();
#line 133 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                                                    
                    }

#line default
#line hidden
#line 135 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                     if (item.Date.Month == 11)
                    {
                        

#line default
#line hidden
            BeginContext(4512, 28, false);
#line 137 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                   Write(Html.DisplayName("Novembro"));

#line default
#line hidden
            EndContext();
#line 137 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                                                     
                    }

#line default
#line hidden
#line 139 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                     if (item.Date.Month == 12)
                    {
                        

#line default
#line hidden
            BeginContext(4662, 28, false);
#line 141 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                   Write(Html.DisplayName("Dezembro"));

#line default
#line hidden
            EndContext();
#line 141 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
                                                     
                    }

#line default
#line hidden
            BeginContext(4715, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4780, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd854fd10d0bf1f6c1fe226c5c6049c7a378def327161", async() => {
                BeginContext(4825, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 145 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
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
            BeginContext(4833, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(4855, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd854fd10d0bf1f6c1fe226c5c6049c7a378def329528", async() => {
                BeginContext(4903, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 146 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
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
            BeginContext(4914, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(4936, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd854fd10d0bf1f6c1fe226c5c6049c7a378def331901", async() => {
                BeginContext(4983, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 147 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
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
            BeginContext(4993, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 150 "C:\Users\Henri\source\Repos\SecretaryWebMvc\SalesWebMvc1\Views\ActivitiesReports\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(5048, 37, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(5085, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd854fd10d0bf1f6c1fe226c5c6049c7a378def334596", async() => {
                BeginContext(5160, 49, true);
                WriteLiteral("Excluir todos registros anteriores a 1 ano atrás.");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5213, 6, true);
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SecretaryWebMvc.Models.ActivitiesReport>> Html { get; private set; }
    }
}
#pragma warning restore 1591

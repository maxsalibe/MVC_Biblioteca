#pragma checksum "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d853a73149c3c49b57aee27e1cf51b67ca5aa383"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LectorSelector_Index), @"mvc.1.0.view", @"/Views/LectorSelector/Index.cshtml")]
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
#line 1 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d853a73149c3c49b57aee27e1cf51b67ca5aa383", @"/Views/LectorSelector/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_LectorSelector_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Biblioteca.Modelo.Lector>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("LectorSelector"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
  
    ViewData["Title"] = "Lista de lectores suscriptos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de lectores disponibles</h1>\r\n\r\n<div>\r\n");
#nullable restore
#line 10 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
     if (ViewBag.libro != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Indique el lector que retirar?? el libro</h4>\r\n        <hr />\r\n        <div class=\"d-inline\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d853a73149c3c49b57aee27e1cf51b67ca5aa3834649", async() => {
                WriteLiteral("\r\n                <input name=\"nombre\" class=\"form-control\" /><button type=\"submit\" class=\"btn btn-primary\">Buscar</button>\r\n            ");
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
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <hr />\r\n        <h4>Libro que estas reservando</h4>\r\n        <div class=\"card\" style=\"width: 18rem;\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 670, "\"", 711, 2);
            WriteAttributeValue("", 676, "/imagenes/", 676, 10, true);
#nullable restore
#line 23 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
WriteAttributeValue("", 686, ViewBag.libro.rutaimagen, 686, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 712, "\"", 739, 1);
#nullable restore
#line 23 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
WriteAttributeValue("", 718, ViewBag.libro.titulo, 718, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 25 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
                                  Write(ViewBag.libro.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <hr />

    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Apellido
                </th>
                <th>
                    Nombre
                </th>
                <th>
                    Domicilio
                </th>
                <th>
                    Acci??n
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 49 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
             foreach (var lector in ViewBag.lectores)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
                   Write(lector.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
                   Write(lector.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
                   Write(lector.Domicilio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 62 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
                         if (ViewBag.libro != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1829, "\"", 1900, 4);
            WriteAttributeValue("", 1836, "../prestamo?lector=", 1836, 19, true);
#nullable restore
#line 64 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
WriteAttributeValue("", 1855, lector.lectorId, 1855, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1871, "&libro=", 1871, 7, true);
#nullable restore
#line 64 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
WriteAttributeValue("", 1878, ViewBag.libro.libroId, 1878, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Seleccionar</a>\r\n");
#nullable restore
#line 65 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
                         if (ViewBag.libro == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 2056, "\"", 2114, 2);
            WriteAttributeValue("", 2063, "../prestamo/LibrosPrestados?lector=", 2063, 35, true);
#nullable restore
#line 68 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
WriteAttributeValue("", 2098, lector.lectorId, 2098, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Seleccionar</a>\r\n");
#nullable restore
#line 69 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 72 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\LectorSelector\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Biblioteca.Modelo.Lector> Html { get; private set; }
    }
}
#pragma warning restore 1591

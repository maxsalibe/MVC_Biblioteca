#pragma checksum "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "124cff7ffedbb12d9a0dad5ecc072785d399a6be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prestamo_Index), @"mvc.1.0.view", @"/Views/Prestamo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124cff7ffedbb12d9a0dad5ecc072785d399a6be", @"/Views/Prestamo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Prestamo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Biblioteca.Modelo.Lector>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
  
    ViewData["Title"] = "Prestamo realizado";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles de tu prestamo</h1>\r\n\r\n<div>\r\n");
#nullable restore
#line 10 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
     if (ViewBag.error)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Ups! no pudimos procesar el prestamo de este libro para ");
#nullable restore
#line 12 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
                                                               Write(ViewBag.lector.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 12 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
                                                                                         Write(ViewBag.lector.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <hr />\r\n        <h4>Libro que reservaste</h4>\r\n        <div class=\"card\" style=\"width: 18rem;\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 431, "\"", 472, 2);
            WriteAttributeValue("", 437, "/imagenes/", 437, 10, true);
#nullable restore
#line 16 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
WriteAttributeValue("", 447, ViewBag.libro.rutaimagen, 447, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 473, "\"", 500, 1);
#nullable restore
#line 16 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
WriteAttributeValue("", 479, ViewBag.libro.titulo, 479, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
                                  Write(ViewBag.libro.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Se le prestó el libro a ");
#nullable restore
#line 25 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
                               Write(ViewBag.lector.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 25 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
                                                         Write(ViewBag.lector.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <hr />\r\n        <h4>Libro que reservaste</h4>\r\n        <div class=\"card\" style=\"width: 18rem;\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 903, "\"", 944, 2);
            WriteAttributeValue("", 909, "/imagenes/", 909, 10, true);
#nullable restore
#line 29 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
WriteAttributeValue("", 919, ViewBag.libro.rutaimagen, 919, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 945, "\"", 972, 1);
#nullable restore
#line 29 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
WriteAttributeValue("", 951, ViewBag.libro.titulo, 951, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 31 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
                                  Write(ViewBag.libro.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 34 "C:\Users\pablo\source\repos\Biblioteca\Biblioteca\Views\Prestamo\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n    <a href=\"javascript:history.back()\">volver a la página anterior</a>\r\n</div>\r\n");
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

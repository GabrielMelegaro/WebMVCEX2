#pragma checksum "C:\Users\47218167829\Downloads\Ex2WebMVC\Ex2WebMVC\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f768955c5f210f2087aa567f62e327f4c997cc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Listar.cshtml", typeof(AspNetCore.Views_Usuario_Listar))]
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
#line 1 "C:\Users\47218167829\Downloads\Ex2WebMVC\Ex2WebMVC\Views\Usuario\Listar.cshtml"
using Ex2WebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f768955c5f210f2087aa567f62e327f4c997cc7", @"/Views/Usuario/Listar.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\47218167829\Downloads\Ex2WebMVC\Ex2WebMVC\Views\Usuario\Listar.cshtml"
  
    Layout = "MasterPage";
    ViewBag.Title = "Cadastro de Usuarios";

#line default
#line hidden
            BeginContext(106, 39, true);
            WriteLiteral("<div class=\"container\">\r\n    <br>\r\n<h2>");
            EndContext();
            BeginContext(146, 8, false);
#line 8 "C:\Users\47218167829\Downloads\Ex2WebMVC\Ex2WebMVC\Views\Usuario\Listar.cshtml"
Write(TempData);

#line default
#line hidden
            EndContext();
            BeginContext(154, 365, true);
            WriteLiteral(@".[mensagem]</h2>
    <table class=""table table-bordered"">
        <thead class=""thead-dark"">
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Email</th>
                <th>Senha</th>
                <th>Data de Nascimento</th>
                <th>Ações</th>
            </tr>
        </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\47218167829\Downloads\Ex2WebMVC\Ex2WebMVC\Views\Usuario\Listar.cshtml"
     foreach(var item in ViewData["usuarios"] as List<UsuarioModel>)
    {

#line default
#line hidden
            BeginContext(596, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(627, 7, false);
#line 24 "C:\Users\47218167829\Downloads\Ex2WebMVC\Ex2WebMVC\Views\Usuario\Listar.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(634, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(658, 9, false);
#line 25 "C:\Users\47218167829\Downloads\Ex2WebMVC\Ex2WebMVC\Views\Usuario\Listar.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(667, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(691, 10, false);
#line 26 "C:\Users\47218167829\Downloads\Ex2WebMVC\Ex2WebMVC\Views\Usuario\Listar.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(701, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(725, 10, false);
#line 27 "C:\Users\47218167829\Downloads\Ex2WebMVC\Ex2WebMVC\Views\Usuario\Listar.cshtml"
           Write(item.Senha);

#line default
#line hidden
            EndContext();
            BeginContext(735, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(759, 39, false);
#line 28 "C:\Users\47218167829\Downloads\Ex2WebMVC\Ex2WebMVC\Views\Usuario\Listar.cshtml"
           Write(item.DataNascimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(798, 43, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 841, "\"", 875, 2);
            WriteAttributeValue("", 848, "/Usuario/Editar?id=", 848, 19, true);
#line 30 "C:\Users\47218167829\Downloads\Ex2WebMVC\Ex2WebMVC\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 867, item.Id, 867, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(876, 135, true);
            WriteLiteral(" class=\"btn btn-warning\">Editar</a>\r\n                <a href=\"#\" class=\"btn btn-danger\">Excluir</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 34 "C:\Users\47218167829\Downloads\Ex2WebMVC\Ex2WebMVC\Views\Usuario\Listar.cshtml"
    } 

#line default
#line hidden
            BeginContext(1019, 30, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
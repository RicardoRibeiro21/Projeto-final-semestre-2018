#pragma checksum "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\mostrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67807e9bb47c056fdba59203cad9fa3fdba6da4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_mostrar), @"mvc.1.0.view", @"/Views/Comentario/mostrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/mostrar.cshtml", typeof(AspNetCore.Views_Comentario_mostrar))]
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
#line 1 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\mostrar.cshtml"
using Senai.OO.ProjetoFinal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67807e9bb47c056fdba59203cad9fa3fdba6da4f", @"/Views/Comentario/mostrar.cshtml")]
    public class Views_Comentario_mostrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\mostrar.cshtml"
  
    List<ComentarioModel> comentarios = ViewData["Comentarios"] as List<ComentarioModel>;

#line default
#line hidden
            BeginContext(136, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(161, 368, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbc16867ef3a438bbab66cf44171a82a", async() => {
                BeginContext(167, 355, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Aprovação de comentários - Check Point</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""/css/style-aprovacao.css"" />
    <script src=""main.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(529, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(531, 2409, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "214bd8b7d3734983a38a0d4a5af40548", async() => {
                BeginContext(537, 1159, true);
                WriteLiteral(@"
        <header>
            <div class=""container"">
                <div class=""banner"">
                    <nav class=""menu"">
                        <ul>
                            <li>
                                <a href=""sobre.html"">Sobre nós</a>
                            </li>
                            <li>
                                <a href=""contatos.html"">Contato</a>
                            </li>
                            <li>
                                <a href=""perguntas-frequentes.html"">Suporte</a>
                            </li>
                            <li>
                                <a href=""index.html"">Home</a>
                            </li>
                        </ul>
                    </nav>
                    <div class=""banner-opacity"">
                        <div class=""logo"">
                            <img src=""./img/logo.svg"" alt=""Logo checkpoint"">
                        </div>
                    </div>
           ");
                WriteLiteral("     </div>\r\n        </header>\r\n        <main>\r\n            <h2>Aprovação de comentários</h2>\r\n            <section id=\"comentarios\">\r\n");
                EndContext();
#line 45 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\mostrar.cshtml"
                   foreach (ComentarioModel item in comentarios){

#line default
#line hidden
                BeginContext(1763, 257, true);
                WriteLiteral(@"            <div class=""coments"">
                <div class=""coment-1 grid-1"">
                    <img src=""./img/Foto de perfil.jpg"" alt=""Foto de perfil"" class=""item img"">
                    <p name=""comentarioUsuario"" class=""item comentarioUsuario"">");
                EndContext();
                BeginContext(2021, 10, false);
#line 49 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\mostrar.cshtml"
                                                                          Write(item.Texto);

#line default
#line hidden
                EndContext();
                BeginContext(2031, 102, true);
                WriteLiteral("</p>\r\n                    </div> \r\n                    <p name=\"nomeUsuario\" class=\"item nomeUsuario\">");
                EndContext();
                BeginContext(2134, 12, false);
#line 51 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\mostrar.cshtml"
                                                              Write(item.Usuario);

#line default
#line hidden
                EndContext();
                BeginContext(2146, 80, true);
                WriteLiteral("</p>\r\n                    <p name=\"dataComentario\" class=\"item dataComentario\"> ");
                EndContext();
                BeginContext(2227, 36, false);
#line 52 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\mostrar.cshtml"
                                                                     Write(item.DataCriacao.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(2263, 148, true);
                WriteLiteral("</p>      \r\n                    </div>\r\n                    <div>\r\n                        <label class=\"item grid\">\r\n                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2411, "\"", 2453, 2);
                WriteAttributeValue("", 2418, "../Comentario/Aprovacao?id=", 2418, 27, true);
#line 56 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\mostrar.cshtml"
WriteAttributeValue("", 2445, item.Id, 2445, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2454, 86, true);
                WriteLiteral("><button class=\"aprovar\" value=\"Aprovar\"></button></a>\r\n                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2540, "\"", 2581, 2);
                WriteAttributeValue("", 2547, "../Comentario/Rejeitar?id=", 2547, 26, true);
#line 57 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\mostrar.cshtml"
WriteAttributeValue("", 2573, item.Id, 2573, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2582, 120, true);
                WriteLiteral("><button class=\"rejeitar\" value=\"Rejeitar\"></button></a>\r\n                        </label>\r\n                    </div>\r\n");
                EndContext();
#line 60 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\mostrar.cshtml"
                  }

#line default
#line hidden
                BeginContext(2723, 210, true);
                WriteLiteral("                </section>\r\n                <footer>\r\n                <div class=\"rodape\">\r\n                    \r\n                </div>\r\n                </footer>\r\n                </section>\r\n        </main>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2940, 9, true);
            WriteLiteral("\r\n</html>");
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

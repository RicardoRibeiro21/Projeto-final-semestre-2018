#pragma checksum "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\perguntas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1ba3928e77fb67e58341a3e8c219917e1ae0ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_perguntas), @"mvc.1.0.view", @"/Views/Comentario/perguntas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/perguntas.cshtml", typeof(AspNetCore.Views_Comentario_perguntas))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1ba3928e77fb67e58341a3e8c219917e1ae0ad", @"/Views/Comentario/perguntas.cshtml")]
    public class Views_Comentario_perguntas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(27, 384, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08b2d5859bbb474592b99f94e465ee02", async() => {
                BeginContext(33, 371, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Check Point - Plataforma digital de controle de ponto!</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""/css/style-perguntas.css"" />
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
            BeginContext(411, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(415, 5479, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bdfa3c981dd4956a77a3b4e8cf98a68", async() => {
                BeginContext(421, 206, true);
                WriteLiteral("\r\n    <header>\r\n        <div class=\"container\">\r\n            <div class=\"banner\">\r\n                <nav class=\"menu\">\r\n                    <ul>\r\n                        <li>\r\n                            <a>");
                EndContext();
                BeginContext(628, 51, false);
#line 20 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\perguntas.cshtml"
                          Write(Html.ActionLink("Sobre Nós", "sobre", "Comentario"));

#line default
#line hidden
                EndContext();
                BeginContext(679, 98, true);
                WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a>");
                EndContext();
                BeginContext(778, 51, false);
#line 23 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\perguntas.cshtml"
                          Write(Html.ActionLink("Contato", "Contato", "Comentario"));

#line default
#line hidden
                EndContext();
                BeginContext(829, 98, true);
                WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a>");
                EndContext();
                BeginContext(928, 53, false);
#line 26 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\perguntas.cshtml"
                          Write(Html.ActionLink("Suporte", "perguntas", "Comentario"));

#line default
#line hidden
                EndContext();
                BeginContext(981, 99, true);
                WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a >");
                EndContext();
                BeginContext(1081, 46, false);
#line 29 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\perguntas.cshtml"
                           Write(Html.ActionLink("Home", "index", "Comentario"));

#line default
#line hidden
                EndContext();
                BeginContext(1127, 4760, true);
                WriteLiteral(@"</a>
                        </li>
                    </ul>
                </nav>
                <div class=""banner-opacity"">
                    <div class=""logo"">
                        <img src=""./img/logo.svg"" alt=""Logo checkpoint"">
                    </div>
                </div>
            </div>

    </header>
    <main>
        <h2>Lorem ipsum dolor sit amet consectetur adipisicing elit.</h2>
        <section class=""perguntas"">
            <div class=""perg"">
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Ut impedit quaerat similique mollitia veniam inventore
                    eos quisquam! Minus magnam, quibusdam eius iusto, illo beatae, eum provident reiciendis inventore ad
                    incidunt.
                </p>
            </div>
            <div class=""respostas"">
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat nulla in nesciunt! Adipisci facere autem
                    dolorem illo iste.</p");
                WriteLiteral(@">
            </div>
            <div class=""perg"">
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Ut impedit quaerat similique mollitia veniam inventore
                    eos quisquam! Minus magnam, quibusdam eius iusto, illo beatae, eum provident reiciendis inventore ad
                    incidunt.
                </p>
            </div>
            <div class=""respostas"">
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat nulla in nesciunt! Adipisci facere autem
                    dolorem illo iste.</p>
            </div>
            <div class=""perg"">
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Ut impedit quaerat similique mollitia veniam inventore
                    eos quisquam! Minus magnam, quibusdam eius iusto, illo beatae, eum provident reiciendis inventore ad
                    incidunt.
                </p>
            </div>
            <div class=""respostas"">
                <p>");
                WriteLiteral(@"Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat nulla in nesciunt! Adipisci facere autem
                    dolorem illo iste.</p>
            </div>
        </section>
        <section id=""Suporte"">
            <div class=""problema"">
                <button type=""button"">Problema X</button>
                <button type=""button"">Problema Y</button>
                <button type=""button"">Problema Z</button>
            </div>
            <div class=""container-problema"">
                <!--Começo do slide-->
                <h2>Passo à Passo</h2>
                <div class=""img-slide"">
                    <img class='photo' src=""./img/passo (1).jpg"" alt=""Passo à Passo"" />
                </div>
                <div class=""img-slide"">
                    <img class='photo' src=""img/passo (2).jpg"" alt=""Passo à Passo"" />
                </div>
                <div class=""img-slide"">
                    <img class='photo' src=""img//passo (3).jpg"" alt=""Passo à Passo"" />
       ");
                WriteLiteral(@"         </div>
            </div>
        </section>
        <div>
            <p>Não conseguiu resolver seu problema?
                <a href=""#"">Contate-nos!</a>
            </p>
        </div>
    </main>
    <footer id=""rodapé"">
        <div class=""rodape-container"">
            <ul>
                <h3>CARFEL</h3>
                <li>
                    <a href=""#planos"" style=""transition: all .25s linear;"">Comprar</a>
                </li>
                <li>
                    <a href=""#"">Login</a>
                </li>
                <li>
                    <a href=""perguntas-frequentes.html"">Perguntas Frequentes</a>
                </li>
                <li>
                    <a href=""contatos.html"">Como chegar</a>
                </li>
            </ul>
            <ul>
                <h3>PARA EMPRESAS</h3>
                <li>
                    <a href=""sobre.html"">Sobre nós</a>
                </li>
                <li>
                    <a href=""#plano");
                WriteLiteral(@"s"" style=""transition: all .25s linear;"">Comprar</a>
                </li>
                <li>
                    <a href=""#"">Termos de uso</a>
                </li>
            </ul>
            <ul>
                <h3>REDES SOCIAIS</h3>
                <li>
                    <a href=""#"">Facebook</a>
                </li>
                <li>
                    <a href=""#"">Twitter</a>
                </li>
                <li>
                    <a href=""#"">Google+</a>
                </li>
                <li>
                    <a href=""#"">Instagram</a>
                </li>

            </ul>
        </div>
    </footer>
");
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
            BeginContext(5894, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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

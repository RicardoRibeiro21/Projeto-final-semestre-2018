#pragma checksum "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c6b20fa6cf922236e5e85ca44e9037c720ab4c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_index), @"mvc.1.0.view", @"/Views/Comentario/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/index.cshtml", typeof(AspNetCore.Views_Comentario_index))]
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
#line 1 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
using Senai.OO.ProjetoFinal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c6b20fa6cf922236e5e85ca44e9037c720ab4c8", @"/Views/Comentario/index.cshtml")]
    public class Views_Comentario_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
  
    List<ComentarioModel> comentarios = ViewData["Comentarios"] as List<ComentarioModel>;

#line default
#line hidden
            BeginContext(136, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(163, 380, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8bf40d0bc1e4b6bab8a3b14f0140637", async() => {
                BeginContext(169, 367, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Check Point - Plataforma digital de controle de ponto!</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""/css/style-index.css"" />
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
            BeginContext(543, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(547, 9083, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21e5a0d555754b189d8e43649e7c44c4", async() => {
                BeginContext(553, 220, true);
                WriteLiteral("\r\n      <header>\r\n          \r\n        <div class=\"container\">\r\n            <div class=\"banner\">\r\n                <nav class=\"menu\">\r\n                    <ul>\r\n                        <li>\r\n                            <a>");
                EndContext();
                BeginContext(774, 51, false);
#line 25 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
                          Write(Html.ActionLink("Sobre Nós", "sobre", "Comentario"));

#line default
#line hidden
                EndContext();
                BeginContext(825, 98, true);
                WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a>");
                EndContext();
                BeginContext(924, 51, false);
#line 28 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
                          Write(Html.ActionLink("Contato", "Contato", "Comentario"));

#line default
#line hidden
                EndContext();
                BeginContext(975, 98, true);
                WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a>");
                EndContext();
                BeginContext(1074, 53, false);
#line 31 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
                          Write(Html.ActionLink("Suporte", "perguntas", "Comentario"));

#line default
#line hidden
                EndContext();
                BeginContext(1127, 99, true);
                WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a >");
                EndContext();
                BeginContext(1227, 46, false);
#line 34 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
                           Write(Html.ActionLink("Home", "index", "Comentario"));

#line default
#line hidden
                EndContext();
                BeginContext(1273, 4483, true);
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
        <div class=""container-titulo"">
            <h2>Funcionalidades</h2>
        </div>
        <section id=""funcionalidades"">
            <div class=""topico-container"">
                <div class=""topico-img"">
                    <img src=""./img/pc.svg"" alt=""Monitor de computador"">
                    <img src=""./img/home.svg"" style=""scale: 1.3"" alt=""Casa"">
                </div>
                <div class=""topicos"">
                    <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora, a provident, blanditiis
                        laboriosam
              ");
                WriteLiteral(@"          deleniti repellendus dignissimos nobis obcaecati.</p>
                    <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora, a provident, blanditiis
                        laboriosam
                        deleniti repellendus dignissimos nobis obcaecati.</p>

                    <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora, a provident, blanditiis
                        laboriosam
                        deleniti repellendus dignissimos nobis obcaecati.</p>
                    <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora, a provident, blanditiis
                        laboriosam
                        deleniti repellendus dignissimos nobis obcaecati.</p>
                </div>
            </div>
        </section>
        <section id=""planos"">
            <div class=""planos-container"">
                <h2>Planos</h2>
                <ul>
                    <div class=""free"">
                        <img src=");
                WriteLiteral(@"""./img/free.jpg"" alt=""Plano free"">
                        <li>Free</li>
                        <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Tempora ratione consequuntur animi
                            dignissimos
                            perspiciatis accusantium aut omnis at molestias, alias eius dicta cum labore ad suscipit
                            non
                            praesentium repellendus quis?</p>
                        <button type=""button"">
                            <a href=""#"">Adquirir</a>
                        </button>
                        <!--Aqui inserir botão de adquirir-->
                    </div>
                    <div class=""pago"">
                        <img src=""img/economico.png"" alt=""Plano economico"">
                        <li>Pago</li>
                        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam, harum ratione, ad dolorum
                            consequuntur
                          ");
                WriteLiteral(@"  quod ullam mollitia aut magni vel dolorem soluta, deserunt beatae aperiam necessitatibus
                            perferendis
                            inventore voluptatibus commodi!</p>
                        <button type=""button"">
                            <a href=""#"">Comprar</a>
                        </button>
                        <!--Aqui inserir botão de adquirir-->
                    </div>
                    <div class=""premium"">
                        <img src=""img/premium.png"" alt=""Plano premium"">
                        <li>Premium</li>
                        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam, harum ratione, ad dolorum
                            consequuntur
                            quod ullam mollitia aut magni vel dolorem soluta, deserunt beatae aperiam necessitatibus
                            perferendis
                            inventore voluptatibus commodi!</p>
                        <button type=""button"">
      ");
                WriteLiteral(@"                      <a href=""#"">Comprar</a>
                        </button>
                        <!--Aqui inserir botão de adquirir-->
                    </div>
                </ul>
            </div>
        </section>
        <form id=""comentarios"" action=""/Comentario/Cadastrar"" method=""POST"">
            <div class=""coments"">
                <h2>Comentários</h2>
");
                EndContext();
#line 123 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
         foreach (ComentarioModel item in comentarios){

#line default
#line hidden
                BeginContext(5813, 222, true);
                WriteLiteral("                <div class=\"coment-1 grid-1\">\r\n                    <img src=\"./img/Foto de perfil.jpg\" alt=\"Foto de perfil\" class=\"item img\">\r\n                    <p name=\"comentarioUsuario\" class=\"item comentarioUsuario\">");
                EndContext();
                BeginContext(6036, 10, false);
#line 126 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
                                                                          Write(item.Texto);

#line default
#line hidden
                EndContext();
                BeginContext(6046, 102, true);
                WriteLiteral("</p>\r\n                    </div> \r\n                    <p name=\"nomeUsuario\" class=\"item nomeUsuario\">");
                EndContext();
                BeginContext(6149, 12, false);
#line 128 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
                                                              Write(item.Usuario);

#line default
#line hidden
                EndContext();
                BeginContext(6161, 80, true);
                WriteLiteral("</p>\r\n                    <p name=\"dataComentario\" class=\"item dataComentario\"> ");
                EndContext();
                BeginContext(6242, 16, false);
#line 129 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
                                                                     Write(item.DataCriacao);

#line default
#line hidden
                EndContext();
                BeginContext(6258, 16, true);
                WriteLiteral("</p>          \r\n");
                EndContext();
#line 130 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
        }

#line default
#line hidden
                BeginContext(6285, 87, true);
                WriteLiteral("                <div class=\"botao\"><button>Exibir mais</button></div>\r\n                ");
                EndContext();
                BeginContext(6373, 16, false);
#line 132 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
           Write(ViewBag.Mensagem);

#line default
#line hidden
                EndContext();
                BeginContext(6389, 519, true);
                WriteLiteral(@"
                <h3>Nos dê sua opinião sobre os nossos produtos!</h3>
                <div class=""section-cad-coment"">
                <div class=""cad-coment grid-3"">
                    <img src=""./img/Foto de perfil.jpg"" class=""item img"">
                    <p class=""item user""></p>
                    <textarea name=""coment"" class=""item coment""></textarea>
                    <input type=""submit"" value=""Enviar"">
                </div>
             
            </div>
            </div>
           ");
                EndContext();
                BeginContext(6909, 16, false);
#line 144 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
      Write(ViewBag.Mensagem);

#line default
#line hidden
                EndContext();
                BeginContext(6925, 1054, true);
                WriteLiteral(@"
        </form>
        <section id=""sobre"">
            <div class=""container-sobre"">
                <h2>Sobre a Empresa</h2>
                <div class=""conteudo"">
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Earum accusantium sit unde, corrupti
                        amet, ipsum
                        quae esse nesciunt laborum cum nulla libero aut explicabo eaque nostrum labore molestiae
                        voluptate
                        commodi? Lorem ipsum dolor sit amet consectetur adipisicing elit. Earum accusantium sit unde,
                        corrupti
                        amet, ipsum quae esse nesciunt laborum cum nulla libero aut explicabo eaque nostrum labore
                        molestiae
                        voluptate commodi? Lorem ipsum dolor sit amet consectetur adipisicing elit. </p>
                    <p>
                        <img src=""img/carfel.png"" alt=""Design carfel"">
                    </p>
             ");
                WriteLiteral("   </div>\r\n                <a>");
                EndContext();
                BeginContext(7980, 51, false);
#line 163 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
              Write(Html.ActionLink("Sobre Nós", "sobre", "Comentario"));

#line default
#line hidden
                EndContext();
                BeginContext(8031, 442, true);
                WriteLiteral(@"</a>
            </div>
        </section>
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
                    <a>");
                EndContext();
                BeginContext(8474, 66, false);
#line 178 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
                  Write(Html.ActionLink("Perguntas frequentes", "perguntas", "Comentario"));

#line default
#line hidden
                EndContext();
                BeginContext(8540, 74, true);
                WriteLiteral("</a>\r\n                </li>\r\n                <li>\r\n                    <a>");
                EndContext();
                BeginContext(8615, 55, false);
#line 181 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
                  Write(Html.ActionLink("Como chegar", "Contato", "Comentario"));

#line default
#line hidden
                EndContext();
                BeginContext(8670, 151, true);
                WriteLiteral("</a>\r\n                </li>\r\n            </ul>\r\n            <ul>\r\n                <h3>PARA EMPRESAS</h3>\r\n                <li>\r\n                    <a>");
                EndContext();
                BeginContext(8822, 51, false);
#line 187 "C:\Users\Marcia\Desktop\Pasta\c#\Projeto-final-semestre-2018\Views\Comentario\index.cshtml"
                  Write(Html.ActionLink("Sobre nós", "sobre", "Comentario"));

#line default
#line hidden
                EndContext();
                BeginContext(8873, 750, true);
                WriteLiteral(@"</a>
                </li>
                <li>
                    <a href=""#planos"" style=""transition: all .25s linear;"">Comprar</a>
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
            BeginContext(9630, 11, true);
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

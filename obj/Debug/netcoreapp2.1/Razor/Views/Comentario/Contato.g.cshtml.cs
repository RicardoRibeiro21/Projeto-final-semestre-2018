#pragma checksum "C:\Users\47575406808\Desktop\C#\Senai.OO.ProjetoFinal\Views\Comentario\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fce43b978c26c0d54afc634c9102224bde53604b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_Contato), @"mvc.1.0.view", @"/Views/Comentario/Contato.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/Contato.cshtml", typeof(AspNetCore.Views_Comentario_Contato))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fce43b978c26c0d54afc634c9102224bde53604b", @"/Views/Comentario/Contato.cshtml")]
    public class Views_Comentario_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(27, 383, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5e177a152846d09cf6dbd991c50683", async() => {
                BeginContext(33, 370, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Check Point - Plataforma digital de controle de ponto!</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""/css/style-contatos.css"" />
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
            BeginContext(410, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(414, 4750, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "730d649be39243349c61d070fb9fecd0", async() => {
                BeginContext(420, 4737, true);
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
            </div>
    </header>
    <main>
        <h2>Lorem ipsum dolor sit amet consectetur adipisici");
                WriteLiteral(@"ng elit.</h2>
        <section id=""contato"">
            <h2>Formulário para Contato</h2>
        >
            <div class=""form"">
                <input class=""box1"" type=""text"" placeholder=""Nome completo"">
                <input class=""box1"" type=""text"" placeholder=""Cidade"">
                <input class=""box1"" type=""text"" placeholder=""Email"">
                <input class=""box1"" type=""text"" placeholder=""Telefone"">
                <input class=""box1"" type=""text"" placeholder=""Empresa"">
                <input class=""box1"" type=""text"" placeholder=""Cargo"">

                <textarea class=""box2"" type=""text"" placeholder=""Comentários""></textarea>
            </div>
            <button class=""box3"" type=""button""><a href=""#"" style=""transition: 0.25s"">Enviar</a></button>
            <div class=""empresa"">
                <ul>
                    <li>
                        <img src=""img/telefone.png"" alt=""Imagem de Telefone"">
                        <p>Telefone</p>
                        <a href=""");
                WriteLiteral(@"#"">(XX)xxxx-xxxx</a>
                    </li>
                    <li>
                        <img src=""img/EMAIL.png"" alt=""Logo email"">
                        <p>Email</p>
                        <a href=""#"">lorem.ipsulum@carfel.com</a>
                    </li>
                    <li>
                        <img src=""img/redes sociais.png"" alt=""logo redes sociais"">
                        <p>Redes sociais</p>
                        <a href=""#"">Facebook</a>
                    </li>
                </ul>
        </section>
        <div class=""endereco"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.8875444688033!2d-46.648491284971726!3d-23.53654676656158!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deb99025%3A0xb23619858bc7e63e!2sEscola+SENAI+de+Inform%C3%A1tica!5e0!3m2!1spt-BR!2sbr!4v1536582981375""
                width=""600"" height=""450"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
            <p> Endereço: Al. Barão ");
                WriteLiteral(@"de Limeira 539, São Paulo, SP, 01202-001</p>
        </div>
        <p>Alguma Dúvida? Acesse nossa página de
            <a href=""#"">perguntas frequentes</a>
        </p>
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
                    <a href=""#planos"" style=""transition: all .25");
                WriteLiteral(@"s linear;"">Comprar</a>
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
            BeginContext(5164, 11, true);
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

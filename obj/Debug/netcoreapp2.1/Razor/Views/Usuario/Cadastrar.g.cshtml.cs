#pragma checksum "C:\Users\47575406808\Desktop\C#\Senai.OO.ProjetoFinal\Views\Usuario\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd3058217caf1fb06cc5e1dd2accdb9b33599061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastrar), @"mvc.1.0.view", @"/Views/Usuario/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Cadastrar.cshtml", typeof(AspNetCore.Views_Usuario_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd3058217caf1fb06cc5e1dd2accdb9b33599061", @"/Views/Usuario/Cadastrar.cshtml")]
    public class Views_Usuario_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(27, 341, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a42e886b25f44c4875ac9af148b1e06", async() => {
                BeginContext(33, 328, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>CheckPoinnt</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""/css/style-cadastrar.css"" />
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
            BeginContext(368, 25, true);
            WriteLiteral("\r\n<header>\r\n</header>\r\n\r\n");
            EndContext();
            BeginContext(394, 16, false);
#line 15 "C:\Users\47575406808\Desktop\C#\Senai.OO.ProjetoFinal\Views\Usuario\Cadastrar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(410, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(412, 1263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42af1a45300f4f10a618b70ce5e45406", async() => {
                BeginContext(418, 1250, true);
                WriteLiteral(@"
    <main>
        <!-- Divisão para cadastrar-->
        <section id=""cadastro"">
            <div class=""Cadastrar"" id=""cadastroScroll"">
                <div class=""text-cadastro"">
                    <form autocomplete=""off"" action=""/Usuario/Cadastrar"" method=""POST"" >
                        <h2><a href=""#"">Cadastrar</a></h2>
                        <p>Nome</p>
                        <input type=""text"" placeholder=""Insira seu nome"" name=""nome"" required=""true""> 
                        <p>Insira o email</p>
                        <input type=""email"" placeholder=""checkpoint@email.com"" name=""email"" required=""true"">
                        <p>Insira a senha</p>
                        <input type=""password"" placeholder=""********"" name=""senha"" required=""true"">
                        <p>Repita a senha</p>
                        <input type=""password"" placeholder=""********"" name=""senhaVerficacao"" required=""true"">
                        <button type=""submit"" value=""Enviar"">Cadastrar</button>
");
                WriteLiteral("                        <a href=\"/Usuario/FazerLogin\">Fazer Login</a>\r\n                    </form>\r\n                </div>\r\n            </div>\r\n            <!-- Fim divisão para cadastrar -->\r\n        </section>\r\n    </main>\r\n");
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
            BeginContext(1675, 11, true);
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

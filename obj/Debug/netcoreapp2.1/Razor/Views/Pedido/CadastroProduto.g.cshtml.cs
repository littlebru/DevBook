#pragma checksum "C:\Users\AnaPaula\controleEstoque\Views\Pedido\CadastroProduto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "175d26a448be024516cfc40e7174a8259fdec217"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_CadastroProduto), @"mvc.1.0.view", @"/Views/Pedido/CadastroProduto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/CadastroProduto.cshtml", typeof(AspNetCore.Views_Pedido_CadastroProduto))]
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
#line 1 "C:\Users\AnaPaula\controleEstoque\Views\_ViewImports.cshtml"
using controleEstoque;

#line default
#line hidden
#line 2 "C:\Users\AnaPaula\controleEstoque\Views\_ViewImports.cshtml"
using controleEstoque.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"175d26a448be024516cfc40e7174a8259fdec217", @"/Views/Pedido/CadastroProduto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457e6bf4a8adf8d01575d28a087064f81c2568f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_CadastroProduto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "carrossel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\AnaPaula\controleEstoque\Views\Pedido\CadastroProduto.cshtml"
  
    // dicionario de dados que é passado para a view
    ViewData["Title"] = "Cadastro de Produto";

#line default
#line hidden
            BeginContext(109, 1679, true);
            WriteLiteral(@"

<h3>Cadastro de Produto</h3>
<div class=""panel panel-default"">
    <div class=""panel-body"">
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label"" for=""nomeCliente"">Nome do Produto</label>
                <input type=""text"" class=""form-control"" id=""nomeCliente"" placeholder=""Nome do Produto"">
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""email"">Tipo do Produto</label>
                <input type=""email"" class=""form-control"" id=""tipo-produto"" placeholder=""Livro"">
            </div>
            <div class=""form-group"">
                <button type=""submit""
                        class=""btn btn-success"">
                    Cadastrar
                </button>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label"" for=""valor-compra"">Valor de Compra</label>
                <input ty");
            WriteLiteral(@"pe=""number"" class=""form-control"" id=""valor-compra"" placeholder=""R$"">
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""quantidade"">Quantidade</label>
                <input type=""number"" class=""form-control"" id=""quantidade"" placeholder=""Unidade"">
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label"" for=""valor-venda"">Valor de Venda</label>
                <input type=""number"" class=""form-control"" id=""valor-venda"" placeholder=""R$"">
            </div>

        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(1788, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9e4758ea8be4c578bef319acda60e04", async() => {
                BeginContext(1838, 27, true);
                WriteLiteral("\r\n    Continuar Comprando\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
#pragma checksum "C:\Users\AnaPaula\controleEstoque\Views\Pedido\Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed763ea2a4f5238ce2c68842f8881aae09b8fde0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Carrinho), @"mvc.1.0.view", @"/Views/Pedido/Carrinho.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Carrinho.cshtml", typeof(AspNetCore.Views_Pedido_Carrinho))]
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
#line 6 "C:\Users\AnaPaula\controleEstoque\Views\Pedido\Carrinho.cshtml"
using ControleEstoque.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed763ea2a4f5238ce2c68842f8881aae09b8fde0", @"/Views/Pedido/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457e6bf4a8adf8d01575d28a087064f81c2568f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ItemPedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "carrossel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "resumo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\AnaPaula\controleEstoque\Views\Pedido\Carrinho.cshtml"
  
    // dicionario de dados que é passado para a view
    ViewData["Title"] = "Carrinho";

#line default
#line hidden
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(132, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(161, 608, true);
            WriteLiteral(@"
<h3>Meu Carrinho</h3>
<div class=""panel panel-default"">
    <div class=""panel-heading"">
        <div class=""row"">
            <div class=""col-md-6"">
                Item
            </div>
            <div class=""col-md-2 text-center"">
                Preço Unitário
            </div>
            <div class=""col-md-2 text-center"">
                Quantidade
            </div>
            <div class=""col-md-2"">
                <span class=""pull-right"">
                    Subtotal
                </span>
            </div>
        </div>
    </div>
    <div class=""panel-body"">

");
            EndContext();
#line 32 "C:\Users\AnaPaula\controleEstoque\Views\Pedido\Carrinho.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(818, 149, true);
            WriteLiteral("            <div class=\"row row-center linha-produto\">\r\n                <div class=\"col-md-3\">\r\n                    <img class=\"img-produto-carrinho\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 967, "\"", 1022, 3);
            WriteAttributeValue("", 973, "/images/produtos/large_", 973, 23, true);
#line 36 "C:\Users\AnaPaula\controleEstoque\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 996, item.Produto.Codigo, 996, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 1018, ".jpg", 1018, 4, true);
            EndWriteAttribute();
            BeginContext(1023, 67, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-3\">");
            EndContext();
            BeginContext(1091, 17, false);
#line 38 "C:\Users\AnaPaula\controleEstoque\Views\Pedido\Carrinho.cshtml"
                                 Write(item.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1108, 61, true);
            WriteLiteral("</div>\r\n                <div class=\"col-md-2 text-center\">R$ ");
            EndContext();
            BeginContext(1170, 18, false);
#line 39 "C:\Users\AnaPaula\controleEstoque\Views\Pedido\Carrinho.cshtml"
                                                Write(item.PrecoUnitario);

#line default
#line hidden
            EndContext();
            BeginContext(1188, 410, true);
            WriteLiteral(@"</div>
                <div class=""col-md-2 text-center"">
                    <div class=""input-group"">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"">
                                <span class=""glyphicon-minus""></span>
                            </button>
                        </span>
                        <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1598, "\"", 1624, 1);
#line 47 "C:\Users\AnaPaula\controleEstoque\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 1606, item.Quantidade, 1606, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1625, 505, true);
            WriteLiteral(@"
                               class=""form-control text-center"" />
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"">
                                <span class=""glyphicon-plus""></span>
                            </button>
                        </span>
                    </div>
                </div>
                <div class=""col-md-2"">
                    R$ <span class=""pull-right"" subtotal>
                        ");
            EndContext();
            BeginContext(2132, 36, false);
#line 58 "C:\Users\AnaPaula\controleEstoque\Views\Pedido\Carrinho.cshtml"
                    Write(item.Quantidade * item.PrecoUnitario);

#line default
#line hidden
            EndContext();
            BeginContext(2169, 75, true);
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 62 "C:\Users\AnaPaula\controleEstoque\Views\Pedido\Carrinho.cshtml"
        }

#line default
#line hidden
            BeginContext(2255, 174, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"panel-footer\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-10\">\r\n                <span numero-itens>\r\n                    Total: ");
            EndContext();
            BeginContext(2431, 13, false);
#line 69 "C:\Users\AnaPaula\controleEstoque\Views\Pedido\Carrinho.cshtml"
                       Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(2445, 189, true);
            WriteLiteral("\r\n                    itens\r\n                </span>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                Total: R$ <span class=\"pull-right\" total>\r\n                    ");
            EndContext();
            BeginContext(2636, 46, false);
#line 75 "C:\Users\AnaPaula\controleEstoque\Views\Pedido\Carrinho.cshtml"
                Write(Model.Sum(i => i.Quantidade * i.PrecoUnitario));

#line default
#line hidden
            EndContext();
            BeginContext(2683, 177, true);
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"pull-right\">\r\n            ");
            EndContext();
            BeginContext(2860, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84bc34a5dbda4f36b18688320d4f6d45", async() => {
                BeginContext(2910, 50, true);
                WriteLiteral("\r\n                Adicionar Produtos\r\n            ");
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
            BeginContext(2964, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(2978, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "457f65abf17945a786c1952093602a9f", async() => {
                BeginContext(3025, 48, true);
                WriteLiteral("\r\n                Finalizar Pedido\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3077, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<ItemPedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaf277c6b638ec829279484c650c7944c885ce2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(E_Migrant.App.FrontEnd.Pages.Empresa.Pages_Empresa_ListarEmpresa), @"mvc.1.0.razor-page", @"/Pages/Empresa/ListarEmpresa.cshtml")]
namespace E_Migrant.App.FrontEnd.Pages.Empresa
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
#line 1 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\_ViewImports.cshtml"
using E_Migrant.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf277c6b638ec829279484c650c7944c885ce2b", @"/Pages/Empresa/ListarEmpresa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29f80d627369a9adfc720bbccab5385fe0c8f011", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Empresa_ListarEmpresa : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#FFC300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListarEmpresa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditarEmpresa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class = ""center"">
<h3>Listar Empresa</h3>
<p>En está página podrá visualizar su registro de empresa</p>


<table class=""table table-dark"">
  <thead class=""thead-dark"">
    <tr>
        <th scope=""col"">Razon_Social</th>
      <th scope=""col"">Nit</th>
      <th scope=""col"">Direccion</th>
      <th scope=""col"">Ciudad</th>
      <th scope=""col"">Telefono</th>
      <th scope=""col"">Email</th>
      <th scope=""col"">Pagina Web</th>
      <th scope=""col"">Sector</th>
      <th scope=""col"">Tipo Servicios</th>
      
      
    </tr>
  </thead>
");
#nullable restore
#line 27 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
 foreach(var empresa in Model.empresas){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
       Write(empresa.Razon_Social);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><b>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaf277c6b638ec829279484c650c7944c885ce2b5718", async() => {
#nullable restore
#line 30 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
                                                                                         Write(empresa.Nit);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
                                                                     WriteLiteral(empresa.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</b></td>\r\n        \r\n        <td>");
#nullable restore
#line 32 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
       Write(empresa.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
       Write(empresa.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
       Write(empresa.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
       Write(empresa.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
       Write(empresa.Pagina_Web);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
       Write(empresa.Sector);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
       Write(empresa.Tipo_Servicios);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n       \r\n        <td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaf277c6b638ec829279484c650c7944c885ce2b10709", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
                                                                              WriteLiteral(empresa.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            \r\n        </td>  \r\n    </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\Hackaton2.0\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Empresa\ListarEmpresa.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Migrant.App.FrontEnd.ListarEmpresaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Migrant.App.FrontEnd.ListarEmpresaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Migrant.App.FrontEnd.ListarEmpresaModel>)PageContext?.ViewData;
        public E_Migrant.App.FrontEnd.ListarEmpresaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ebec8f3e655043c0b53ca6bd739976605740af7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Index), @"mvc.1.0.view", @"/Views/Productos/Index.cshtml")]
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
#line 1 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\_ViewImports.cshtml"
using AppVeterinariaUCR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\_ViewImports.cshtml"
using AppVeterinariaUCR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ebec8f3e655043c0b53ca6bd739976605740af7", @"/Views/Productos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bcf2b5a95b81c142530cbcabe9316dcd04648e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Productos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppVeterinariaUCR.Models.Productos>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Crear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Modificar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Eliminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
  
    ViewData["Title"] = "Lista productos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Productos</h1>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ebec8f3e655043c0b53ca6bd739976605740af75030", async() => {
                WriteLiteral("Nuevo");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-bordered table-responsive-sm\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 20 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descrip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrecioCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PorImp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n");
            WriteLiteral("            <th></th>\r\n");
            WriteLiteral("            <th></th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
         foreach (var item in Model)

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
                                                                            
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td> ");
#nullable restore
#line 49 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
                Write(Html.DisplayFor(model => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 50 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
               Write(Html.DisplayFor(model => item.Descrip));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
               Write(Html.DisplayFor(model => item.PrecioCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
               Write(Html.DisplayFor(model => item.PorImp));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
               Write(Html.DisplayFor(model => item.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                <td><a class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#P-");
#nullable restore
#line 55 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
                                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Detalle</a></td>\r\n\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ebec8f3e655043c0b53ca6bd739976605740af711479", async() => {
                WriteLiteral("Modificar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
                                                                        WriteLiteral(item.Id);

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
            WriteLiteral("</td>\r\n\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ebec8f3e655043c0b53ca6bd739976605740af713843", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
                                                                       WriteLiteral(item.Id);

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
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 62 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 67 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
 foreach (var item in Model)
 {
    //Modal para cada producto

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=\"", 2342, "\"", 2357, 2);
            WriteAttributeValue("", 2347, "P-", 2347, 2, true);
#nullable restore
#line 70 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
WriteAttributeValue("", 2349, item.Id, 2349, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal\" tabindex=\"-1\" role=\"dialog\">\r\n        <div class=\"modal-dialog\" role=\"document\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-header\">\r\n");
            WriteLiteral("                    <h5 class=\"modal-title\">Producto ");
#nullable restore
#line 75 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
                                                Write(item.Descrip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
            WriteLiteral("                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"close\"></button>\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n");
            WriteLiteral("                </div>\r\n                <div class=\"modal-body\">\r\n                    <div class=\"text-left mb-4\">\r\n                        <p>Precio de compra: ");
#nullable restore
#line 83 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
                                        Write(item.PrecioCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 3229, "\"", 3245, 1);
#nullable restore
#line 86 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
WriteAttributeValue("", 3235, item.Foto, 3235, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Producto\" class=\"d-block w-100\" />\r\n\r\n                    <div class=\"text-left mb-4\">\r\n                        <p>Porcentaje de impuestos: ");
#nullable restore
#line 89 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
                                               Write(item.PorImp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n\r\n                </div>\r\n            </div>");
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 98 "D:\UCR I Semestre 2021\IF4101 LENGUAJES PARA APLICACIONES COMERCIALES\session_18\AppVeterinariaUCR\AppVeterinariaUCR\Views\Productos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppVeterinariaUCR.Models.Productos>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b44b5c0db77dc5f3e43580459043201a720ca87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Index))]
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
#line 1 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\_ViewImports.cshtml"
using VirtualShop;

#line default
#line hidden
#line 1 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
using VirtualShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b44b5c0db77dc5f3e43580459043201a720ca87", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bf4c322c5f402e651f522b1f0f0513ba2bd89e0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(99, 163, true);
            WriteLiteral("<br /><br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Product List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(262, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b44b5c0db77dc5f3e43580459043201a720ca875382", async() => {
                BeginContext(306, 49, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; Add New Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(359, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(381, 462, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b44b5c0db77dc5f3e43580459043201a720ca876906", async() => {
                BeginContext(401, 435, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-3"">
            <input type=""number"" class=""form-control"" name=""lowAmount"" />
        </div>
        <div class=""col-3"">
            <input type=""number"" class=""form-control"" name=""largeAmount"" />
        </div>
        <div class=""col-3"">
            <input type=""submit"" value=""Search"" class=""btn btn-success"" />
        </div>
        <div class=""col-3""></div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(843, 174, true);
            WriteLiteral("\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\" id=\"myTable\">\r\n        <thead>\r\n            <tr class=\"table-info\">\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1018, 32, false);
#line 35 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1118, 33, false);
#line 38 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1219, 40, false);
#line 41 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.ProductColor));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1327, 39, false);
#line 44 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1434, 41, false);
#line 47 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.ProductTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1543, 40, false);
#line 50 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.SpecialTagId));

#line default
#line hidden
            EndContext();
            BeginContext(1583, 135, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
            EndContext();
#line 58 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1775, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1822, 9, false);
#line 61 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1831, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1863, 10, false);
#line 62 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1873, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1905, 17, false);
#line 63 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.ProductColor);

#line default
#line hidden
            EndContext();
            BeginContext(1922, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1954, 16, false);
#line 64 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.IsAvailable);

#line default
#line hidden
            EndContext();
            BeginContext(1970, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2002, 29, false);
#line 65 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.ProductTypes.ProductType);

#line default
#line hidden
            EndContext();
            BeginContext(2031, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2063, 20, false);
#line 66 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.SpecialTag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2083, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2140, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b44b5c0db77dc5f3e43580459043201a720ca8714753", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 68 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2190, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 71 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2257, 42, true);
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2316, 431, true);
                WriteLiteral(@"
    <script src=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js""></script>

    <script type=""text/javascript"">
        $(document).ready( function () {
            $('#myTable').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ]
            });
        } );
        $(function(){
            var save = '");
                EndContext();
                BeginContext(2748, 16, false);
#line 89 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
                EndContext();
                BeginContext(2764, 111, true);
                WriteLiteral("\'\r\n            if(save!=\'\') {\r\n                alertify.success(save);\r\n            }\r\n            var edit = \'");
                EndContext();
                BeginContext(2876, 16, false);
#line 93 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
                EndContext();
                BeginContext(2892, 110, true);
                WriteLiteral("\'\r\n            if(edit!=\'\') {\r\n                alertify.success(edit);\r\n            }\r\n            var del = \'");
                EndContext();
                BeginContext(3003, 18, false);
#line 97 "C:\Users\Montasir\Desktop\Virtual Shop\VirtualShop\VirtualShop\Areas\Admin\Views\Product\Index.cshtml"
                  Write(TempData["delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(3021, 111, true);
                WriteLiteral("\'\r\n            if (del!=\'\') {\r\n                alertify.error(del);\r\n            }\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(3135, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591

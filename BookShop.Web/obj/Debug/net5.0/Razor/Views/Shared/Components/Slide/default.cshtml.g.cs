#pragma checksum "C:\Users\Omer\source\repos\BookShop\BookShop.Web\Views\Shared\Components\Slide\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f70b602877faaa4bca12babad726a5806a556449"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Slide_default), @"mvc.1.0.view", @"/Views/Shared/Components/Slide/default.cshtml")]
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
#line 1 "C:\Users\Omer\source\repos\BookShop\BookShop.Web\Views\_ViewImports.cshtml"
using BookShop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Omer\source\repos\BookShop\BookShop.Web\Views\_ViewImports.cshtml"
using BookShop.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Omer\source\repos\BookShop\BookShop.Web\Views\_ViewImports.cshtml"
using BookShop.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f70b602877faaa4bca12babad726a5806a556449", @"/Views/Shared/Components/Slide/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"806fc9323bf8889579607c73259b9840dcb3411d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Slide_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Omer\source\repos\BookShop\BookShop.Web\Views\Shared\Components\Slide\default.cshtml"
 foreach (var author in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"hero__items set-bg\" data-setbg=\"");
#nullable restore
#line 5 "C:\Users\Omer\source\repos\BookShop\BookShop.Web\Views\Shared\Components\Slide\default.cshtml"
                                           Write(author.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"hero__text\">\r\n");
            WriteLiteral("                    <h2>");
#nullable restore
#line 10 "C:\Users\Omer\source\repos\BookShop\BookShop.Web\Views\Shared\Components\Slide\default.cshtml"
                   Write(author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 11 "C:\Users\Omer\source\repos\BookShop\BookShop.Web\Views\Shared\Components\Slide\default.cshtml"
                  Write(author.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a href=\"#\"><span>Kitaplar?? G??r</span> <i class=\"fa fa-angle-right\"></i></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\Omer\source\repos\BookShop\BookShop.Web\Views\Shared\Components\Slide\default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591

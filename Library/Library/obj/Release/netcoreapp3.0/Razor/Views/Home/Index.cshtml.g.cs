#pragma checksum "C:\Github\library\Library\Library\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd46945ba4400d43fac8ba0ab1be13d25aa5a3b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Github\library\Library\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Github\library\Library\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd46945ba4400d43fac8ba0ab1be13d25aa5a3b1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Library.Entity.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Github\library\Library\Library\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Anasayfa";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Github\library\Library\Library\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"row book-card\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 258, "\"", 291, 2);
            WriteAttributeValue("", 265, "/Product/Index?id=", 265, 18, true);
#nullable restore
#line 11 "C:\Github\library\Library\Library\Views\Home\Index.cshtml"
WriteAttributeValue("", 283, item.Id, 283, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"col-md-4\">\r\n                            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 393, "\"", 414, 1);
#nullable restore
#line 13 "C:\Github\library\Library\Library\Views\Home\Index.cshtml"
WriteAttributeValue("", 399, item.PosterUrl, 399, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col-md-8\">\r\n                            <p class=\"name\"><strong>");
#nullable restore
#line 16 "C:\Github\library\Library\Library\Views\Home\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                            <p class=\"author text-info\">");
#nullable restore
#line 17 "C:\Github\library\Library\Library\Views\Home\Index.cshtml"
                                                   Write(item.Author.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"publisher text-success\">");
#nullable restore
#line 18 "C:\Github\library\Library\Library\Views\Home\Index.cshtml"
                                                         Write(item.Publisher.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"text-warning\">");
#nullable restore
#line 19 "C:\Github\library\Library\Library\Views\Home\Index.cshtml"
                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Github\library\Library\Library\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Library.Entity.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Shared\Components\Last3Blog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e06e27e5efc704beb2e7c1292a128ac89775c168"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Last3Blog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Last3Blog/Default.cshtml")]
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
#line 1 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\_ViewImports.cshtml"
using BlogCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\_ViewImports.cshtml"
using BlogCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Shared\Components\Last3Blog\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06e27e5efc704beb2e7c1292a128ac89775c168", @"/Views/Shared/Components/Last3Blog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1ac2137dbdf710fc00ae3f17b92dee1c7b4c4a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Last3Blog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Shared\Components\Last3Blog\Default.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"blog-grids row mb-3\">\r\n        <div class=\"col-md-5 blog-grid-left\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 185, "\"", 222, 2);
            WriteAttributeValue("", 192, "/Blog/BlogReadAll/", 192, 18, true);
#nullable restore
#line 9 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Shared\Components\Last3Blog\Default.cshtml"
WriteAttributeValue("", 210, item.BlogId, 210, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 246, "\"", 267, 1);
#nullable restore
#line 10 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Shared\Components\Last3Blog\Default.cshtml"
WriteAttributeValue("", 252, item.BlogImage, 252, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("   class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 301, "\"", 307, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </a>\r\n        </div>\r\n        <div class=\"col-md-7 blog-grid-right\">\r\n\r\n            <h5>\r\n                <a href=\"single.html\">");
#nullable restore
#line 16 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Shared\Components\Last3Blog\Default.cshtml"
                                 Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </h5>\r\n            <div class=\"sub-meta\">\r\n                <span>\r\n                    <i class=\"far fa-clock\"></i>  ");
#nullable restore
#line 20 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Shared\Components\Last3Blog\Default.cshtml"
                                              Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Shared\Components\Last3Blog\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e3cf03ea535944e7abf2f4e06a043fb8cd62af6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic1_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic1/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e3cf03ea535944e7abf2f4e06a043fb8cd62af6", @"/Areas/Admin/Views/Shared/Components/Statistic1/Default.cshtml")]
    public class Areas_Admin_Views_Shared_Components_Statistic1_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-3"">
        <div class=""widget style1"">
            <div class=""row"">
                <div class=""col-4 text-center"">
                    <i class=""fa fa-trophy fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Blog Count </span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 10 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml"
                                     Write(ViewBag.BlogCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 navy-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-cloud fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Istanbul </span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 23 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml"
                                     Write(ViewBag.temperature);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 'C</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 lazur-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-envelope-o fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Message Count </span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 36 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml"
                                     Write(ViewBag.MessageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 yellow-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-comment fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span>Comment Count </span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 49 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml"
                                     Write(ViewBag.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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

#pragma checksum "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e74462bbd4bb0fea82c2d68327f89f8885acf5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogUpdate), @"mvc.1.0.view", @"/Views/Blog/BlogUpdate.cshtml")]
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
#line 1 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e74462bbd4bb0fea82c2d68327f89f8885acf5a", @"/Views/Blog/BlogUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1ac2137dbdf710fc00ae3f17b92dee1c7b4c4a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
  
    ViewData["Title"] = "BlogUpdate";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
 using (Html.BeginForm("BlogUpdate", "Blog", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.HiddenFor(i => i.BlogId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.Label("Blog Title"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.TextBoxFor(i => i.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.ValidationMessageFor(i => i.BlogTitle, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.Label("Blog Content"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.TextAreaFor(i => i.BlogContent, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.ValidationMessageFor(i => i.BlogContent, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.Label("Blog Image"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.TextBoxFor(i => i.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.ValidationMessageFor(i => i.BlogImage, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 27 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.Label("Blog Mini Image"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.TextBoxFor(i => i.BlogThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.ValidationMessageFor(i => i.BlogThumbnailImage, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 36 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.Label("Blog Cateogry"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.DropDownListFor(i => i.CategoryId, (List<SelectListItem>)ViewBag.categories, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"
Write(Html.ValidationMessageFor(i => i.CategoryId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button type=\"submit\" class=\"btn btn-primary submit mb-4\">Update</button>\r\n");
#nullable restore
#line 43 "C:\Users\MONSTER\MyProjects\NetCore\BlogProject\BlogCoreProject\Views\Blog\BlogUpdate.cshtml"


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591

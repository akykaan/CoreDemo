#pragma checksum "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e552ad9df5ee7c355da3d0b31e47763365278a6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e552ad9df5ee7c355da3d0b31e47763365278a6f", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>BlogListByWriter</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Blog ba??l??????</th>
        <th>tarih</th>
        <th>kategori</th>
        <th>durum</th>
        <th>Sil</th>
        <th>D??zenle</th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t <tr>\r\n             <td>");
#nullable restore
#line 23 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            Write(item.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 24 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 25 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 26 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 27 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            Write(item.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td><a href=\"#\" class=\"btn btn-danger\">Sil</a> </td>\r\n             <td><a href=\"#\" class=\"btn btn-danger\">D??zenle</a> </td>\r\n         </tr>\r\n");
#nullable restore
#line 31 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"#\" class=\"btn btn-primary\">Yeni Blog Olu??tur</a>");
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

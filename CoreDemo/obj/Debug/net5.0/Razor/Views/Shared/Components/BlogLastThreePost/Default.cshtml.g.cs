#pragma checksum "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba82142b5218c5b0c3e296fef89dc88aebedc001"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLastThreePost_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLastThreePost/Default.cshtml")]
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
#line 1 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba82142b5218c5b0c3e296fef89dc88aebedc001", @"/Views/Shared/Components/BlogLastThreePost/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLastThreePost_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h3>Son Postlar</h3>\r\n");
#nullable restore
#line 7 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 255, "\"", 292, 2);
            WriteAttributeValue("", 262, "/Blog/BlogReadAll/", 262, 18, true);
#nullable restore
#line 11 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
WriteAttributeValue("", 280, item.BlogId, 280, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 320, "\"", 341, 1);
#nullable restore
#line 12 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
WriteAttributeValue("", 326, item.BlogImage, 326, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 373, "\"", 379, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 525, "\"", 562, 2);
            WriteAttributeValue("", 532, "/Blog/BlogReadAll/", 532, 18, true);
#nullable restore
#line 19 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
WriteAttributeValue("", 550, item.BlogId, 550, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
                                                        Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 23 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
                                                 Write(((DateTime)
                            item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n           \r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\kaana\Desktop\coredemo\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
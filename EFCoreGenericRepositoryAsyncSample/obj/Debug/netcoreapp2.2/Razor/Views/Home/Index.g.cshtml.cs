#pragma checksum "C:\Users\nkudu\source\repos\EFCoreGenericRepositoryAsyncSample\EFCoreGenericRepositoryAsyncSample\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c4427bcea0c577aff3460d4bf72f46d8028c9d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\nkudu\source\repos\EFCoreGenericRepositoryAsyncSample\EFCoreGenericRepositoryAsyncSample\Views\_ViewImports.cshtml"
using EFCoreGenericRepositoryAsyncSample;

#line default
#line hidden
#line 2 "C:\Users\nkudu\source\repos\EFCoreGenericRepositoryAsyncSample\EFCoreGenericRepositoryAsyncSample\Views\_ViewImports.cshtml"
using EFCoreGenericRepositoryAsyncSample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c4427bcea0c577aff3460d4bf72f46d8028c9d9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e68cadc9dcd244cfeb1e5cf3c6baa62fe9bde85", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\nkudu\source\repos\EFCoreGenericRepositoryAsyncSample\EFCoreGenericRepositoryAsyncSample\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 97, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <label>Name:</label> <i>");
            EndContext();
            BeginContext(143, 19, false);
#line 7 "C:\Users\nkudu\source\repos\EFCoreGenericRepositoryAsyncSample\EFCoreGenericRepositoryAsyncSample\Views\Home\Index.cshtml"
                       Write(ViewBag.CoolestName);

#line default
#line hidden
            EndContext();
            BeginContext(162, 38, true);
            WriteLiteral("</i>\r\n    <label>LastName:</label> <i>");
            EndContext();
            BeginContext(201, 23, false);
#line 8 "C:\Users\nkudu\source\repos\EFCoreGenericRepositoryAsyncSample\EFCoreGenericRepositoryAsyncSample\Views\Home\Index.cshtml"
                           Write(ViewBag.CoolestLastName);

#line default
#line hidden
            EndContext();
            BeginContext(224, 128, true);
            WriteLiteral("</i>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
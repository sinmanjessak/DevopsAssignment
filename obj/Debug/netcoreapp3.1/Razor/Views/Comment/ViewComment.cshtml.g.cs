#pragma checksum "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Comment\ViewComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b048b1cc80e1457b9a78d50843d4f797211d514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_ViewComment), @"mvc.1.0.view", @"/Views/Comment/ViewComment.cshtml")]
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
#line 1 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\_ViewImports.cshtml"
using BookReading.Event;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\_ViewImports.cshtml"
using BookReading.Event.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b048b1cc80e1457b9a78d50843d4f797211d514", @"/Views/Comment/ViewComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0211f9d72631223032da6e09ac446c40a55c130a", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_ViewComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookReading.Event.Models.CommentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Comment\ViewComment.cshtml"
  
    ViewData["Title"] = "ViewComment";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewComment</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Comment\ViewComment.cshtml"
       Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Comment\ViewComment.cshtml"
       Write(Html.DisplayFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookReading.Event.Models.CommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

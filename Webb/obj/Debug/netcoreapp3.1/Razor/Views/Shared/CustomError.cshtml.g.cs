#pragma checksum "D:\E_D\HOCTAP\NAM_3\KTVTKPM\TH4\Lap1-master\Webb\Views\Shared\CustomError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fb979a33fc0d59ac436442b67d8d4cf573d87d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomError), @"mvc.1.0.view", @"/Views/Shared/CustomError.cshtml")]
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
#line 1 "D:\E_D\HOCTAP\NAM_3\KTVTKPM\TH4\Lap1-master\Webb\Views\_ViewImports.cshtml"
using Webb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\E_D\HOCTAP\NAM_3\KTVTKPM\TH4\Lap1-master\Webb\Views\_ViewImports.cshtml"
using Webb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\E_D\HOCTAP\NAM_3\KTVTKPM\TH4\Lap1-master\Webb\Views\Shared\CustomError.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb979a33fc0d59ac436442b67d8d4cf573d87d2", @"/Views/Shared/CustomError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e0f0b36cd161788606c3e327e1b700b047eb65d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CustomError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\E_D\HOCTAP\NAM_3\KTVTKPM\TH4\Lap1-master\Webb\Views\Shared\CustomError.cshtml"
  
    ViewData["Title"] = "Error";
    Layout = !UserHttpContext.HttpContext.User.Identity.IsAuthenticated ? "_layout" : "_SecureLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col s12"">
        <div class=""card-panel orange lighten-1 margin-bottom-50px margin-top-50px"">
            <span class=""white-text"">
                An error occurred while processing your request. Please contact customer

                service with following

                Ticket No. ");
#nullable restore
#line 15 "D:\E_D\HOCTAP\NAM_3\KTVTKPM\TH4\Lap1-master\Webb\Views\Shared\CustomError.cshtml"
                      Write(ViewData["ExceptionId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor UserHttpContext { get; private set; }
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

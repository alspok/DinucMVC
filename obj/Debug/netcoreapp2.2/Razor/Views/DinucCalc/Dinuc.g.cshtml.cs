#pragma checksum "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0dfc567a0e6aeb33a2aa8e2629436b6a4e9dbda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DinucCalc_Dinuc), @"mvc.1.0.view", @"/Views/DinucCalc/Dinuc.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DinucCalc/Dinuc.cshtml", typeof(AspNetCore.Views_DinucCalc_Dinuc))]
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
#line 1 "C:\Users\alvydas\source\repos\DinucMVC\Views\_ViewImports.cshtml"
using DinucMVC;

#line default
#line hidden
#line 2 "C:\Users\alvydas\source\repos\DinucMVC\Views\_ViewImports.cshtml"
using DinucMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0dfc567a0e6aeb33a2aa8e2629436b6a4e9dbda", @"/Views/DinucCalc/Dinuc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6232995e6f7f989b5e6067184377ed146b974b9", @"/Views/_ViewImports.cshtml")]
    public class Views_DinucCalc_Dinuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
  
    ViewData["Title"] = "DinucCalc";

#line default
#line hidden
            BeginContext(47, 27, true);
            WriteLiteral("\r\n<h1>DinucCalc</h1>\r\n\r\n<b>");
            EndContext();
            BeginContext(75, 18, false);
#line 8 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
Write(ViewBag.testReturn);

#line default
#line hidden
            EndContext();
            BeginContext(93, 6, true);
            WriteLiteral("</b>\r\n");
            EndContext();
            BeginContext(121, 75, true);
            WriteLiteral("\r\n<p></p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr class=\"row\">\r\n");
            EndContext();
#line 16 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
             foreach(var item in ViewBag.DiTable.Dinuc)
            {

#line default
#line hidden
            BeginContext(268, 38, true);
            WriteLiteral("                <th class=\"col-sm-12\">");
            EndContext();
            BeginContext(307, 4, false);
#line 18 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
                                 Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(311, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 19 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
            }

#line default
#line hidden
            BeginContext(333, 68, true);
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr class=\"row\">\r\n");
            EndContext();
#line 24 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
             foreach (var item in ViewBag.DiTable.DinucCount)
            {

#line default
#line hidden
            BeginContext(479, 38, true);
            WriteLiteral("                <td class=\"col-sm-16\">");
            EndContext();
            BeginContext(518, 4, false);
#line 26 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
                                 Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(522, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 27 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
            }

#line default
#line hidden
            BeginContext(544, 41, true);
            WriteLiteral("        </tr>\r\n        <tr class=\"row\">\r\n");
            EndContext();
#line 30 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
             foreach (var item in ViewBag.DiTable.DinucFrq)
            {

#line default
#line hidden
            BeginContext(661, 38, true);
            WriteLiteral("                <td class=\"col-sm-16\">");
            EndContext();
            BeginContext(700, 4, false);
#line 32 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
                                 Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(704, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 33 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
            }

#line default
#line hidden
            BeginContext(726, 41, true);
            WriteLiteral("        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n");
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

#pragma checksum "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0cd94e9f0a7b3a79aeb1ae3d5949008a758b821"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cd94e9f0a7b3a79aeb1ae3d5949008a758b821", @"/Views/DinucCalc/Dinuc.cshtml")]
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
            WriteLiteral("\r\n<h5>DinucCalc</h5>\r\n\r\n<a>");
            EndContext();
            BeginContext(75, 18, false);
#line 8 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
Write(ViewBag.testReturn);

#line default
#line hidden
            EndContext();
            BeginContext(93, 80, true);
            WriteLiteral("</a>\r\n\r\n<br />\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr class=\"row\">\r\n");
            EndContext();
#line 15 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
             foreach(var item in ViewBag.DiTable.Dinuc)
            {

#line default
#line hidden
            BeginContext(245, 41, true);
            WriteLiteral("                <th style=\"width: 6.25%\">");
            EndContext();
            BeginContext(287, 4, false);
#line 17 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
                                    Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(291, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 18 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
            }

#line default
#line hidden
            BeginContext(313, 68, true);
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr class=\"row\">\r\n");
            EndContext();
#line 23 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
             foreach (var item in ViewBag.DiTable.DinucCountFirstFrame)
            {

#line default
#line hidden
            BeginContext(469, 41, true);
            WriteLiteral("                <td style=\"width: 6.25%\">");
            EndContext();
            BeginContext(511, 4, false);
#line 25 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
                                    Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(515, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 26 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
            }

#line default
#line hidden
            BeginContext(537, 41, true);
            WriteLiteral("        </tr>\r\n        <tr class=\"row\">\r\n");
            EndContext();
#line 29 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
             foreach (var item in ViewBag.DiTable.DinucCountSecondFrame)
            {

#line default
#line hidden
            BeginContext(667, 41, true);
            WriteLiteral("                <td style=\"width: 6.25%\">");
            EndContext();
            BeginContext(709, 4, false);
#line 31 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
                                    Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(713, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 32 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
            }

#line default
#line hidden
            BeginContext(735, 41, true);
            WriteLiteral("        </tr>\r\n        <tr class=\"row\">\r\n");
            EndContext();
#line 35 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
             foreach (var item in ViewBag.DiTable.DinucFrqFirstFrame)
            {

#line default
#line hidden
            BeginContext(862, 41, true);
            WriteLiteral("                <td style=\"width: 6.25%\">");
            EndContext();
            BeginContext(904, 4, false);
#line 37 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
                                    Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(908, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 38 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
            }

#line default
#line hidden
            BeginContext(930, 41, true);
            WriteLiteral("        </tr>\r\n        <tr class=\"row\">\r\n");
            EndContext();
#line 41 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
             foreach (var item in ViewBag.DiTable.DinucFrqSecondFrame)
            {

#line default
#line hidden
            BeginContext(1058, 41, true);
            WriteLiteral("                <td style=\"width: 6.25%\">");
            EndContext();
            BeginContext(1100, 4, false);
#line 43 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
                                    Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(1104, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 44 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
            }

#line default
#line hidden
            BeginContext(1126, 53, true);
            WriteLiteral("        </tr>\r\n        <tr class=\"row\">\r\n            ");
            EndContext();
            BeginContext(1180, 28, false);
#line 47 "C:\Users\alvydas\source\repos\DinucMVC\Views\DinucCalc\Dinuc.cshtml"
       Write(ViewBag.DiTable.DinucFrqDiff);

#line default
#line hidden
            EndContext();
            BeginContext(1208, 43, true);
            WriteLiteral("\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n");
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

#pragma checksum "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Services\Day.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3159eb517c2581e818fb61cb540257278cf514e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Day), @"mvc.1.0.view", @"/Views/Services/Day.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3159eb517c2581e818fb61cb540257278cf514e8", @"/Views/Services/Day.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f552928020350bc66885b6a0ff00e35608fd1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Day : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Services\Day.cshtml"
  
    ViewData["Title"] = "Day";
    Layout = "_LayoutMenu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container marketing \" style=\"padding: 0 0 0 20px\">\r\n    <div class=\"Mypadding\">\r\n        <h2>Дни</h2>\r\n        <table>\r\n");
#nullable restore
#line 10 "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Services\Day.cshtml"
             foreach (var item in @ViewBag.Day)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 13 "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Services\Day.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 14 "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Services\Day.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Services\Day.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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

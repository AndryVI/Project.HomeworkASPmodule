#pragma checksum "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Filter\LogUserAction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1870c053748487f716e3ed229eada2aba080354e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filter_LogUserAction), @"mvc.1.0.view", @"/Views/Filter/LogUserAction.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1870c053748487f716e3ed229eada2aba080354e", @"/Views/Filter/LogUserAction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f552928020350bc66885b6a0ff00e35608fd1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Filter_LogUserAction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebH.Models.LogActionModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Filter\LogUserAction.cshtml"
  
    ViewData["Title"] = "Журнал действий пользователя";
    Layout = "_LayoutMenu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container marketing\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 181, "\"", 189, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""jumbotron Spanpadding Divpadding "">
            <h2 class=""display-5 fw-bold text-center "" id=""blocksIMGToggle5"">Страница для  отображения журнал действий пользователя.</h2>
            <br />
            <br />

            <div class=""bd-example d-md-flex"">
                <div class=""overflow-auto p-3 mb-3 mb-md-0 me-md-3 bg-light"" style=""width: 100%; max-height: 800px;"">
");
#nullable restore
#line 17 "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Filter\LogUserAction.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"p-3 mb-2 bg-secondary text-white \">\r\n                        <h5>Метод: <span class=\"text-dark\">");
#nullable restore
#line 20 "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Filter\LogUserAction.cshtml"
                                                      Write(item.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </h5>\r\n                        <h5>Вызван: <span class=\"text-info\"> ");
#nullable restore
#line 21 "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Filter\LogUserAction.cshtml"
                                                        Write(item.DateAndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h5>\r\n                        <h5>Пользователем: <span class=\"text-info\">Id</span> - <span class=\"text-dark\"> ");
#nullable restore
#line 22 "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Filter\LogUserAction.cshtml"
                                                                                                   Write(item.IdUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </h5> \r\n                        <h5>На выполнение  обращения к нему затрачено <span class=\"text-info\">");
#nullable restore
#line 23 "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Filter\LogUserAction.cshtml"
                                                                                         Write(item.TimeElapsed);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </h5> \r\n                    </div>\r\n");
#nullable restore
#line 25 "C:\Users\Andrii\Documents\GitHub\Project-WEB\WEBH\Views\Filter\LogUserAction.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebH.Models.LogActionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

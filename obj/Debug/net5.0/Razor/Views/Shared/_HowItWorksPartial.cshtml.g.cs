#pragma checksum "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Shared\_HowItWorksPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9c486060bc7adb62e572ebdaf1361839eb5569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HowItWorksPartial), @"mvc.1.0.view", @"/Views/Shared/_HowItWorksPartial.cshtml")]
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
#line 1 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\_ViewImports.cshtml"
using CarRent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\_ViewImports.cshtml"
using CarRent.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9c486060bc7adb62e572ebdaf1361839eb5569", @"/Views/Shared/_HowItWorksPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23e5c7271e3bfef47d7649ca96dc4575677acc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HowItWorksPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container site-section mb-5\">\r\n    <div class=\"row justify-content-center text-center\">\r\n        <div class=\"col-7 text-center mb-5\">\r\n            <h2>");
#nullable restore
#line 4 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Shared\_HowItWorksPartial.cshtml"
           Write(Localizer["How it works?"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>");
#nullable restore
#line 5 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Shared\_HowItWorksPartial.cshtml"
          Write(Localizer["Our car rental process is as shown below."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"how-it-works d-flex\">\r\n        <div class=\"step\">\r\n            <span class=\"number\"><span>01</span></span>\r\n            <span class=\"caption\">");
#nullable restore
#line 11 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Shared\_HowItWorksPartial.cshtml"
                             Write(Localizer["Time & Place"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"step\">\r\n            <span class=\"number\"><span>02</span></span>\r\n            <span class=\"caption \">");
#nullable restore
#line 15 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Shared\_HowItWorksPartial.cshtml"
                              Write(Localizer["Car"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"step\">\r\n            <span class=\"number\"><span>03</span></span>\r\n            <span class=\"caption\">");
#nullable restore
#line 19 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Shared\_HowItWorksPartial.cshtml"
                             Write(Localizer["Details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"step\">\r\n            <span class=\"number\"><span>04</span></span>\r\n            <span class=\"caption\">");
#nullable restore
#line 23 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Shared\_HowItWorksPartial.cshtml"
                             Write(Localizer["Checkout"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"step\">\r\n            <span class=\"number\"><span>05</span></span>\r\n            <span class=\"caption\">");
#nullable restore
#line 27 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Shared\_HowItWorksPartial.cshtml"
                             Write(Localizer["Done"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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

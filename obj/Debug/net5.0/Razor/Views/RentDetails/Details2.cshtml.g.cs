#pragma checksum "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b85a87c90d5d4b8db7a5fdba07391a8e5ba40f21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RentDetails_Details2), @"mvc.1.0.view", @"/Views/RentDetails/Details2.cshtml")]
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
#line 1 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
using CarRent.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b85a87c90d5d4b8db7a5fdba07391a8e5ba40f21", @"/Views/RentDetails/Details2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a506c1aa88ad80a36949b47b6582aa790be615", @"/Views/_ViewImports.cshtml")]
    public class Views_RentDetails_Details2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
  
    Office rentOffice = HttpContextAccessor.HttpContext.Session.GetObject<Office>("RentOffice");
    Office returnOffice = HttpContextAccessor.HttpContext.Session.GetObject<Office>("ReturnOffice");
    Car rentCar = HttpContextAccessor.HttpContext.Session.GetObject<Car>("RentCar");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n</div>\r\n\r\n<h1>Rent Details</h1>\r\n<h3>Rent Office: </h3><p>");
#nullable restore
#line 15 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
                    Write(rentOffice.OfficeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h3>Rent Office Address: </h3><p>");
#nullable restore
#line 16 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
                            Write(rentOffice.Address.AddressText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
                                                            Write(rentOffice.Address.District.DistrictName);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 16 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
                                                                                                      Write(rentOffice.Address.District.Province.ProvinceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h3>Return Office: </h3><p>");
#nullable restore
#line 17 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
                      Write(returnOffice.OfficeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h3>Rent Office Address: </h3><p>");
#nullable restore
#line 18 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
                            Write(returnOffice.Address.AddressText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
                                                              Write(returnOffice.Address.District.DistrictName);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 18 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
                                                                                                          Write(returnOffice.Address.District.Province.ProvinceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h3>Car: </h3><p>");
#nullable restore
#line 19 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
            Write(rentCar.CarBrand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\RentDetails\Details2.cshtml"
                              Write(rentCar.CarModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
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

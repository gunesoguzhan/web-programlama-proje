#pragma checksum "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02077c0a0625e2c448e1c7df335ae4769330a1f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_LastActiveReservations), @"mvc.1.0.view", @"/Views/Reservation/LastActiveReservations.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02077c0a0625e2c448e1c7df335ae4769330a1f3", @"/Views/Reservation/LastActiveReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23e5c7271e3bfef47d7649ca96dc4575677acc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_LastActiveReservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarRent.Models.Reservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
  
    ViewData["Title"] = Localizer["Last Active Reservations"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""padding-top-120px bg-dark""></div>

<div class=""site-section bg-light padding-top-120px"">
    <div class=""container"">
        <div class=""row justify-content-center text-center"">
            <div class=""col-7 text-center mb-5"">
                <h2>");
#nullable restore
#line 13 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 17 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 mb-4\">\r\n                    <div class=\"item-1\">\r\n                        <div class=\"item-1-contents\">\r\n                            <div class=\"text-center\">\r\n                                <h3>");
#nullable restore
#line 23 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                               Write(item.ReservationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            </div>\r\n                            <ul class=\"specs\">\r\n                                <li>\r\n                                    <span class=\"spec2\">");
#nullable restore
#line 27 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.ReservationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"spec spec2\">");
#nullable restore
#line 28 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                        Write(item.ReservationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span class=\"spec2\">");
#nullable restore
#line 31 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.RentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"spec spec2\">");
#nullable restore
#line 32 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                        Write(item.RentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span class=\"spec2\">");
#nullable restore
#line 35 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Car.Office.OfficeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"spec spec2\">");
#nullable restore
#line 36 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                        Write(item.Car.Office.OfficeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span class=\"spec2\">");
#nullable restore
#line 39 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"spec spec2\">");
#nullable restore
#line 40 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                        Write(item.ReturnDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span class=\"spec2\">");
#nullable restore
#line 43 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.ReturnOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"spec spec2\">");
#nullable restore
#line 44 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                        Write(item.ReturnOffice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span class=\"spec2\">");
#nullable restore
#line 47 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Days));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"spec spec2\">");
#nullable restore
#line 48 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                        Write(item.Days);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span class=\"spec2\">");
#nullable restore
#line 51 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Car.CarId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"spec spec2\">");
#nullable restore
#line 52 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                        Write(item.CarId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 52 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                                    Write(item.Car.CarBrand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 52 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                                                       Write(item.Car.CarModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span class=\"spec2\">");
#nullable restore
#line 55 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                   Write(Localizer["User"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"spec spec2\">");
#nullable restore
#line 56 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                        Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span class=\"spec2\">");
#nullable restore
#line 59 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"spec spec2\">");
#nullable restore
#line 60 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
                                                        Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 66 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\LastActiveReservations.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarRent.Models.Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ec97e34cecb83d041bbe5e33d6eb6f710e885db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Complated), @"mvc.1.0.view", @"/Views/Reservation/Complated.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ec97e34cecb83d041bbe5e33d6eb6f710e885db", @"/Views/Reservation/Complated.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23e5c7271e3bfef47d7649ca96dc4575677acc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Complated : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reservation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_HowItWorksPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
  
    ViewData["Title"] = Localizer["Payment Complated"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""padding-top-120px bg-dark""></div>

<div class=""site-section bg-light padding-top-120px"">
    <div class=""container"">
        <div class=""row justify-content-center text-center mb-5"">
            <div class=""col-7 text-center mb-5"">
                <h1>");
#nullable restore
#line 13 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <h5>");
#nullable restore
#line 14 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
               Write(Localizer["Thanks for your payment. Your reservation application has been received. You must be at our office 10 minutes before the reservation time. If you think there is an inaccuracy in the information below, contact us."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6 col-md-6 mb-4\">\r\n                <div class=\"item-1\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 811, "\"", 839, 1);
#nullable restore
#line 20 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
WriteAttributeValue("", 817, Model.Car.CarImageUrl, 817, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" class=\"img-fluid bg-white\">\r\n                    <div class=\"item-1-contents\">\r\n                        <div class=\"text-center\">\r\n                            <h3>");
#nullable restore
#line 23 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                           Write(Model.Car.CarBrand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                               Write(Model.Car.CarModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        </div>\r\n                        <ul class=\"specs\">\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 27 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Html.DisplayNameFor(x => x.Car.Engine));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 28 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.Car.Engine.EngineHorsePower);

#line default
#line hidden
#nullable disable
            WriteLiteral(" hp ");
#nullable restore
#line 28 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                                                                    Write(Model.Car.Engine.EngineVolume);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm³</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 31 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Html.DisplayNameFor(x => x.Car.Engine.EngineFuelType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 32 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Html.DisplayFor(x => x.Car.Engine.EngineFuelType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 35 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Html.DisplayNameFor(x => x.Car.CarTransmissionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 36 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Html.DisplayFor(x => x.Car.CarTransmissionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 39 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Html.DisplayNameFor(x => x.Car.CarTrimPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 40 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.Car.CarTrimPackage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 43 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Html.DisplayNameFor(x => x.Car.CarType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 44 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.Car.CarType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 47 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Html.DisplayNameFor(x => x.Car.CarProductYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 48 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.Car.CarProductYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 51 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Html.DisplayNameFor(x => x.Car.MinimumAge));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 52 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.Car.MinimumAge);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 col-md-6 mb-4"">
                <div class=""item-1"">
                    <div class=""item-1-contents"">
                        <div class=""text-center"">
                            <h3>");
#nullable restore
#line 62 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                           Write(Localizer["Rent Details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        </div>\r\n                        <ul class=\"specs\">\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 66 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Localizer["Rent Office"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 67 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.Car.Office.Address.District.Province.ProvinceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 67 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                                                                                         Write(Model.Car.Office.Address.District.DistrictName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 70 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Localizer["Rent Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 71 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.ReservationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 74 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Localizer["Return Office"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 75 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.ReturnOffice.Address.District.DistrictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 75 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                                                                                  Write(Model.ReturnOffice.Address.District.Province.ProvinceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 78 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Localizer["Return Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 79 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.ReturnDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 82 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Html.DisplayNameFor(x => x.Days));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 83 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.Days);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 86 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Html.DisplayNameFor(x => x.Car.CarDepositPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 87 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.Car.CarDepositPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("₺</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 90 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Html.DisplayNameFor(x => x.Car.CarRentPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 91 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.Car.CarRentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("₺</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>");
#nullable restore
#line 94 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                 Write(Html.DisplayNameFor(x => x.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 95 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                              Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("₺ ");
#nullable restore
#line 95 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Reservation\Complated.cshtml"
                                                                 Write(Localizer["paid."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ec97e34cecb83d041bbe5e33d6eb6f710e885db20245", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reservation> Html { get; private set; }
    }
}
#pragma warning restore 1591

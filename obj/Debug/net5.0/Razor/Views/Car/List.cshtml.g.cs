#pragma checksum "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "541fa4bd62040c753f3eaad4239160a4fbb59e9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_List), @"mvc.1.0.view", @"/Views/Car/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"541fa4bd62040c753f3eaad4239160a4fbb59e9d", @"/Views/Car/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a506c1aa88ad80a36949b47b6582aa790be615", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarRent.Models.Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reserve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
  
    ViewData["Title"] = "Our Cars For You";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""ftco-blocks-cover-1"">
    <div class=""ftco-cover-1 overlay innerpage"" style=""background-image: url('/img/cars.jpg')"">
        <div class=""container"">
            <div class=""row align-items-center justify-content-center"">
                <div class=""col-lg-6 text-center"">
                    <h1>Our Cars For You</h1>
                    <p>We list our suitable cars for you.</p>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""site-section bg-light"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 23 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 mb-4\">\r\n                    <div class=\"item-1\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 852, "\"", 875, 1);
#nullable restore
#line 27 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
WriteAttributeValue("", 858, item.CarImageUrl, 858, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" class=\"img-fluid bg-white\">\r\n                        <div class=\"item-1-contents\">\r\n                            <div class=\"text-center\">\r\n                                <h3>");
#nullable restore
#line 30 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
                               Write(item.CarBrand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
                                              Write(item.CarModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <div class=\"rent-price\"><span>");
#nullable restore
#line 31 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
                                                         Write(item.CarRentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺/</span>day</div>\r\n                            </div>\r\n                            <ul class=\"specs\">\r\n                                <li>\r\n                                    <span>Engine</span>\r\n                                    <span class=\"spec\">");
#nullable restore
#line 36 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
                                                  Write(item.Engine.EngineHorsePower);

#line default
#line hidden
#nullable disable
            WriteLiteral(" hp ");
#nullable restore
#line 36 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
                                                                                   Write(item.Engine.EngineVolume);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm³</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span>Fuel</span>\r\n                                    <span class=\"spec\">");
#nullable restore
#line 40 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
                                                  Write(item.Engine.EngineFuelType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span>Transmission</span>\r\n                                    <span class=\"spec\">");
#nullable restore
#line 44 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
                                                  Write(item.CarTransmissionType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span>Minium age</span>\r\n                                    <span class=\"spec\">");
#nullable restore
#line 48 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
                                                  Write(item.MinimumAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                            </ul>\r\n                            <div class=\"d-flex action\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "541fa4bd62040c753f3eaad4239160a4fbb59e9d9271", async() => {
                WriteLiteral("Rent Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
                                                                                       WriteLiteral(item.CarId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 58 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Car\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarRent.Models.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4907cf7f8a2988600a0f7b7696c537bd995372e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4907cf7f8a2988600a0f7b7696c537bd995372e0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a506c1aa88ad80a36949b47b6582aa790be615", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarRent.Models.Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FastReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-auto btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cf-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "RentPlace", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cf-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ReturnPlace", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("trip-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Car", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"ftco-blocks-cover-1\" >\r\n    <div class=\"ftco-cover-1\"");
            BeginWriteAttribute("style", " style=\"", 153, "\"", 229, 4);
            WriteAttributeValue("", 161, "background-image:", 161, 17, true);
            WriteAttributeValue(" ", 178, "url(", 179, 5, true);
#nullable restore
#line 8 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
WriteAttributeValue("", 183, Url.Content(Model.First().CarCoverImageUrl), 183, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 227, ");", 227, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"container\">\r\n            <div class=\"row align-items-center\">\r\n                <div class=\"col-lg-5\">\r\n                    <div class=\"feature-car-rent-box-1\">\r\n                        <h3>");
#nullable restore
#line 13 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                       Write(Model.First().CarBrand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                               Write(Model.First().CarModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <ul class=\"list-unstyled\">\r\n                            <li>\r\n                                <span>Office</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 17 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                              Write(Model.First().Office.Address.District.Province.ProvinceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                                                                                             Write(Model.First().Office.Address.District.DistrictName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>Engine</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 21 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                              Write(Model.First().Engine.EngineHorsePower);

#line default
#line hidden
#nullable disable
            WriteLiteral(" hp ");
#nullable restore
#line 21 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                                                                        Write(Model.First().Engine.EngineVolume);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm³</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>Fuel</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 25 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                              Write(Model.First().Engine.EngineFuelType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>Transmission</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 29 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                              Write(Model.First().CarTransmissionType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li>\r\n                                <span>Minium age</span>\r\n                                <span class=\"spec\">");
#nullable restore
#line 33 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                              Write(Model.First().MinimumAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                        </ul>\r\n                        <div class=\"d-flex align-items-center bg-light p-3\">\r\n                            <span>");
#nullable restore
#line 37 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                             Write(Model.First().CarRentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("₺/day</span>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4907cf7f8a2988600a0f7b7696c537bd995372e013865", async() => {
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
#line 38 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                                                                           WriteLiteral(Model.First().CarId);

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
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""site-section pt-0 pb-0 bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4907cf7f8a2988600a0f7b7696c537bd995372e016682", async() => {
                WriteLiteral(@"
                    <div class=""row align-items-center mb-4"">
                        <div class=""col-md-6"">
                            <h3 class=""m-0"">Begin your trip here</h3>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""form-group col-md-3"">
                            <label for=""cf-1"">Where you from</label>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4907cf7f8a2988600a0f7b7696c537bd995372e017390", async() => {
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4907cf7f8a2988600a0f7b7696c537bd995372e017691", async() => {
                        WriteLiteral("Your pickup address");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 61 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.ProvinceDistrict;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group col-md-3\">\r\n                            <label for=\"cf-2\">Where you go</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4907cf7f8a2988600a0f7b7696c537bd995372e021237", async() => {
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4907cf7f8a2988600a0f7b7696c537bd995372e021538", async() => {
                        WriteLiteral("Your drop-off address");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#nullable restore
#line 67 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.ProvinceDistrict;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <div class=""form-group col-md-3"">
                            <label for=""cf-3"">Journey date</label>
                            <input type=""datetime-local"" id=""cf-3"" name=""RentDate"" placeholder=""Your pickup address"" class=""form-control px-3"" required>
                        </div>
                        <div class=""form-group col-md-3"">
                            <label for=""cf-4"">Return date</label>
                            <input type=""datetime-local"" id=""cf-4"" name=""ReturnDate"" placeholder=""Your pickup address"" class=""form-control px-3"" required>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <input type=""submit"" value=""Begin Trip"" class=""btn btn-primary"">
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>



<div class=""site-section bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <h3>Our Offer</h3>
                <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iure nesciunt nemo vel earum maxime neque!</p>
                <p>
                    <a href=""#"" class=""btn btn-primary custom-prev"">Previous</a>
                    <span class=""mx-2"">/</span>
                    <a href=""#"" class=""btn btn-primary custom-next"">Next</a>
                </p>
            </div>
            <div class=""col-lg-9"">
                <div class=""nonloop-block-13 owl-carousel"">
");
#nullable restore
#line 107 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item-1\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 5421, "\"", 5444, 1);
#nullable restore
#line 110 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
WriteAttributeValue("", 5427, item.CarImageUrl, 5427, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" class=\"img-fluid bg-white\">\r\n                            <div class=\"item-1-contents\">\r\n                                <div class=\"text-center\">\r\n                                    <h3>");
#nullable restore
#line 113 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                   Write(item.CarBrand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 113 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                                  Write(item.CarModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <div class=\"rent-price\"><span>");
#nullable restore
#line 114 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                                             Write(item.CarRentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"₺/</span>day</div>
                                </div>
                                <ul class=""specs"">
                                    <li>
                                        <span>Office</span>
                                        <span class=""spec"">");
#nullable restore
#line 119 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                                      Write(item.Office.Address.District.Province.ProvinceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 119 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                                                                                            Write(item.Office.Address.District.DistrictName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </li>\r\n                                    <li>\r\n                                        <span>Engine</span>\r\n                                        <span class=\"spec\">");
#nullable restore
#line 123 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                                      Write(item.Engine.EngineHorsePower);

#line default
#line hidden
#nullable disable
            WriteLiteral(" hp ");
#nullable restore
#line 123 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                                                                       Write(item.Engine.EngineVolume);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm³</span>\r\n                                    </li>\r\n                                    <li>\r\n                                        <span>Fuel</span>\r\n                                        <span class=\"spec\">");
#nullable restore
#line 127 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                                      Write(item.Engine.EngineFuelType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </li>\r\n                                    <li>\r\n                                        <span>Transmission</span>\r\n                                        <span class=\"spec\">");
#nullable restore
#line 131 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                                      Write(item.CarTransmissionType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </li>\r\n                                </ul>\r\n                                <div class=\"d-flex action\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4907cf7f8a2988600a0f7b7696c537bd995372e033173", async() => {
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
#line 135 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                                                                                                   WriteLiteral(item.CarId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 139 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

            </div>
        </div>
    </div>
</div>

<div class=""site-section section-3"" style=""background-image: url('images/hero_2.jpg');"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 text-center mb-5"">
                <h2 class=""text-white"">Our services</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""service-1"">
                    <span class=""service-1-icon"">
                        <span class=""flaticon-car-1""></span>
                    </span>
                    <div class=""service-1-contents"">
                        <h3>Repair</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam.</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""service-1"">
                    <span class=""service-1-i");
            WriteLiteral(@"con"">
                        <span class=""flaticon-traffic""></span>
                    </span>
                    <div class=""service-1-contents"">
                        <h3>Car Accessories</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam.</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""service-1"">
                    <span class=""service-1-icon"">
                        <span class=""flaticon-valet""></span>
                    </span>
                    <div class=""service-1-contents"">
                        <h3>Own a Car</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""container site-section mb-5"">
    <div class=""row justify-content-center text-ce");
            WriteLiteral(@"nter"">
        <div class=""col-7 text-center mb-5"">
            <h2>How it works</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nemo assumenda, dolorum necessitatibus eius earum voluptates sed!</p>
        </div>
    </div>
    <div class=""how-it-works d-flex"">
        <div class=""step"">
            <span class=""number""><span>01</span></span>
            <span class=""caption"">Time &amp; Place</span>
        </div>
        <div class=""step"">
            <span class=""number""><span>02</span></span>
            <span class=""caption"">Car</span>
        </div>
        <div class=""step"">
            <span class=""number""><span>03</span></span>
            <span class=""caption"">Details</span>
        </div>
        <div class=""step"">
            <span class=""number""><span>04</span></span>
            <span class=""caption"">Checkout</span>
        </div>
        <div class=""step"">
            <span class=""number""><span>05</span></span>
            <span class=""capt");
            WriteLiteral("ion\">Done</span>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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

#pragma checksum "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14d9faf5caa9d129878fd6ee278aeac5bd8e0764"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_Delete), @"mvc.1.0.view", @"/Views/Address/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14d9faf5caa9d129878fd6ee278aeac5bd8e0764", @"/Views/Address/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23e5c7271e3bfef47d7649ca96dc4575677acc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Address_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarRent.Models.Address>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
  
    ViewData["Title"] = Localizer["Delete The Address"];

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
#line 13 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
               Write(Localizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                                    Write(Model.AddressTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <h3>");
#nullable restore
#line 14 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
               Write(Localizer["Are you sure you want to delete this?"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n        </div>\r\n        <div class=\"d-flex action mb-5\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14d9faf5caa9d129878fd6ee278aeac5bd8e07646474", async() => {
#nullable restore
#line 18 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                                                     Write(Localizer["Go back to list"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-lg-12 col-md-12 mb-4\">\r\n            <div class=\"item-1\">\r\n                <div class=\"item-1-contents\">\r\n                    <div class=\"text-center\">\r\n                        <h3>");
#nullable restore
#line 24 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                       Write(Model.AddressTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n                    <ul class=\"specs\">\r\n                        <li>\r\n                            <span class=\"spec2\">");
#nullable restore
#line 28 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                                           Write(Html.DisplayNameFor(model => model.AddressId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"spec spec2\">");
#nullable restore
#line 29 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                                                Write(Model.AddressId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n                        <li>\r\n                            <span class=\"spec2\">");
#nullable restore
#line 32 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                                           Write(Html.DisplayNameFor(model => model.AddressText));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"spec spec2\">");
#nullable restore
#line 33 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                                                Write(Model.AddressText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n                        <li>\r\n                            <span class=\"spec2\">");
#nullable restore
#line 36 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                                           Write(Html.DisplayNameFor(model => model.District.DistrictName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"spec spec2\">");
#nullable restore
#line 37 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                                                Write(Model.District.DistrictName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n                        <li>\r\n                            <span class=\"spec2\">");
#nullable restore
#line 40 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                                           Write(Html.DisplayNameFor(model => model.District.Province.ProvinceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"spec spec2\">");
#nullable restore
#line 41 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                                                Write(Model.District.Province.ProvinceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n                        <li>\r\n                            <span class=\"spec2\">");
#nullable restore
#line 44 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                                           Write(Html.DisplayNameFor(model => model.District.Province.Country.CountryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"spec spec2\">");
#nullable restore
#line 45 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
                                                Write(Model.District.Province.Country.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n                    </ul>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14d9faf5caa9d129878fd6ee278aeac5bd8e076412599", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14d9faf5caa9d129878fd6ee278aeac5bd8e076412870", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 53 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AddressId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 2525, "\"", 2553, 1);
#nullable restore
#line 54 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Address\Delete.cshtml"
WriteAttributeValue("", 2533, Localizer["Delete"], 2533, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarRent.Models.Address> Html { get; private set; }
    }
}
#pragma warning restore 1591

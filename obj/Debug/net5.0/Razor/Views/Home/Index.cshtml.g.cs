#pragma checksum "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5df2b72d8a6b7b5c57f6b1f11b085aff413ca216"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df2b72d8a6b7b5c57f6b1f11b085aff413ca216", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a506c1aa88ad80a36949b47b6582aa790be615", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("trip-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Folders\Videos\Lessons\Web Programlama\web-programlama-proje\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""ftco-blocks-cover-1"">
    <div class=""ftco-cover-1 overlay asdf"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-lg-5"">
                    <div class=""feature-car-rent-box-1"">
                        <h3>Range Rover S7</h3>
                        <ul class=""list-unstyled"">
                            <li>
                                <span>Doors</span>
                                <span class=""spec"">4</span>
                            </li>
                            <li>
                                <span>Seats</span>
                                <span class=""spec"">6</span>
                            </li>
                            <li>
                                <span>Lugage</span>
                                <span class=""spec"">2 Suitcase/2 Bags</span>
                            </li>
                            <li>
                                <span>Transmission</span>
    ");
            WriteLiteral(@"                            <span class=""spec"">Automatic</span>
                            </li>
                            <li>
                                <span>Minium age</span>
                                <span class=""spec"">Automatic</span>
                            </li>
                        </ul>
                        <div class=""d-flex align-items-center bg-light p-3"">
                            <span>$150/day</span>
                            <a href=""contact.html"" class=""ml-auto btn btn-primary"">Rent Now</a>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5df2b72d8a6b7b5c57f6b1f11b085aff413ca2165734", async() => {
                WriteLiteral(@"
                    <div class=""row align-items-center mb-4"">
                        <div class=""col-md-6"">
                            <h3 class=""m-0"">Begin your trip here</h3>
                        </div>
                        <div class=""col-md-6 text-md-right"">
                            <span class=""text-primary"">32</span> <span>cars available</span></span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""form-group col-md-3"">
                            <label for=""cf-1"">Where you from</label>
                            <input type=""text"" id=""cf-1"" placeholder=""Your pickup address"" class=""form-control"">
                        </div>
                        <div class=""form-group col-md-3"">
                            <label for=""cf-2"">Where you go</label>
                            <input type=""text"" id=""cf-2"" placeholder=""Your drop-off address"" class=""form-control"">
                        </di");
                WriteLiteral(@"v>
                        <div class=""form-group col-md-3"">
                            <label for=""cf-3"">Journey date</label>
                            <input type=""text"" id=""cf-3"" placeholder=""Your pickup address"" class=""form-control datepicker px-3"">
                        </div>
                        <div class=""form-group col-md-3"">
                            <label for=""cf-4"">Return date</label>
                            <input type=""text"" id=""cf-4"" placeholder=""Your pickup address"" class=""form-control datepicker px-3"">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <input type=""submit"" value=""Submit"" class=""btn btn-primary"">
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                    <div class=""item-1"">
                        <a href=""#""><img src=""images/img_1.jpg"" alt=""Image"" class=""img-fluid""></a>
                        <div class=""item-1-contents"">
                            <div class=""text-center"">
                            ");
            WriteLiteral(@"    <h3><a href=""#"">Range Rover S64 Coupe</a></h3>
                                <div class=""rating"">
                                    <span class=""icon-star text-warning""></span>
                                    <span class=""icon-star text-warning""></span>
                                    <span class=""icon-star text-warning""></span>
                                    <span class=""icon-star text-warning""></span>
                                    <span class=""icon-star text-warning""></span>
                                </div>
                                <div class=""rent-price""><span>$250/</span>day</div>
                            </div>
                            <ul class=""specs"">
                                <li>
                                    <span>Doors</span>
                                    <span class=""spec"">4</span>
                                </li>
                                <li>
                                    <span>Seats</span>
       ");
            WriteLiteral(@"                             <span class=""spec"">5</span>
                                </li>
                                <li>
                                    <span>Transmission</span>
                                    <span class=""spec"">Automatic</span>
                                </li>
                                <li>
                                    <span>Minium age</span>
                                    <span class=""spec"">18 years</span>
                                </li>
                            </ul>
                            <div class=""d-flex action"">
                                <a href=""contact.html"" class=""btn btn-primary"">Rent Now</a>
                            </div>
                        </div>
                    </div>


                    <div class=""item-1"">
                        <a href=""#""><img src=""images/img_2.jpg"" alt=""Image"" class=""img-fluid""></a>
                        <div class=""item-1-contents"">
                      ");
            WriteLiteral(@"      <div class=""text-center"">
                                <h3><a href=""#"">Range Rover S64 Coupe</a></h3>
                                <div class=""rating"">
                                    <span class=""icon-star text-warning""></span>
                                    <span class=""icon-star text-warning""></span>
                                    <span class=""icon-star text-warning""></span>
                                    <span class=""icon-star text-warning""></span>
                                    <span class=""icon-star text-warning""></span>
                                </div>
                                <div class=""rent-price""><span>$250/</span>day</div>
                            </div>
                            <ul class=""specs"">
                                <li>
                                    <span>Doors</span>
                                    <span class=""spec"">4</span>
                                </li>
                                <li>
  ");
            WriteLiteral(@"                                  <span>Seats</span>
                                    <span class=""spec"">5</span>
                                </li>
                                <li>
                                    <span>Transmission</span>
                                    <span class=""spec"">Automatic</span>
                                </li>
                                <li>
                                    <span>Minium age</span>
                                    <span class=""spec"">18 years</span>
                                </li>
                            </ul>
                            <div class=""d-flex action"">
                                <a href=""contact.html"" class=""btn btn-primary"">Rent Now</a>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>
</div>

<div class=""site-section section-3"" style=""background-image: url('images/her");
            WriteLiteral(@"o_2.jpg');"">
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
                    <span class=""service-1-icon"">
                        <span class=""flaticon-traffic""></span>
                    </span>
                    <div class=""service-1-contents"">
        ");
            WriteLiteral(@"                <h3>Car Accessories</h3>
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
    <div class=""row justify-content-center text-center"">
        <div class=""col-7 text-center mb-5"">
            <h2>How it works</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. ");
            WriteLiteral(@"Nemo assumenda, dolorum necessitatibus eius earum voluptates sed!</p>
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
            <span class=""caption"">Done</span>
        </div>

    </div>
</div>


<div class=""site-section bg-light"">
    <div class=""container"">
        <div class=""row justify-cont");
            WriteLiteral(@"ent-center text-center mb-5"">
            <div class=""col-7 text-center mb-5"">
                <h2>Customer Testimony</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nemo assumenda, dolorum necessitatibus eius earum voluptates sed!</p>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 mb-4 mb-lg-0"">
                <div class=""testimonial-2"">
                    <blockquote class=""mb-4"">
                        <p>""Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatem, deserunt eveniet veniam. Ipsam, nam, voluptatum""</p>
                    </blockquote>
                    <div class=""d-flex v-card align-items-center"">
                        <img src=""images/person_1.jpg"" alt=""Image"" class=""img-fluid mr-3"">
                        <span>Mike Fisher</span>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 mb-4 mb-lg-0"">
                <div class=""");
            WriteLiteral(@"testimonial-2"">
                    <blockquote class=""mb-4"">
                        <p>""Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatem, deserunt eveniet veniam. Ipsam, nam, voluptatum""</p>
                    </blockquote>
                    <div class=""d-flex v-card align-items-center"">
                        <img src=""images/person_2.jpg"" alt=""Image"" class=""img-fluid mr-3"">
                        <span>Jean Stanley</span>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 mb-4 mb-lg-0"">
                <div class=""testimonial-2"">
                    <blockquote class=""mb-4"">
                        <p>""Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatem, deserunt eveniet veniam. Ipsam, nam, voluptatum""</p>
                    </blockquote>
                    <div class=""d-flex v-card align-items-center"">
                        <img src=""images/person_3.jpg"" alt=""Image"" class=""img-fluid mr-3"">
  ");
            WriteLiteral(@"                      <span>Katie Rose</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""site-section bg-white"">
    <div class=""container"">
        <div class=""row justify-content-center text-center mb-5"">
            <div class=""col-7 text-center mb-5"">
                <h2>Our Blog</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nemo assumenda, dolorum necessitatibus eius earum voluptates sed!</p>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-4 col-md-6 mb-4"">
                <div class=""post-entry-1 h-100"">
                    <a href=""single.html"">
                        <img src=""images/post_1.jpg"" alt=""Image""
                             class=""img-fluid"">
                    </a>
                    <div class=""post-entry-1-contents"">

                        <h2><a href=""single.html"">The best car rent in the entire planet</");
            WriteLiteral(@"a></h2>
                        <span class=""meta d-inline-block mb-3"">July 17, 2019 <span class=""mx-2"">by</span> <a href=""#"">Admin</a></span>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores eos soluta, dolore harum molestias consectetur.</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 mb-4"">
                <div class=""post-entry-1 h-100"">
                    <a href=""single.html"">
                        <img src=""images/img_2.jpg"" alt=""Image""
                             class=""img-fluid"">
                    </a>
                    <div class=""post-entry-1-contents"">

                        <h2><a href=""single.html"">The best car rent in the entire planet</a></h2>
                        <span class=""meta d-inline-block mb-3"">July 17, 2019 <span class=""mx-2"">by</span> <a href=""#"">Admin</a></span>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit");
            WriteLiteral(@". Dolores eos soluta, dolore harum molestias consectetur.</p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 col-md-6 mb-4"">
                <div class=""post-entry-1 h-100"">
                    <a href=""single.html"">
                        <img src=""images/img_3.jpg"" alt=""Image""
                             class=""img-fluid"">
                    </a>
                    <div class=""post-entry-1-contents"">

                        <h2><a href=""single.html"">The best car rent in the entire planet</a></h2>
                        <span class=""meta d-inline-block mb-3"">July 17, 2019 <span class=""mx-2"">by</span> <a href=""#"">Admin</a></span>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores eos soluta, dolore harum molestias consectetur.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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

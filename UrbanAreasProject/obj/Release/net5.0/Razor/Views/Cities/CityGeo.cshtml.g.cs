#pragma checksum "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aacdcf838fe9adc3a268d814a04961d9d5d5187d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cities_CityGeo), @"mvc.1.0.view", @"/Views/Cities/CityGeo.cshtml")]
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
#line 1 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\_ViewImports.cshtml"
using UrbanAreasProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml"
using UrbanAreasProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aacdcf838fe9adc3a268d814a04961d9d5d5187d", @"/Views/Cities/CityGeo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1efb079b2394a8119c49901824be0d3093e7dccb", @"/Views/_ViewImports.cshtml")]
    public class Views_Cities_CityGeo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CityGeoLocation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/search.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/city.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/script/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";
    Layout = "~/Views/Search.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aacdcf838fe9adc3a268d814a04961d9d5d5187d5062", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Search</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aacdcf838fe9adc3a268d814a04961d9d5d5187d5467", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aacdcf838fe9adc3a268d814a04961d9d5d5187d6646", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aacdcf838fe9adc3a268d814a04961d9d5d5187d8529", async() => {
                WriteLiteral("\r\n    <div class=\"content\">\r\n");
#nullable restore
#line 18 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml"
         if (Model != null)
        {         

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""info"">
                    <div class=""info__item"">
                        <div class=""descript"">
                            <div class=""descript__item"" data-collapse=""#wedo_1"">
                                <div class=""descript__header"">
                                    <div class=""descript__title""><b>");
#nullable restore
#line 25 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml"
                                                               Write(Model.City.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></div>                          \r\n                                </div>\r\n                                <div class=\"descript__content\">                                \r\n                                    <p><b>Continent: </b>");
#nullable restore
#line 28 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml"
                                                    Write(Model.Continent.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p><b>Population: </b>");
#nullable restore
#line 29 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml"
                                                     Write(Model.City.Population);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p><b>Postcode: </b>");
#nullable restore
#line 30 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml"
                                                   Write(Model.Postcode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p><b>Latitude: </b>");
#nullable restore
#line 31 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml"
                                                   Write(Model.Location.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p><b>Longitude: </b>");
#nullable restore
#line 32 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml"
                                                    Write(Model.Location.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 33 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml"
                                       string coord = $"{Model.Location.Latitude} {Model.Location.Longitude}";

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div style=\"width:500px;position: center;\">\r\n                                        <iframe width=\"500\" height=\"300\"");
                BeginWriteAttribute("src", " src=\"", 1730, "\"", 1869, 3);
                WriteAttributeValue("", 1736, "https://maps.google.com/maps?width=100&amp;height=100&amp;hl=en&amp;q=", 1736, 70, true);
#nullable restore
#line 35 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml"
WriteAttributeValue("", 1806, coord, 1806, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1812, "&amp;ie=UTF8&amp;t=&amp;z=10&amp;iwloc=B&amp;output=embed", 1812, 57, true);
                EndWriteAttribute();
                WriteLiteral(@" frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0"">
                                        </iframe>
                                    </div><br />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 43 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\CityGeo.cshtml"
            }      

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aacdcf838fe9adc3a268d814a04961d9d5d5187d13312", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CityGeoLocation> Html { get; private set; }
    }
}
#pragma warning restore 1591

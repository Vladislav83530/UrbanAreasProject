#pragma checksum "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfaf4ff18b528b6c5579eac1c5b335fcd3515190"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cities_City), @"mvc.1.0.view", @"/Views/Cities/City.cshtml")]
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
#line 1 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
using UrbanAreasProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfaf4ff18b528b6c5579eac1c5b335fcd3515190", @"/Views/Cities/City.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1efb079b2394a8119c49901824be0d3093e7dccb", @"/Views/_ViewImports.cshtml")]
    public class Views_Cities_City : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataCity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/search.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/city.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "rating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/script/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";
    Layout = "~/Views/Search.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfaf4ff18b528b6c5579eac1c5b335fcd35151905936", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Search</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dfaf4ff18b528b6c5579eac1c5b335fcd35151906341", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dfaf4ff18b528b6c5579eac1c5b335fcd35151907520", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfaf4ff18b528b6c5579eac1c5b335fcd35151909403", async() => {
                WriteLiteral("\r\n    <div class=\"content\">\r\n");
#nullable restore
#line 19 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <div class=""info"">
            <div class=""info__item"">
                <div class=""descript"">
                    <div class=""descript__item"" data-collapse=""#wedo_1"">
                        <div class=""descript__header"">
                            <div class=""descript__title""><b>");
#nullable restore
#line 28 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></div>\r\n                            <div class=\"descript__title\"><b>");
#nullable restore
#line 29 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
                                                       Write(item.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></div>\r\n                        </div>\r\n                        <div class=\"descript__content\">\r\n                            <p><b>Country: </b> ");
#nullable restore
#line 32 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
                                           Write(item.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <p><b>Region: </b> ");
#nullable restore
#line 33 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
                                          Write(item.Region);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <p><b>Population: </b> ");
#nullable restore
#line 34 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
                                              Write(item.Population);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <p><b>WikiDataId: </b> ");
#nullable restore
#line 35 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
                                              Write(item.WikiDataId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <p><b>Latitude: </b>");
#nullable restore
#line 36 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
                                           Write(item.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <p><b>Longitude: </b>");
#nullable restore
#line 37 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
                                            Write(item.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 38 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
                               string coord = $"{item.Latitude} {item.Longitude}";

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div style=\"width:500px;position: center;\">\r\n                                <iframe width=\"500\" height=\"300\"");
                BeginWriteAttribute("src", " src=\"", 1694, "\"", 1833, 3);
                WriteAttributeValue("", 1700, "https://maps.google.com/maps?width=100&amp;height=100&amp;hl=en&amp;q=", 1700, 70, true);
#nullable restore
#line 40 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
WriteAttributeValue("", 1770, coord, 1770, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1776, "&amp;ie=UTF8&amp;t=&amp;z=10&amp;iwloc=B&amp;output=embed", 1776, 57, true);
                EndWriteAttribute();
                WriteLiteral(" frameborder=\"0\" scrolling=\"no\" marginheight=\"0\" marginwidth=\"0\">\r\n                                </iframe>\r\n                            </div><br />\r\n                        </div>\r\n                    </div>                  \r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfaf4ff18b528b6c5579eac1c5b335fcd351519014335", async() => {
                    WriteLiteral("\r\n                        <input style=\"display: none\" type=\"number\" name=\"Id\"");
                    BeginWriteAttribute("value", " value=\"", 2209, "\"", 2225, 1);
#nullable restore
#line 46 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
WriteAttributeValue("", 2217, item.Id, 2217, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                        <input style=\"display: none\" type=\"text\" name=\"Name\"");
                    BeginWriteAttribute("value", " value=\"", 2307, "\"", 2325, 1);
#nullable restore
#line 47 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
WriteAttributeValue("", 2315, item.Name, 2315, 10, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                        <input style=\"display: none\" type=\"text\" name=\"Country\"");
                    BeginWriteAttribute("value", " value=\"", 2410, "\"", 2431, 1);
#nullable restore
#line 48 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
WriteAttributeValue("", 2418, item.Country, 2418, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                        <input style=\"display: none\" type=\"text\" name=\"Region\"");
                    BeginWriteAttribute("value", " value=\"", 2515, "\"", 2535, 1);
#nullable restore
#line 49 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
WriteAttributeValue("", 2523, item.Region, 2523, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                        <input style=\"display: none\" type=\"number\" name=\"Population\"");
                    BeginWriteAttribute("value", " value=\"", 2625, "\"", 2649, 1);
#nullable restore
#line 50 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
WriteAttributeValue("", 2633, item.Population, 2633, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                        <input style=\"display: none\" type=\"text\" name=\"Latitude\"");
                    BeginWriteAttribute("value", " value=\"", 2735, "\"", 2757, 1);
#nullable restore
#line 51 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
WriteAttributeValue("", 2743, item.Latitude, 2743, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                        <input style=\"display: none\" type=\"text\" name=\"Longitude\"");
                    BeginWriteAttribute("value", " value=\"", 2844, "\"", 2867, 1);
#nullable restore
#line 52 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
WriteAttributeValue("", 2852, item.Longitude, 2852, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                        <input class=\"dws-submit\" type=\"submit\" value=\"Add\" />\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>         \r\n        </div>\r\n");
#nullable restore
#line 58 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\GitHub\UrbanAreasProject\UrbanAreasProject\Views\Cities\City.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfaf4ff18b528b6c5579eac1c5b335fcd351519020038", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataCity>> Html { get; private set; }
    }
}
#pragma warning restore 1591

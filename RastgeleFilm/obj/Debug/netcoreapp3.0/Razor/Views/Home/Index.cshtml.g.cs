#pragma checksum "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89f710f8197a8210c505937ea32bae53a8e5589e"
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
#line 1 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\_ViewImports.cshtml"
using RastgeleFilm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\_ViewImports.cshtml"
using RastgeleFilm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89f710f8197a8210c505937ea32bae53a8e5589e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09bd2a3cd134b08f32de1bca20584f90a8601136", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RastgeleFilm.Models.Film>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("video/mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("600"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Anasayfa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"main-section\" style=\"background-color:black\" id=\"filmSayfasi\">\r\n    <!--main-section-start-->\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 9 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
         foreach (var name in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>");
#nullable restore
#line 11 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
           Write(name.FilmAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h6>Imdb Puanı: ");
#nullable restore
#line 12 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
                       Write(name.FilmPuan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 13 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89f710f8197a8210c505937ea32bae53a8e5589e7082", async() => {
                WriteLiteral("Filmi Değiştir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm\">\r\n");
#nullable restore
#line 19 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
                 foreach (var movie in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!--Video Başlangıç Kısmı-->
                    <div id=""carouselExampleSlidesOnly"" class=""carousel slide"" data-ride=""carousel"">
                        <div class=""carousel-inner"">
                            <div class=""carousel-item active"">
                                <video controls width=""600"" height=""300"" autoplay>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "89f710f8197a8210c505937ea32bae53a8e5589e9261", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1119, "~/video/", 1119, 8, true);
#nullable restore
#line 26 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1127, movie.VideoYolu, 1127, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1167, movie.FilmAd, 1167, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    Video Yüklenemedi.\r\n                                </video>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <!--Video Bitiş Kısmı-->\r\n");
#nullable restore
#line 33 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-sm\">\r\n");
#nullable restore
#line 36 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
                 foreach (var gorsel in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "89f710f8197a8210c505937ea32bae53a8e5589e12109", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1619, "~/img/", 1619, 6, true);
#nullable restore
#line 38 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1625, gorsel.ResimYolu, 1625, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"col-sm\">\r\n            <h3>FİLMİN KONUSU</h3>\r\n");
#nullable restore
#line 46 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
             foreach (var acikla in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
           Write(acikla.FilmAciklama);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\CASPER\Documents\bsm-web-2019-caneral\RastgeleFilm\Views\Home\Index.cshtml"
                                                                                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n<!--main-section-end-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RastgeleFilm.Models.Film>> Html { get; private set; }
    }
}
#pragma warning restore 1591

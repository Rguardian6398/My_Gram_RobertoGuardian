#pragma checksum "/Users/robertoguardian154gmail.com/Desktop/My_Gram_Roberto_Guardian/My_GramProfileRG/My_GramProfileRG/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bc296b03e5895e9b72809bd420a7c1a349583d8"
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
#line 1 "/Users/robertoguardian154gmail.com/Desktop/My_Gram_Roberto_Guardian/My_GramProfileRG/My_GramProfileRG/Views/_ViewImports.cshtml"
using My_GramProfileRG;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/robertoguardian154gmail.com/Desktop/My_Gram_Roberto_Guardian/My_GramProfileRG/My_GramProfileRG/Views/_ViewImports.cshtml"
using My_GramProfileRG.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bc296b03e5895e9b72809bd420a7c1a349583d8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a41a73901d1e0839bcdb299dcd4cfb355d4ef54", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ProfileStyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/SignUp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/robertoguardian154gmail.com/Desktop/My_Gram_Roberto_Guardian/My_GramProfileRG/My_GramProfileRG/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9bc296b03e5895e9b72809bd420a7c1a349583d84483", async() => {
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
            WriteLiteral("\n\n<div class=\"text-center\">\n    <div id=\"header\">\n        My Gram\n            <input type=\"text\" placeholder=\"Search\">\n            <button id=\"submit\" type=\"submit\">Log In</button>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bc296b03e5895e9b72809bd420a7c1a349583d85790", async() => {
                WriteLiteral("<button id=\"submit\" type=\"submit\">SignUp</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
    <div id=""MainContainer"">
        <div class=""MainTableClass"">
            <div class=""Span3Row"">
                <img id=""ProfileImage"" style=""width: 190px;height: 190px;"" src=""https://www.desktopbackground.org/download/480x800/2011/10/08/277967_12-kamen-rider-ooo-hd-wallpapers_1500x1125_h.jpg"" />
                <div>
                    Roberto Guardian<button id=""submit"" type=""submit"">Follow</button>
                    <br />
                    <span>5 posts</span>
                    <span>10 Followers</span>
                    <span>20 Following</span>
                    <br>
                    <p style=""font-size:90%;"">
                        Welcome to my profile, my name is Roberto Guardian, I am 19-years-old, I like to watch anime and youtube.
                        Team Godzilla for life, I like to draw, create stuff with my legos, and soon make stuff with a 3D Printer. When I grow up I
                        hope to have a small business in graphic design, while selling some");
            WriteLiteral(@" 3d printed stuff and sone drawings while doing youtube (as a hobby).
                    </p>
                </div>
            </div>
            <div class=""Span2Columns"">
                   <img id=""ProfileImage"" style=""width: 150px;height: 150px;"" src=""https://2.bp.blogspot.com/-AwXiGfj9k2s/XLTzKdCHKlI/AAAAAAAABiQ/KIIOTkAimNkV0CHHpYX8jzaY-9CLl7NqACKgBGAs/w914/godzilla-king-of-the-monsters-uhdpaper.com-4K-9.jpg"" />
                    My Favorite Movie Is Godzilla
                   <img id=""ProfileImage"" style=""width: 150px;height: 150px;"" src=""https://wallpaperaccess.com/full/1109423.jpg"" />
                    My Favorite Anime Is ""Darling In The FranXX""
                   <img id=""ProfileImage"" style=""width: 150px;height: 150px;"" src=""https://i.pinimg.com/originals/e5/2f/2f/e52f2fd10f583fb5c2f197fa0d033660.jpg"" />
                    My Favorite T.V Show Is Ben 10
            </div>
            <div>
                <span>Posts</span>
                <span>Reels</span>
                <span>IGTV</spa");
            WriteLiteral(@"n>
                <span>Tagged</span>
            </div>
            <div class=""Posts"">
                <img style=""width: 200px;height: 250px;"" src=""https://i.pinimg.com/736x/14/4f/17/144f17cc3ab198ab0986cb86afddb19f.jpg"" />
                <img style=""width: 200px;height: 250px;"" src=""https://i.pinimg.com/originals/7b/4f/cf/7b4fcfbc2437df1d34b5343622754ce3.jpg"" />
                <img style=""width: 200px;height: 250px;"" src=""https://artfiles.alphacoders.com/124/124377.jpg"" />
                <img style=""width: 200px;height: 250px;"" src=""https://mfiles.alphacoders.com/773/773500.jpg"" />
                <img style=""width: 200px;height: 250px;"" src=""https://wallpapercave.com/wp/wp2683038.jpg"" />
                <img style=""width: 200px;height: 250px;"" src=""https://i.pinimg.com/originals/82/ea/f0/82eaf0e7994959b33cca82075dee7a15.jpg"" />
                <img style=""width: 200px;height: 250px;"" src=""https://i.redd.it/av9xzd7jf0i51.jpg"" />
                <img style=""width: 200px;height: 250px;"" src=""https://r1.");
            WriteLiteral(@"ilikewallpaper.net/iphone-x-wallpapers/download/82278/artwork-godzilla-king-of-the-monsters-iphone-x-wallpaper-ilikewallpaper_com.jpg"" />
                <img style=""width: 200px;height: 250px;"" src=""https://cdn.wallpapersafari.com/79/0/qSuEgk.jpg"" /></td>
                <img style=""width: 200px;height: 250px;"" src=""https://i.pinimg.com/originals/e3/ed/34/e3ed3423462f4db7cfaa83221c1a7ce4.jpg"" />
                <img style=""width: 200px;height: 250px;"" src=""https://external-preview.redd.it/EnDRtV0e1Lvci_-_gPf8R4148ZEh_rr1u1RpRBnwPzE.jpg?auto=webp&s=ee006b870e3caa8a6916706880974a37ac87c785"" />
                <img style=""width: 200px;height: 250px;"" src=""https://i.pinimg.com/736x/f8/94/be/f894beaee6ccc93bf5de570fa163e685.jpg"" />
            </div>
        </div>
    </div>
</div>");
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

#pragma checksum "C:\Users\MSI\Desktop\20 MarTask\fullscreen\fullscreen\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08aabb09f227c60668dda9a52a5fd3b66a749f07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\MSI\Desktop\20 MarTask\fullscreen\fullscreen\Views\_ViewImports.cshtml"
using fullscreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MSI\Desktop\20 MarTask\fullscreen\fullscreen\Views\_ViewImports.cshtml"
using fullscreen.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08aabb09f227c60668dda9a52a5fd3b66a749f07", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"890ce96967c7703488a6ac64d154c42eeff9f355", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08aabb09f227c60668dda9a52a5fd3b66a749f073271", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"" />
    <title>B A U E N</title>
    <link rel=""shortcut icon"" href=""img/favicon.png"" />
    <link rel=""stylesheet"" href=""css/plugins.css"" />
    <link rel=""stylesheet"" href=""css/style.css"" />
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08aabb09f227c60668dda9a52a5fd3b66a749f074637", async() => {
                WriteLiteral(@"
    
    <div id=""preloader""></div>
    
    <div class=""progress-wrap cursor-pointer"">
        <svg class=""progress-circle svg-content"" width=""100%"" height=""100%"" viewBox=""-1 -1 102 102"">
            <path d=""M50,1 a49,49 0 0,1 0,98 a49,49 0 0,1 0,-98"" />
        </svg>
    </div>
    
    <nav class=""navbar navbar-expand-lg"">
        <div class=""container"">
        
        <a class=""logo"" href=""index.html""> <img src=""img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 889, "\"", 895, 0);
                EndWriteAttribute();
                WriteLiteral(@"> </a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation""> <span class=""icon-bar""><i class=""ti-line-double""></i></span> </button>
        
        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav ml-auto"">
                <li class=""nav-item""><a class=""nav-link active"" href=""#"" data-scroll-nav=""0"">Home</a></li>
                <li class=""nav-item""><a class=""nav-link"" href=""#"" data-scroll-nav=""1"">About</a></li>
                <li class=""nav-item""><a class=""nav-link"" href=""#"" data-scroll-nav=""2"">Projects</a></li>
                <li class=""nav-item""><a class=""nav-link"" href=""#"" data-scroll-nav=""3"">Services</a></li>
                <li class=""nav-item""><a class=""nav-link"" href=""#"" data-scroll-nav=""4"">Blog</a></li>
                <li class=""nav-item""><a class=""nav-link"" href=""#"" data-scroll-nav=""5""");
                WriteLiteral(">Contact</a></li>\r\n            </ul>\r\n        </div>\r\n        </div>\r\n    </nav>\r\n    \r\n   ");
#nullable restore
#line 43 "C:\Users\MSI\Desktop\20 MarTask\fullscreen\fullscreen\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        
        <footer class=""main-footer dark"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4 mb-30"">
                        <div class=""item fotcont"">
                            <div class=""fothead"">
                                <h6>Phone</h6>
                            </div>
                            <p>+1 203-123-0606</p>
                        </div>
                    </div>
                    <div class=""col-md-4 mb-30"">
                        <div class=""item fotcont"">
                            <div class=""fothead"">
                                <h6>Email</h6>
                            </div>
                            <p>architecture@bauen.com</p>
                        </div>
                    </div>
                    <div class=""col-md-4 mb-30"">
                        <div class=""item fotcont"">
                            <div class=""fothead"">
                                <h6>Our");
                WriteLiteral(@" Address</h6>
                            </div>
                            <p>24 King St, Charleston, SC 29401 USA</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""sub-footer"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""text-left"">
                                <p>© 2021 Bauen. All right reserved.</p>
                            </div>
                        </div>
                        <div class=""col-md-4 abot"">
                            <div class=""social-icon""> <a href=""index.html""><i class=""ti-facebook""></i></a> <a href=""index.html""><i class=""ti-twitter""></i></a> <a href=""index.html""><i class=""ti-instagram""></i></a> <a href=""index.html""><i class=""ti-pinterest""></i></a> </div>
                        </div>
                        <div class=""col-md-4"">
                           ");
                WriteLiteral(@" <p class=""right""><a href=""#"">Terms &amp; Conditions</a></p>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
    
    <!-- jQuery -->
    <script src=""js/jquery-3.5.1.min.js""></script>
    <script src=""js/jquery-migrate-3.0.0.min.js""></script>
    <script src=""js/modernizr-2.6.2.min.js""></script>
    <script src=""js/pace.js""></script>
    <script src=""js/popper.min.js""></script>
    <script src=""js/bootstrap.min.js""></script>
    <script src=""js/scrollIt.min.js""></script>
    <script src=""js/jquery.waypoints.min.js""></script>
    <script src=""js/owl.carousel.min.js""></script>
    <script src=""js/jquery.stellar.min.js""></script>
    <script src=""js/jquery.magnific-popup.js""></script>
    <script src=""js/YouTubePopUp.js""></script>
    <script src=""js/custom.js""></script>
");
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
            WriteLiteral("\r\n</html>");
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

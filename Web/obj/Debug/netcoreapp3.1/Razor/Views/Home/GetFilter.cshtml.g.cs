#pragma checksum "G:\Users\GTA\Documents\Github\blogDemoCom\Web\Views\Home\GetFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90acf02d2ec3bcf48eded0fd2d230370b6f9d427"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetFilter), @"mvc.1.0.view", @"/Views/Home/GetFilter.cshtml")]
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
#line 1 "G:\Users\GTA\Documents\Github\blogDemoCom\Web\Views\_ViewImports.cshtml"
using blogDemoCom.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Users\GTA\Documents\Github\blogDemoCom\Web\Views\_ViewImports.cshtml"
using blogDemoCom.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Users\GTA\Documents\Github\blogDemoCom\Web\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90acf02d2ec3bcf48eded0fd2d230370b6f9d427", @"/Views/Home/GetFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c16dbeeefdd6eebf73573a6c7d7dfeb5a6993ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.Domain.Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("building"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "G:\Users\GTA\Documents\Github\blogDemoCom\Web\Views\Home\GetFilter.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <article class=\"brick entry format-standard animate-this\">\r\n      <div class=\"entry-thumb\">\r\n          <a href=\"single-standard.html\" class=\"thumb-link\">\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "90acf02d2ec3bcf48eded0fd2d230370b6f9d4274084", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 312, "~/postImages/", 312, 13, true);
#nullable restore
#line 10 "G:\Users\GTA\Documents\Github\blogDemoCom\Web\Views\Home\GetFilter.cshtml"
AddHtmlAttributeValue("", 325, item.Image, 325, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("             \r\n          </a>\r\n      </div>\r\n      <div class=\"entry-text\">\r\n          <div class=\"entry-header\">\r\n              <div class=\"entry-meta\">\r\n                  <span class=\"cat-links\">\r\n                      <a href=\"#\">");
#nullable restore
#line 17 "G:\Users\GTA\Documents\Github\blogDemoCom\Web\Views\Home\GetFilter.cshtml"
                             Write(item.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> \r\n                      <a href=\"#\">");
#nullable restore
#line 18 "G:\Users\GTA\Documents\Github\blogDemoCom\Web\Views\Home\GetFilter.cshtml"
                             Write(item.UpdateTime.ToString("dd.MM.yyyy hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>               \t\t\t\t\r\n                  </span>\t\t\t\r\n              </div>\r\n              <h1 class=\"entry-title\"><a href=\"single-standard.html\">");
#nullable restore
#line 21 "G:\Users\GTA\Documents\Github\blogDemoCom\Web\Views\Home\GetFilter.cshtml"
                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h1>               \t\t\r\n          </div>\r\n            <div class=\"entry-excerpt\">\r\n                ");
#nullable restore
#line 24 "G:\Users\GTA\Documents\Github\blogDemoCom\Web\Views\Home\GetFilter.cshtml"
           Write(Html.Raw(item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n      </div>\r\n  </article>\r\n");
#nullable restore
#line 28 "G:\Users\GTA\Documents\Github\blogDemoCom\Web\Views\Home\GetFilter.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.Domain.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25517a4b68c2e36dd0906cff20e0ddfe4bc17340"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PostList), @"mvc.1.0.view", @"/Views/Shared/_PostList.cshtml")]
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
#line 1 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/_ViewImports.cshtml"
using blogDemoCom.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/_ViewImports.cshtml"
using blogDemoCom.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
using Data.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25517a4b68c2e36dd0906cff20e0ddfe4bc17340", @"/Views/Shared/_PostList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dc370d642caf89d86c0d16dae0ccfcf68a6193f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PostList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.PagedList<Data.Domain.Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n  <h1 class=\"my-4\">Blog Demo\r\n    <small>.Net Core 3.1 MVC Blog Projesi</small>\r\n  </h1>\r\n\r\n  <!-- Blog Post -->\r\n");
#nullable restore
#line 11 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
   foreach (var item in Model)
  {                                   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card mb-4\">\r\n      <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 375, "\"", 399, 2);
            WriteAttributeValue("", 381, "http://", 381, 7, true);
#nullable restore
#line 14 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
WriteAttributeValue("", 388, item.Image, 388, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n      <div class=\"card-body\">\r\n        <h2 class=\"card-title\">");
#nullable restore
#line 16 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p class=\"card-text\">");
#nullable restore
#line 17 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
                        Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 562, "\"", 588, 2);
            WriteAttributeValue("", 569, "/Home/Post/", 569, 11, true);
#nullable restore
#line 18 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
WriteAttributeValue("", 580, item.Id, 580, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Postu oku! &rarr;</a>\r\n      </div>\r\n      <div class=\"card-footer text-muted\">\r\n        Posted on ");
#nullable restore
#line 21 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
             Write(item.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" by\r\n        <a href=\"#\">");
#nullable restore
#line 22 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
               Write(item.AuthorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n      </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n  <!-- Pagination -->\r\n  <div class=\"row\">\r\n    <div class=\"col-xs-12 sayfalama\">\r\n        <div class=\"sayfalama-bilgi\">Toplam <span>");
#nullable restore
#line 31 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
                                             Write(Model.TotalItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> Kayıt Bulunuyor. Şu anda <span>");
#nullable restore
#line 31 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
                                                                                                         Write(Model.FirstItemOnPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> - <span>");
#nullable restore
#line 31 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
                                                                                                                                               Write(Model.LastItemOnPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> Arasındaki Kayıtlar Gösteriliyor. </div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25517a4b68c2e36dd0906cff20e0ddfe4bc173407684", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
#nullable restore
#line 33 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 33 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/_PostList.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedList.Core.Mvc.PagedListRenderOptions.Bootstrap4PageNumbersOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n  </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.PagedList<Data.Domain.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591

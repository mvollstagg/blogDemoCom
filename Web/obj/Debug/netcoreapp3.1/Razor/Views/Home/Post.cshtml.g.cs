#pragma checksum "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2450a7a427ae93ab69f1d613d7b9086cafe13a65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2450a7a427ae93ab69f1d613d7b9086cafe13a65", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dc370d642caf89d86c0d16dae0ccfcf68a6193f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Domain.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"col-lg-8\">\n    <h1 class=\"mt-4\">");
#nullable restore
#line 6 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Post.cshtml"
                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <p class=\"lead\">\n        by\n        <a href=\"#\">");
#nullable restore
#line 9 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Post.cshtml"
               Write(Model.AuthorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n    </p>\n    <hr>\n    <p>Yayın Tarihi: ");
#nullable restore
#line 12 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Post.cshtml"
                Write(Model.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <hr>\n    <img class=\"img-fluid rounded\"");
            BeginWriteAttribute("src", " src=\"", 351, "\"", 376, 2);
            WriteAttributeValue("", 357, "http://", 357, 7, true);
#nullable restore
#line 14 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Post.cshtml"
WriteAttributeValue("", 364, Model.Image, 364, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 377, "\"", 383, 0);
            EndWriteAttribute();
            WriteLiteral(">\n    <hr>   \n        ");
#nullable restore
#line 16 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Post.cshtml"
   Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <hr>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Domain.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591

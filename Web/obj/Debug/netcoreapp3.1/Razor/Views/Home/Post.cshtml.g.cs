#pragma checksum "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ed2c229e7be4cc1d7d9434a0e0633620f7f92bf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ed2c229e7be4cc1d7d9434a0e0633620f7f92bf", @"/Views/Home/Post.cshtml")]
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
            WriteLiteral(">\n    <hr>\n    <p class=\"lead\">");
#nullable restore
#line 16 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Post.cshtml"
               Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ducimus, vero, obcaecati, aut, error quam sapiente nemo saepe quibusdam sit excepturi nam quia corporis eligendi eos magni recusandae laborum minus inventore?</p>

    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.</p>

    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eos, doloribus, dolorem iusto blanditiis unde eius illum consequuntur neque dicta incidunt ullam ea hic porro optio ratione repellat perspiciatis. Enim, iure!</p>

    <blockquote class=""blockquote"">
        <p class=""mb-0"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
        <footer class=""blockquote-footer"">Someone famous in
        <cite title=""Source Title"">Source Title</cite>
        </footer>
    </blockquote>

    <p>Lorem ipsum dolor sit amet, consect");
            WriteLiteral(@"etur adipisicing elit. Error, nostrum, aliquid, animi, ut quas placeat totam sunt tempora commodi nihil ullam alias modi dicta saepe minima ab quo voluptatem obcaecati?</p>

    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Harum, dolor quis. Sunt, ut, explicabo, aliquam tenetur ratione tempore quidem voluptates cupiditate voluptas illo saepe quaerat numquam recusandae? Qui, necessitatibus, est!</p>

    <hr>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Domain.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591

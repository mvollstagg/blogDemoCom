#pragma checksum "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Shared/AdminPanel/_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34a8c10a03a7bb05e4a47916ce80312f28e4e2f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AdminPanel__Header), @"mvc.1.0.view", @"/Views/Shared/AdminPanel/_Header.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a8c10a03a7bb05e4a47916ce80312f28e4e2f2", @"/Views/Shared/AdminPanel/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dc370d642caf89d86c0d16dae0ccfcf68a6193f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AdminPanel__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"sb-topnav navbar navbar-expand navbar-dark bg-dark\">\n    <a class=\"navbar-brand\" href=\"index\">Blog Admin Panel</a>\n");
            WriteLiteral(@"    <!-- Navbar-->
    <div class=""ml-auto mr-0 mr-md-3 my-2 my-md-0""></div>
    <ul class=""navbar-nav ml-auto ml-md-0"">
        <li class=""nav-item dropdown"">
            <a class=""nav-link dropdown-toggle"" id=""userDropdown"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""fas fa-user fa-fw""></i></a>
            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
                <a class=""dropdown-item"" href=""Settings"">Ayarlar</a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""javascript:null"" onclick=""logOut()"">Çıkış</a>
            </div>
        </li>
    </ul>
</nav>

<script>
    function logOut() {
        window.location.href = ""/AdminPanel/Cikis"";
    }


</script>");
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

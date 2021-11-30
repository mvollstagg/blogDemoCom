#pragma checksum "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75737de8ced6ce8e7b0cefa10ab423e142f6cad6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_PostSettings), @"mvc.1.0.view", @"/Views/AdminPanel/PostSettings.cshtml")]
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
#line 1 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/_ViewImports.cshtml"
using blogDemoCom.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/_ViewImports.cshtml"
using blogDemoCom.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
using Data.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75737de8ced6ce8e7b0cefa10ab423e142f6cad6", @"/Views/AdminPanel/PostSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9d57a9360343ebb2a5271d431bb122f4fd97e9", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminPanel_PostSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.PagedList<Data.Domain.Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostSettings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
  
    Layout = "~/Views/Shared/AdminPanel/_AdminPanelLayout.cshtml";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<hr>
<div id=""layoutAuthentication_content"">
    <main>
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-12"">
                    <table class=""table table-bordered table-hover"">
                        <thead class=""thead-dark"">
                            <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Başlık</th>
                            <th scope=""col"">Yazar</th>
                            <th scope=""col"">Son Düzenleme Tarihi</th>
                            <th scope=""col"">İşlemler</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 26 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                              int sayac = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                             foreach (var item in Model)
                            {                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <th scope=\"row\">");
#nullable restore
#line 30 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                                               Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <td>");
#nullable restore
#line 31 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 32 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                                   Write(item.AuthorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 33 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                                   Write(item.UpdateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td><a href=\"#\" class=\"text-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1468, "\"", 1512, 6);
            WriteAttributeValue("", 1478, "postSil(\'", 1478, 9, true);
#nullable restore
#line 34 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
WriteAttributeValue("", 1487, item.Title, 1487, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1498, "\',", 1498, 2, true);
            WriteAttributeValue(" ", 1500, "\'", 1501, 2, true);
#nullable restore
#line 34 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
WriteAttributeValue("", 1502, item.Id, 1502, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1510, "\')", 1510, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash\"></i> Sil</a> | \n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1596, "\"", 1632, 2);
            WriteAttributeValue("", 1603, "/AdminPanel/PostEdit/", 1603, 21, true);
#nullable restore
#line 35 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
WriteAttributeValue("", 1624, item.Id, 1624, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i> Düzenle</a> | \n");
#nullable restore
#line 36 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                                         if(item.Status){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a href=\"#\" class=\"text-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1810, "\"", 1848, 3);
            WriteAttributeValue("", 1820, "postStatusToggle(\'", 1820, 18, true);
#nullable restore
#line 37 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
WriteAttributeValue("", 1838, item.Id, 1838, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1846, "\')", 1846, 2, true);
            EndWriteAttribute();
            WriteLiteral(" ><i class=\"fas fa-toggle-on\"></i> Görünmez Yap</a>\n");
#nullable restore
#line 38 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                                        }else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a href=\"#\" class=\"text-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2065, "\"", 2103, 3);
            WriteAttributeValue("", 2075, "postStatusToggle(\'", 2075, 18, true);
#nullable restore
#line 40 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
WriteAttributeValue("", 2093, item.Id, 2093, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2101, "\')", 2101, 2, true);
            EndWriteAttribute();
            WriteLiteral(" ><i class=\"fas fa-toggle-off\"></i> Görünür Yap</a>\n");
#nullable restore
#line 41 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         |\n                                        <a class=\"text-info\"");
            BeginWriteAttribute("href", " href=\"", 2301, "\"", 2327, 2);
            WriteAttributeValue("", 2308, "/Home/Post/", 2308, 11, true);
#nullable restore
#line 43 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
WriteAttributeValue("", 2319, item.Id, 2319, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-eye\"></i> Görüntüle</a>\n                                    </td>\n                                </tr> \n");
#nullable restore
#line 46 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                                sayac++; 
                            }                          

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>

            <div class=""row"">      
                <div class=""col-12"">
                    <a href=""/AdminPanel/PostAdd"" class=""btn btn-success btn-lg btn-block"">Yeni Post Ekle!</a>
                </div> 
            </div>
            <br>
            
             <!-- Pagination -->
            <div class=""row"">
                <div class=""col-xs-12 sayfalama"">
                    <div class=""sayfalama-bilgi"">Toplam <span>");
#nullable restore
#line 63 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                                                         Write(Model.TotalItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> Kayıt Bulunuyor. Şu anda <span>");
#nullable restore
#line 63 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                                                                                                                     Write(Model.FirstItemOnPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> - <span>");
#nullable restore
#line 63 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
                                                                                                                                                           Write(Model.LastItemOnPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> Arasındaki Kayıtlar Gösteriliyor. </div>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "75737de8ced6ce8e7b0cefa10ab423e142f6cad613017", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
#nullable restore
#line 64 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 64 "/Users/matthieuvollstagg/Documents/GitHub/blogDemoCom/Web/Views/AdminPanel/PostSettings.cshtml"
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
            WriteLiteral(@"
                </div>
            </div>

        </div>
    </main>
</div>

<script type=""text/javascript"">
    function postSil(title, id) {        
        Swal.fire({
            title: 'Dikkat!',
            icon: 'warning',
            html: '<b>' + title + '</b>, başlıklı postu silmek istediğinize emin misiniz?',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Onayla!',
            cancelButtonText: 'İptal'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                url: '/AdminPanel/PostSil',
                data: { Id: id },
                type: 'post',
                dataType: 'json',
                success: function (data) {
                    Swal.fire({
                        icon: 'success',
                        title: 'Başarılı!',
                        text: 'Post silindi!',
                        customClass: 'swal-resetPassword',
 ");
            WriteLiteral(@"                       showConfirmButton: false,
                        timer: 5000
                    })
                    location.replace(""/AdminPanel/PostSettings/"")
                },
                error: function (data) {
                    Swal.fire('Sistem Hatası!', '', 'error')
                }
            });
            }
        })
    }
    function postStatusToggle(id) {  
        toastr.options = {
        ""closeButton"": false,
        ""debug"": false,
        ""newestOnTop"": true,
        ""progressBar"": true,
        ""positionClass"": ""toast-top-right"",
        ""preventDuplicates"": false,
        ""onclick"": null,
        ""showDuration"": ""300"",
        ""hideDuration"": ""1000"",
        ""timeOut"": ""5000"",
        ""extendedTimeOut"": ""1000"",
        ""showEasing"": ""swing"",
        ""hideEasing"": ""linear"",
        ""showMethod"": ""fadeIn"",
        ""hideMethod"": ""fadeOut""
        }

        $.ajax({
            url: '/AdminPanel/PostStatusToggle',
            data: { Id: id },
            type: 'post");
            WriteLiteral(@"',
            dataType: 'json',
            success: function (data) {
                if(data.postStatus){
                    toastr.success('Postun görünürlüğü açıldı!')
                }else
                {
                    toastr.error('Postun görünürlüğü kapatıldı!')
                }
                location.reload();
            },
            error: function (data) {
                toastr.error('Sistem hatası. Lütfen daha sonra tekrar deneyiniz!')
            }
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.PagedList<Data.Domain.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "018d231c97f382928e06d0f6208074d6ec6f068d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018d231c97f382928e06d0f6208074d6ec6f068d", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dc370d642caf89d86c0d16dae0ccfcf68a6193f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/CreateUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-failure", new global::Microsoft.AspNetCore.Html.HtmlString("OnFailure"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("Contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Register.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    <button type=""button"" class=""btn btn-success"" onclick=""testScript()"">Test Ajax Request (Create User)</button>
</div>

<div>
    <div class=""col-md-2 col-sm-12""></div>
    <div class=""col-md-8 col-sm-12""></div>        
    <div class=""col-md-2 col-sm-12""></div>
</div>

<div>
    <br>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "018d231c97f382928e06d0f6208074d6ec6f068d6254", async() => {
                WriteLiteral(@"
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
            <label for=""inputName"">Ad</label>
            <input type=""text"" placeholder=""Adınızı Giriniz"" name=""Name"">
            </div>
            <div class=""form-group col-md-6"">
            <label for=""inputLastName"">Soyad</label>
            <input type=""text"" placeholder=""Soyadınızı Giriniz"" name=""LastName"">
            </div>
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
            <label for=""inputEmail"">Email</label>
            <input type=""text"" placeholder=""Mail Giriniz"" name=""Email"">
            </div>
            <div class=""form-group col-md-6"">
            <label for=""inputEmail"">Email</label>
            <input type=""text"" placeholder=""Mail Giriniz"" name=""Password"">
            </div>
        </div>
        
        <div class=""form-group"">
");
#nullable restore
#line 42 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Register.cshtml"
               
                Random rnd = new Random();
                int sayi1 = rnd.Next(1, 10);
                int sayi2 = rnd.Next(1, 10);
                int toplam =sayi1+sayi2;
            

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1846, "\"", 1861, 1);
#nullable restore
#line 48 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Register.cshtml"
WriteAttributeValue("", 1854, toplam, 1854, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"validationcheck\" style=\"display:none\" />\r\n            <div class=\"col-xs-8\">\r\n            <input type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1977, "\"", 2044, 9);
#nullable restore
#line 50 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Register.cshtml"
WriteAttributeValue("", 1991, sayi1, 1991, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("  ", 1997, "+", 1999, 3, true);
#nullable restore
#line 50 "/Users/mvollstagg/Desktop/web/blogDemoCom/Web/Views/Home/Register.cshtml"
WriteAttributeValue(" ", 2000, sayi2, 2001, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("  ", 2007, "=", 2009, 3, true);
                WriteAttributeValue(" ", 2010, "?", 2011, 2, true);
                WriteAttributeValue(" ", 2012, "(Lütfen", 2013, 8, true);
                WriteAttributeValue(" ", 2020, "Kontrol", 2021, 8, true);
                WriteAttributeValue(" ", 2028, "İşlemini", 2029, 9, true);
                WriteAttributeValue(" ", 2037, "Girin)", 2038, 7, true);
                EndWriteAttribute();
                WriteLiteral(" id=\"validation\" name=\"validation\" />\r\n        </div>\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Sign in</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</div>
<script type=""text/javascript"">
     function testScript() {
        $.ajax({
            url: '/Home/Test',
            data: { kontrol: 1 },
            type: 'post',
            dataType: 'json',
            success: function (data) {
                console.log(""başarıyla eklendi baba: "" + data.message);
            },
            error: function (data) {

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c2734a42278c9502b39b59eceece2af090a36c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c2734a42278c9502b39b59eceece2af090a36c2", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bdbbbdd186b065360e4111dc5b1a11db02f9911", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c2734a42278c9502b39b59eceece2af090a36c24049", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<section class=\"main-content-w3layouts-agileits\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<h3 class=\"tittle\">Kayıt Ol</h3>\r\n\t\t\t\t<div class=\"inner-sec\">\r\n\t\t\t<div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 15 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\Register\Index.cshtml"
                 using(Html.BeginForm("Index","Register",FormMethod.Post))
				{
					
				

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-md-6 mb-3\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"validationCustom01\">Adınız-Soyadınız</label>\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 22 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\Register\Index.cshtml"
                                   Write(Html.TextBoxFor(x => x.WriterName, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 23 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\Register\Index.cshtml"
                                   Write(Html.ValidationMessageFor(x => x.WriterName,"", new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-md-6 mb-3\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"validationCustom02\">Mail Adresi</label>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 33 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\Register\Index.cshtml"
                               Write(Html.TextBoxFor(x => x.WriterMail, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 34 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\Register\Index.cshtml"
                                   Write(Html.ValidationMessageFor(x => x.WriterMail,"", new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group col-md-6\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"exampleInputPassword1 mb-2\">Şifre</label>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 42 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\Register\Index.cshtml"
                               Write(Html.TextBoxFor(x => x.WriterPassword, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 43 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\Register\Index.cshtml"
                                   Write(Html.ValidationMessageFor(x => x.WriterPassword,"", new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group col-md-6\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"exampleInputPassword2 mb-2\">Görsel Dosya Yolu</label>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 49 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\Register\Index.cshtml"
                                   Write(Html.TextBoxFor(x => x.WriterImage, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 50 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\Register\Index.cshtml"
                                   Write(Html.ValidationMessageFor(x => x.WriterImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary submit mb-4\">Kayıt Ol</button>\r\n\t\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t\t<a href=\"#\" id = \"btn1\">Şartları okudum, kabul ediyorum.</a>\r\n\t\t\t\t\t\t\t\t</p>\r\n");
#nullable restore
#line 58 "C:\Users\ASUS\Documents\GitHub\ASP.NET-Blog\CoreDemo\Views\Register\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<br />\r\n\r\n\t\t<script>\r\n$(\'#btn1\').click(function() {\r\n    swal(\"Teşekkürler!\");\r\n});\r\n\t\t\t\r\n\t\t</script>\r\n\t</section>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dfccc1ccc3b3a7b897a088ff052c24ee732b71d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_KullaniciSignUp), @"mvc.1.0.view", @"/Views/Register/KullaniciSignUp.cshtml")]
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
#line 1 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\_ViewImports.cshtml"
using Staj2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\_ViewImports.cshtml"
using Staj2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dfccc1ccc3b3a7b897a088ff052c24ee732b71d", @"/Views/Register/KullaniciSignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f4f69d9c1bab487f6b29aef90835b2aafa66c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_KullaniciSignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Uye>
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
#line 2 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
  
    ViewData["Title"] = "KullaniciSignUp";
    Layout = "~/Views/Shared/KullaniciInterface/_KullaniciLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dfccc1ccc3b3a7b897a088ff052c24ee732b71d3769", async() => {
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
            WriteLiteral(@"
<section class=""cat_product_area section_padding"">
    <div class=""container"">
        <div id=""layoutAuthentication"">
            <div id=""layoutAuthentication_content"">
                <main>
                    <div class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-7"">
                                <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                                    <div class=""card-header""><h3 class=""text-center font-weight-light my-4"">Create Account</h3></div>
                                    <div class=""card-body"">
");
#nullable restore
#line 18 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
                                         using (Html.BeginForm("KullaniciSignUp", "Register", FormMethod.Post))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <!--<form method=""post"">-->
                                            <div class=""row mb-3"">
                                                <div class=""col-md-6"">
                                                    <div class=""form-floating mb-3 mb-md-0"">
                                                        ");
#nullable restore
#line 24 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
                                                   Write(Html.TextBoxFor(x=>x.uyeAdi,new{ @class= "form-control",  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        ");
#nullable restore
#line 25 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
                                                   Write(Html.ValidationMessageFor(x=>x.uyeAdi, "", new { @class = "text-danger", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                                                        <label for=""inputFirstName"">First name</label>
                                                    </div>
                                                </div>
                                                <div class=""col-md-6"">
                                                    <div class=""form-floating"">
                                                        ");
#nullable restore
#line 32 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
                                                   Write(Html.TextBoxFor(x => x.uyeSoyadi, new { @class = "form-control",  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        ");
#nullable restore
#line 33 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
                                                   Write(Html.ValidationMessageFor(x => x.uyeSoyadi,"", new { @class = "text-danger", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                                                        <label for=""inputLastName"">Last name</label>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""form-floating mb-3"">
                                                ");
#nullable restore
#line 40 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
                                           Write(Html.TextBoxFor(x => x.email, new { @class = "form-control", @type = "email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                ");
#nullable restore
#line 41 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
                                           Write(Html.ValidationMessageFor(x => x.email, "", new { @class = "text-danger", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                                                <label for=\"inputEmail\">Email address</label>\r\n                                            </div>\r\n");
            WriteLiteral(@"                                            <div class=""row mb-3"">
                                                <div class=""col-md-6"">
                                                    <div class=""form-floating mb-3 mb-md-0"">
                                                        ");
#nullable restore
#line 51 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
                                                   Write(Html.TextBoxFor(x => x.telNo,  new { @class = "form-control",  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        ");
#nullable restore
#line 52 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
                                                   Write(Html.ValidationMessageFor(x => x.telNo, "", new { @class = "text-danger", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                                                        <label for=""inputPasswordConfirm"">Mobile Number</label>
                                                    </div>
                                                </div>
                                                <div class=""col-md-6"">
                                                    <div class=""form-floating mb-3 mb-md-0"">
                                                        ");
#nullable restore
#line 59 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
                                                   Write(Html.TextBoxFor(x => x.parola,  new { @class = "form-control", type = "password"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        ");
#nullable restore
#line 60 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
                                                   Write(Html.ValidationMessageFor(x => x.parola, "", new { @class = "text-danger", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                                                        <label for=""inputPassword"">Password</label>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class=""mt-4 mb-0"">
                                                <div class=""d-grid"">
                                                    <button type=""submit"" class=""btn btn-primary btn-block "">Create Account</button>
                                                    <!--<a class=""btn btn-primary btn-block"" type=""button"" href=""/Kullanici/KullaniciLogIn/"">Create Account</a>-->
                                                </div>
                                            </div>
                                            <!--</form>-->
");
#nullable restore
#line 74 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Register\KullaniciSignUp.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                    <div class=""card-footer text-center py-3"">
                                        <div class=""small""><a href=""/LogIn/KullaniciLogIn/"">Have an account? Go to login</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
        </div>
    </div>
</section>
<script src=""js/scripts.js""></script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Uye> Html { get; private set; }
    }
}
#pragma warning restore 1591

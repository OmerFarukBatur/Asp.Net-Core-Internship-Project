#pragma checksum "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\LogIn\KullaniciLogIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57b24c0d09dee6c131ed90c28b7d9e3f1738d2c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LogIn_KullaniciLogIn), @"mvc.1.0.view", @"/Views/LogIn/KullaniciLogIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b24c0d09dee6c131ed90c28b7d9e3f1738d2c1", @"/Views/LogIn/KullaniciLogIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f4f69d9c1bab487f6b29aef90835b2aafa66c6", @"/Views/_ViewImports.cshtml")]
    public class Views_LogIn_KullaniciLogIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Uye>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\LogIn\KullaniciLogIn.cshtml"
  
    ViewData["Title"] = "KullaniciLogIn";
    Layout = "~/Views/Shared/KullaniciInterface/_KullaniciLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""cat_product_area section_padding"">
    <div class=""container"">
        <div id=""layoutAuthentication"">
            <div id=""layoutAuthentication_content"">
                <main>
                    <div class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-5"">
                                <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                                    <div class=""card-header""><h3 class=""text-center font-weight-light my-4"">Login</h3></div>
                                    <div class=""card-body"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57b24c0d09dee6c131ed90c28b7d9e3f1738d2c14541", async() => {
                WriteLiteral(@"
                                            <div class=""form-floating mb-3"">
                                                <input class=""form-control"" id=""inputEmail"" type=""email"" placeholder=""name@example.com""  name=""email""/>
                                                <label for=""inputEmail"">Email address</label>
                                            </div>
                                            <div class=""form-floating mb-3"">
                                                <input class=""form-control"" id=""inputPassword"" type=""password"" placeholder=""Password"" name=""parola"" />
                                                <label for=""inputPassword"">Password</label>
                                            </div>
                                            <div class=""form-check mb-3"">
                                                <input class=""form-check-input"" id=""inputRememberPassword"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 1819, "\"", 1827, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                                <label class=""form-check-label"" for=""inputRememberPassword"">Remember Password</label>
                                            </div>
                                            <div class=""d-flex align-items-center justify-content-between mt-4 mb-0"">
                                                <a class=""small"" href=""/Kullanici/PasswordUpdate"">Forgot Password?</a>

");
                WriteLiteral("                                            <button type=\"submit\" class=\"btn btn-primary \">Login</button>\r\n\r\n                                            </div>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                    <div class=""card-footer text-center py-3"">
                                        <div class=""small""><a href=""/Register/KullaniciSignUp/"">Need an account? Sign up!</a></div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Uye>> Html { get; private set; }
    }
}
#pragma warning restore 1591

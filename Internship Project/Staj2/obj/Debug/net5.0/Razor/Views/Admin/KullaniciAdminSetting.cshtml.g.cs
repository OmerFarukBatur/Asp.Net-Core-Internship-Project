#pragma checksum "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b39e362c66981e9b6bbcfdb145ad557bd36c4d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_KullaniciAdminSetting), @"mvc.1.0.view", @"/Views/Admin/KullaniciAdminSetting.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b39e362c66981e9b6bbcfdb145ad557bd36c4d3", @"/Views/Admin/KullaniciAdminSetting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f4f69d9c1bab487f6b29aef90835b2aafa66c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_KullaniciAdminSetting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Uye>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
  
    ViewData["Title"] = "KullaniciAdminSetting";
    Layout = "~/Views/Shared/KullaniciAdmin/_KullaniciAdminLogged.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
 using (Html.BeginForm("KullaniciAdminSetting", "Admin", FormMethod.Post

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
                                                                                                                ))
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b39e362c66981e9b6bbcfdb145ad557bd36c4d34644", async() => {
                WriteLiteral(@"
    <div class=""container rounded bg-white mt-5 mb-5"">
        <div class=""row"">
            <div class=""col-md-3 border-right"">
                <img width=""150"" src=""https://st3.depositphotos.com/15648834/17930/v/600/depositphotos_179308454-stock-illustration-unknown-person-silhouette-glasses-profile.jpg"" class=""picture-src rounded-circle mt-5 "" id=""profileImage1""");
                BeginWriteAttribute("title", " title=\"", 665, "\"", 673, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                <input type=\"file\" id=\"profileImage2\"");
                BeginWriteAttribute("class", " class=\"", 732, "\"", 740, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <!--<div class=""d-flex flex-column align-items-center text-center p-3 py-5""><!--<img id=""profileImage"" class=""rounded-circle mt-5"" width=""150"" src=""https://st3.depositphotos.com/15648834/17930/v/600/depositphotos_179308454-stock-illustration-unknown-person-silhouette-glasses-profile.jpg""><span class=""font-weight-bold"">Edogaru</span><span class=""text-black-50"">edogaru@mail.com.my</span><span> </span></div>-->
            </div>
            <div class=""col-md-5 border-right"">
                <div class=""p-3 py-5"">

                    <div class=""d-flex justify-content-between align-items-center mb-3"">
                        <h4 class=""text-right"">Profile Settings</h4>
                    </div>
                    <div class=""row mt-2"">
                        <div class=""col-md-6"">
                            <label for=""Name"" class=""form-label"">Name</label>
                            ");
#nullable restore
#line 27 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
                       Write(Html.TextBoxFor(x => x.uyeAdi, new { @class = "form-control", @type = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 28 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
                       Write(Html.ValidationMessageFor(x => x.uyeAdi, "", new { @class = "text-danger", }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <label for=\"Surname\" class=\"form-label\">Surname</label>\r\n                            ");
#nullable restore
#line 35 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
                       Write(Html.TextBoxFor(x => x.uyeSoyadi, new { @class = "form-control", @type = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 36 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
                       Write(Html.ValidationMessageFor(x => x.uyeSoyadi, "", new { @class = "text-danger", }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""row mt-3"">
                        <div class=""col-md-12"">
                            <label for=""mobile number"" class=""form-label"">Mobile Number</label>
                            ");
#nullable restore
#line 43 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
                       Write(Html.TextBoxFor(x => x.telNo, new { @class = "form-control", @type = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 44 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
                       Write(Html.ValidationMessageFor(x => x.telNo, "", new { @class = "text-danger", }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                        </div>\r\n                        <div class=\"col-md-12\">\r\n                            <label for=\"address\" class=\"form-label\">Password</label>\r\n                            ");
#nullable restore
#line 49 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
                       Write(Html.PasswordFor(x => x.parola, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 50 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
                       Write(Html.ValidationMessageFor(x => x.parola, "", new { @class = "text-danger", }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                        </div>\r\n                        <div class=\"col-md-12\">\r\n                            <label for=\"email\" class=\"form-label\">Email</label>\r\n                            ");
#nullable restore
#line 55 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
                       Write(Html.TextBoxFor(x => x.email, new { @class = "form-control", @type = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 56 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
                       Write(Html.ValidationMessageFor(x => x.email, "", new { @class = "text-danger", }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""row mt-3"">

                    </div>
                    <div class=""mt-5 text-center""><button class=""btn btn-primary profile-button"" type=""submit"">Save Profile</button></div>
                </div>
            </div>
            <div class=""col-md-4"">
");
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 94 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciAdminSetting.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b39e362c66981e9b6bbcfdb145ad557bd36c4d312638", async() => {
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


<script language=""javascript"">
    $(document).ready(function () {
        // Prepare the preview for profile picture
        $(""#profileImage2"").change(function () {
            readURL(this);
        });
    });
    function readURL(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {
                $('#profileImage1').attr('src', e.target.result).fadeIn('slow');
            }
            reader.readAsDataURL(input.files[0]);
        }
    }
</script>
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

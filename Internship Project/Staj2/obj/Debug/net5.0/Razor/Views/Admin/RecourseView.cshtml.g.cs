#pragma checksum "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\RecourseView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af7b6434bff3715e81831fdfae9fe460c3add1ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RecourseView), @"mvc.1.0.view", @"/Views/Admin/RecourseView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7b6434bff3715e81831fdfae9fe460c3add1ee", @"/Views/Admin/RecourseView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f4f69d9c1bab487f6b29aef90835b2aafa66c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RecourseView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Basvuru>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\RecourseView.cshtml"
      
        ViewData["Title"] = "RecourseView";
        Layout = "~/Views/Shared/KullaniciAdmin/_KullaniciAdminLogged.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <section class=""cat_product_area section_padding"">
        <div class=""container"">
            <h2 class=""text-center text-heading"">Applications</h2>
            <div class=""table-responsive"">
                <table class=""table table-striped table-sm"">
                    <thead>
                        <tr>
                            <th scope=""col"">Recourse ID</th>
                            <th scope=""col"">Person Name</th>
                            <th scope=""col"">Project Name</th>
                            <th scope=""col"">Position Name</th>
                            <th scope=""col"">Position Level</th>
                            <th scope=""col"">Bid</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\RecourseView.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\RecourseView.cshtml"
                           Write(item.basvuruID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            ");
#nullable restore
#line 29 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\RecourseView.cshtml"
                       Write(await Component.InvokeAsync("UyeNameListBasvuru", item.uyeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\RecourseView.cshtml"
                           Write(item.projeAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\RecourseView.cshtml"
                           Write(item.pozisyonAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\RecourseView.cshtml"
                           Write(item.pozisyonSeviyesi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\RecourseView.cshtml"
                           Write(item.teklif);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\RecourseView.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Basvuru>> Html { get; private set; }
    }
}
#pragma warning restore 1591

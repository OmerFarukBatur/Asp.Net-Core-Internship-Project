#pragma checksum "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciTeamView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd3e75ebbe7867af871008cc1d1f956377ff975"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_KullaniciTeamView), @"mvc.1.0.view", @"/Views/Admin/KullaniciTeamView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd3e75ebbe7867af871008cc1d1f956377ff975", @"/Views/Admin/KullaniciTeamView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f4f69d9c1bab487f6b29aef90835b2aafa66c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_KullaniciTeamView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Takim>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciTeamView.cshtml"
  
    ViewData["Title"] = "KullaniciTeamView";
    Layout = "~/Views/Shared/KullaniciAdmin/_KullaniciAdminLogged.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<section class=""cat_product_area section_padding"">
    <div class=""container"">
        <h2 class=""text-center text-heading"">Team List</h2>
        <div class=""table-responsive"">
            <table class=""table table-striped table-sm"">
                <thead>
                    <tr>
                        <th scope=""col"">Takım ID</th>
                        <th scope=""col"">Project Name</th>
                        <th scope=""col"">Position Name</th>
                        <th scope=""col"">Position Level</th>
                        <th scope=""col"">Setting</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 24 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciTeamView.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciTeamView.cshtml"
                       Write(item.takimID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciTeamView.cshtml"
                       Write(item.projeAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        ");
#nullable restore
#line 29 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciTeamView.cshtml"
                   Write(await Component.InvokeAsync("ProjeIDPozisyonList", item.projeID));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                    <td>\r\n                        <!-- <a href=\"#\" class=\"view\" title=\"\" data-toggle=\"tooltip\" data-original-title=\"View\"><i class=\"far fa-eye\"></i></a>&nbsp; -->\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1335, "\"", 1384, 2);
            WriteAttributeValue("", 1342, "/Admin/KullaniciRecourseEdit/", 1342, 29, true);
#nullable restore
#line 32 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciTeamView.cshtml"
WriteAttributeValue("", 1371, item.takimID, 1371, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"edit\"");
            BeginWriteAttribute("title", " title=\"", 1398, "\"", 1406, 0);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" data-original-title=\"Edit\"><i class=\"fas fa-pencil-alt\"></i></a>&nbsp;\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1528, "\"", 1580, 3);
            WriteAttributeValue("", 1535, "/Admin/KullaniciRecourseDelete/", 1535, 31, true);
#nullable restore
#line 33 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciTeamView.cshtml"
WriteAttributeValue("", 1566, item.takimID, 1566, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1579, "/", 1579, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"delete\"");
            BeginWriteAttribute("title", " title=\"", 1596, "\"", 1604, 0);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" data-original-title=\"Delete\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                    </td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Admin\KullaniciTeamView.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Takim>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Shared\Components\ProjeIDPozisyonList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2778213a627380b16317352858c21b3e9d0068b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjeIDPozisyonList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjeIDPozisyonList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2778213a627380b16317352858c21b3e9d0068b", @"/Views/Shared/Components/ProjeIDPozisyonList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f4f69d9c1bab487f6b29aef90835b2aafa66c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProjeIDPozisyonList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Basvuru>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<td>");
#nullable restore
#line 3 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Shared\Components\ProjeIDPozisyonList\Default.cshtml"
Write(Model.pozisyonAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n<td>");
#nullable restore
#line 4 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Shared\Components\ProjeIDPozisyonList\Default.cshtml"
Write(Model.pozisyonSeviyesi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Basvuru> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Shared\Components\MaliyetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98915ed7d7268e0dc1f82177573c23ebefa975b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MaliyetList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MaliyetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98915ed7d7268e0dc1f82177573c23ebefa975b0", @"/Views/Shared/Components/MaliyetList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f4f69d9c1bab487f6b29aef90835b2aafa66c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MaliyetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Maliyet>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Shared\Components\MaliyetList\Default.cshtml"
 foreach (var item in Model)
{    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 6 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Shared\Components\MaliyetList\Default.cshtml"
   Write(item.maliyetFiyati);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 7 "C:\Users\OmerF\source\repos\çöp oldu\Staj2\Staj2\Views\Shared\Components\MaliyetList\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Maliyet>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\HỌC TẬP\PROJECT\LAP TRINH WEB\BTL_WEB_NHOM5\blt_coffeeShop_aspnet_nhom5\CoffeeShopMangement\Views\Shared\Components\NumberCart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "014e2f080ae041babc36a2a8accf295186489501"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NumberCart_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NumberCart/Default.cshtml")]
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
#line 1 "D:\HỌC TẬP\PROJECT\LAP TRINH WEB\BTL_WEB_NHOM5\blt_coffeeShop_aspnet_nhom5\CoffeeShopMangement\Views\_ViewImports.cshtml"
using CoffeeShopMangement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HỌC TẬP\PROJECT\LAP TRINH WEB\BTL_WEB_NHOM5\blt_coffeeShop_aspnet_nhom5\CoffeeShopMangement\Views\_ViewImports.cshtml"
using CoffeeShopMangement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"014e2f080ae041babc36a2a8accf295186489501", @"/Views/Shared/Components/NumberCart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1fbff6ed3fb2df6caccf6b3bc2e967120906a6a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_NumberCart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoffeeShopMangement.ModelViews.CartItem>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\HỌC TẬP\PROJECT\LAP TRINH WEB\BTL_WEB_NHOM5\blt_coffeeShop_aspnet_nhom5\CoffeeShopMangement\Views\Shared\Components\NumberCart\Default.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"minicart-wrap me-3 me-lg-0\">\r\n        <a href=\"#miniCart\" class=\"minicart-btn toolbar-btn\">\r\n            <i class=\"pe-7s-shopbag\"></i>\r\n            <span class=\"quantity\">");
#nullable restore
#line 7 "D:\HỌC TẬP\PROJECT\LAP TRINH WEB\BTL_WEB_NHOM5\blt_coffeeShop_aspnet_nhom5\CoffeeShopMangement\Views\Shared\Components\NumberCart\Default.cshtml"
                              Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </a>\r\n    </li>\r\n");
#nullable restore
#line 10 "D:\HỌC TẬP\PROJECT\LAP TRINH WEB\BTL_WEB_NHOM5\blt_coffeeShop_aspnet_nhom5\CoffeeShopMangement\Views\Shared\Components\NumberCart\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"minicart-wrap me-3 me-lg-0\">\r\n        <a href=\"#miniCart\" class=\"toolbar-btn\">\r\n            <i class=\"pe-7s-shopbag\"></i>\r\n            <span class=\"quantity\">0</span>\r\n        </a>\r\n    </li>\r\n");
#nullable restore
#line 19 "D:\HỌC TẬP\PROJECT\LAP TRINH WEB\BTL_WEB_NHOM5\blt_coffeeShop_aspnet_nhom5\CoffeeShopMangement\Views\Shared\Components\NumberCart\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoffeeShopMangement.ModelViews.CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\Shared\Components\AssetsByType\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e535da22d94df7fd9d0ac4388c6d74d234f491a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AssetsByType_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AssetsByType/Default.cshtml")]
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
#line 1 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\_ViewImports.cshtml"
using CCSOFTWARESOLUTIONS.Assets.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\_ViewImports.cshtml"
using CCSOFTWARESOLUTIONS.Assets.Presentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e535da22d94df7fd9d0ac4388c6d74d234f491a", @"/Views/Shared/Components/AssetsByType/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f54331898f6b8e446492bb19a26eda01c0307fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AssetsByType_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CCSOFTWARESOLUTIONS.Assets.Presentation.Models.AssetViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\Shared\Components\AssetsByType\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Assets</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>            \r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.TagNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.AssetType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.SerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\Shared\Components\AssetsByType\Default.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>            \r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.TagNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.AssetType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.SerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>            \r\n        </tr>");
#nullable restore
#line 40 "C:\Users\NDUBUISI OKPALA-PC\Desktop\.NET Web Applications\project 2\CCSOFTWARESOLUTIONS.Assets\CCSOFTWARESOLUTIONS.Assets.Presentation\Views\Shared\Components\AssetsByType\Default.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CCSOFTWARESOLUTIONS.Assets.Presentation.Models.AssetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Configuration\Configuration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd19ee4451887268b3834ab30b28b78db341ad0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StrongBartending.Pages.Configuration.Pages_Configuration_Configuration), @"mvc.1.0.razor-page", @"/Pages/Configuration/Configuration.cshtml")]
namespace StrongBartending.Pages.Configuration
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
#line 1 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\_ViewImports.cshtml"
using StrongBartending;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\_ViewImports.cshtml"
using StrongBartending.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd19ee4451887268b3834ab30b28b78db341ad0c", @"/Pages/Configuration/Configuration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6640f5fd96da3eabd841045a30fc2e79d61482b3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Configuration_Configuration : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Configuration\Configuration.cshtml"
  
    ViewData["Title"] = "Configuration";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Configuration</h1>

<table class=""table"">
    <tr>
        <td>
            <a class=""nav-link text-dark"" href=""/Configuration/BarPay/Index"">Bar Pay</a>
        </td>
    </tr>
    <tr>
        <td>
            <a class=""nav-link text-dark"" href=""/Configuration/BarType/Index"">Bar Types</a>
        </td>
    </tr>
    <tr>
        <td>
            <a class=""nav-link text-dark"" href=""/Configuration/EventStatu/Index"">Event Status</a>
        </td>
    </tr>
    <tr>
        <td>
            <a class=""nav-link text-dark"" href=""/Configuration/EventType/Index"">Event Type</a>
        </td>
    </tr>
    <tr>
        <td>
            <a class=""nav-link text-dark"" href=""/Configuration/LeadStatu/Index"">Lead Status</a>
        </td>
    </tr>
    <tr>
        <td>
            <a class=""nav-link text-dark"" href=""/Configuration/LineStatu/Index"">Line Status</a>
        </td>
    </tr>
    <tr>
        <td>
            <a class=""nav-link text-dark"" href=""/Configuration/LinkBack/Index");
            WriteLiteral("\">Link Back</a>\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            <a class=\"nav-link text-dark\" href=\"/Configuration/Service/Index\">Service</a>\r\n        </td>\r\n    </tr>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StrongBartending.Pages.Configuration.ConfigurationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StrongBartending.Pages.Configuration.ConfigurationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StrongBartending.Pages.Configuration.ConfigurationModel>)PageContext?.ViewData;
        public StrongBartending.Pages.Configuration.ConfigurationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

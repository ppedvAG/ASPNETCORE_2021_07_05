#pragma checksum "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul005\CustomizeHtmlTagHelper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25323379f8c99a6179dc7f46f4c4a4931ff6e1ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPageKurs.Pages.Modul005.Pages_Modul005_CustomizeHtmlTagHelper), @"mvc.1.0.razor-page", @"/Pages/Modul005/CustomizeHtmlTagHelper.cshtml")]
namespace RazorPageKurs.Pages.Modul005
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
#line 1 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\_ViewImports.cshtml"
using RazorPageKurs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\_ViewImports.cshtml"
using RazorPageKurs.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\_ViewImports.cshtml"
using RazorPageKurs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25323379f8c99a6179dc7f46f4c4a4931ff6e1ad", @"/Pages/Modul005/CustomizeHtmlTagHelper.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87bb3120269a2dfda42a4c7b8dadae5daebe2026", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Modul005_CustomizeHtmlTagHelper : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<h1>HtmlHelper</h1>\r\n\r\n\r\n<div>");
#nullable restore
#line 11 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul005\CustomizeHtmlTagHelper.cshtml"
Write(Html.HelloWorldHTMLString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>");
#nullable restore
#line 12 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul005\CustomizeHtmlTagHelper.cshtml"
Write(Html.HelloWorldString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>");
#nullable restore
#line 13 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul005\CustomizeHtmlTagHelper.cshtml"
Write(Html.HelloWorld("Lieber Teilnehmer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPageKurs.Pages.Modul005.CustomizeHtmlTagHelperModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPageKurs.Pages.Modul005.CustomizeHtmlTagHelperModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPageKurs.Pages.Modul005.CustomizeHtmlTagHelperModel>)PageContext?.ViewData;
        public RazorPageKurs.Pages.Modul005.CustomizeHtmlTagHelperModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul007\TempDataDestination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8d36120f2265825b76890ada560a9474fd0dd52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPageKurs.Pages.Modul007.Pages_Modul007_TempDataDestination), @"mvc.1.0.razor-page", @"/Pages/Modul007/TempDataDestination.cshtml")]
namespace RazorPageKurs.Pages.Modul007
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d36120f2265825b76890ada560a9474fd0dd52", @"/Pages/Modul007/TempDataDestination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87bb3120269a2dfda42a4c7b8dadae5daebe2026", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Modul007_TempDataDestination : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>TempDataDestination</h3>\r\n\r\n");
#nullable restore
#line 14 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul007\TempDataDestination.cshtml"
                              




    if (TempData.Peek("Message") != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Message: ");
#nullable restore
#line 21 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul007\TempDataDestination.cshtml"
                Write(TempData.Peek("Message"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 22 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul007\TempDataDestination.cshtml"



        //Wenn kein Peek verwendet wird, wird der Eintrag Message in TempData gelöscht
        //<h3>Message: @TempData["Message"]</h3>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPageKurs.Pages.Modul007.TempDataDestinationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPageKurs.Pages.Modul007.TempDataDestinationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPageKurs.Pages.Modul007.TempDataDestinationModel>)PageContext?.ViewData;
        public RazorPageKurs.Pages.Modul007.TempDataDestinationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
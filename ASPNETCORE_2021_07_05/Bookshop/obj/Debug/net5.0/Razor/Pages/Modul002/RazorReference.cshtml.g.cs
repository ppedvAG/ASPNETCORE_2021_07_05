#pragma checksum "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f0a2247a4ed06bd46f8c9bc775c4eb34a6f7b42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPageKurs.Pages.Modul002.Pages_Modul002_RazorReference), @"mvc.1.0.razor-page", @"/Pages/Modul002/RazorReference.cshtml")]
namespace RazorPageKurs.Pages.Modul002
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
#line 2 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
using RazorPageKurs.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 292 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
using DependecyInjectionSample;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f0a2247a4ed06bd46f8c9bc775c4eb34a6f7b42", @"/Pages/Modul002/RazorReference.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87bb3120269a2dfda42a4c7b8dadae5daebe2026", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Modul002_RazorReference : global::Microsoft.AspNetCore.Mvc.RazorPages.Page, IDisposable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scripts/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>RazorSyntaxSamples</h1>\r\n\r\n\r\n");
            WriteLiteral("<p>");
#nullable restore
#line 11 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
            WriteLiteral("<p>");
            WriteLiteral("@Model.Username</p>\r\n\r\n");
            WriteLiteral("<p>");
#nullable restore
#line 18 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 19 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
Write(DateTime.IsLeapYear(2016));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
            WriteLiteral("<p>Last week this time: ");
#nullable restore
#line 23 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
                    Write(DateTime.Now - TimeSpan.FromDays(7));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
            WriteLiteral("<p>Last week: ");
#nullable restore
#line 27 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
         Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - TimeSpan.FromDays(7)</p>\r\n\r\n");
#nullable restore
#line 29 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
  
    var mitarbeiterDesMonats = new Person("Joe", 33);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Age");
#nullable restore
#line 33 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
  Write(mitarbeiterDesMonats.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n<p>");
#nullable restore
#line 49 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
Write(GenericMethod<int>());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
Write("<span>Hello World</span>");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
Write(Html.Raw("<span>Hello World</span>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 85 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
  
    var quote = "The future depends on what you do today. - Mahatma Gandhi";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 89 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
Write(quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 100 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
  
    void RenderName(string name)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Name: <strong>");
#nullable restore
#line 103 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
                    Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n");
#nullable restore
#line 104 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
    }

    RenderName("Mahatma Gandhi");
    RenderName("Martin Luther King, Jr.");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 111 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
 for (int y = 0; y < Model.People.Length; y++)
{
    var person = Model.People[y];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("Name: ");
#nullable restore
#line 114 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
           Write(person.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
                                   
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 127 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
 for (var x = 0; x < Model.People.Length; x++)
{
    var person = Model.People[x];

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Name: ");
#nullable restore
#line 130 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
       Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 131 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 139 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
 if (value % 2 == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value was even.</p>\r\n");
#nullable restore
#line 142 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
}


#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
 if (value % 2 == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value was even.</p>\r\n");
#nullable restore
#line 148 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
}
else if (value >= 1337)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value is large.</p>\r\n");
#nullable restore
#line 152 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value is odd and small.</p>\r\n");
#nullable restore
#line 156 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 161 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
 switch (value)
{
    case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>The value is 1!</p>\r\n");
#nullable restore
#line 165 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
        break;
    case 1337:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Your number is 1337!</p>\r\n");
#nullable restore
#line 168 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
        break;
    default:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Your number wasn\'t 1 or 1337.</p>\r\n");
#nullable restore
#line 171 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
        break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 177 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
  
    var myPeople = new Person[]
    {
          new Person("Weston", 33),
          new Person("Johnathon", 41),
                                                                                            };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 187 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
 for (var a = 0; a < myPeople.Length; a++)
{
    var person = myPeople[a];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Name: ");
#nullable restore
#line 190 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
        Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Age: ");
#nullable restore
#line 191 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
       Write(person.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 192 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 195 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
 foreach (var person in myPeople)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Name: ");
#nullable restore
#line 197 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
        Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Age: ");
#nullable restore
#line 198 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
       Write(person.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 199 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 202 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
  var i = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 203 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
 while (i < myPeople.Length)
{
    var person = myPeople[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Name: ");
#nullable restore
#line 206 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
        Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Age: ");
#nullable restore
#line 207 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
       Write(person.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 208 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"

    i++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 214 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
  i = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 215 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
 do
{
    var person = myPeople[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Name: ");
#nullable restore
#line 218 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
        Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Age: ");
#nullable restore
#line 219 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
       Write(person.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 220 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"

    i++;
} while (i < myPeople.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 236 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        Email: <input type=\"email\" id=\"Email\"");
            BeginWriteAttribute("value", " value=\"", 6248, "\"", 6256, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <button>Register</button>\r\n    </div>\r\n");
#nullable restore
#line 242 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 248 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
 try
{
    throw new InvalidOperationException("You did something invalid.");
}
catch (Exception ex)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The exception message: ");
#nullable restore
#line 254 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
                         Write(ex.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 255 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
}
finally
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The finally statement.</p>\r\n");
#nullable restore
#line 259 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 262 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
 lock (Model.Username)
{
    // Do critical section work
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Example</h1>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n<p>");
#nullable restore
#line 296 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
Write(myMockCar.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 297 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
Write(myMockCar.Modell);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 298 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
Write(myMockCar.ConstructionYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0a2247a4ed06bd46f8c9bc775c4eb34a6f7b4222209", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            alert(\"Test\");\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
           
    public string GenericMethod<T>()
    {
        return "a type";
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
            
    private int value = 2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 278 "C:\Aktueller Kurs\ASPNETCORE_2021_07_05\ASPNETCORE_2021_07_05\Bookshop\Pages\Modul002\RazorReference.cshtml"
            
    private bool _isDisposed;

    public void Dispose()
    {
        _isDisposed = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICar myMockCar { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPageKurs.Pages.Modul002.RazorReferenceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPageKurs.Pages.Modul002.RazorReferenceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPageKurs.Pages.Modul002.RazorReferenceModel>)PageContext?.ViewData;
        public RazorPageKurs.Pages.Modul002.RazorReferenceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

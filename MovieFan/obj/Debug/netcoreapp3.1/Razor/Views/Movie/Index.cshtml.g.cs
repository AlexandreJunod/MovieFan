#pragma checksum "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2fc205fffffcb41810a126779cdc292847b7b29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\_ViewImports.cshtml"
using MovieFan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\_ViewImports.cshtml"
using MovieFan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2fc205fffffcb41810a126779cdc292847b7b29", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5197f4dd6f2319bfb6f757f3f841b353a2e2ed94", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movies>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Films";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h1>Liste de films</h1>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Film</th>
                <th scope=""col"">Catégorie</th>
                <th scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\Movie\Index.cshtml"
             foreach (Movies movie in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 23 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\Movie\Index.cshtml"
                               Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\Movie\Index.cshtml"
                   Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\Movie\Index.cshtml"
                   Write(movie.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 715, "\"", 746, 2);
            WriteAttributeValue("", 722, "/Movie/Details/", 722, 15, true);
#nullable restore
#line 26 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\Movie\Index.cshtml"
WriteAttributeValue("", 737, movie.Id, 737, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\" role=\"button\" aria-pressed=\"true\">Afficher le film</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 28 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\Movie\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movies>> Html { get; private set; }
    }
}
#pragma warning restore 1591

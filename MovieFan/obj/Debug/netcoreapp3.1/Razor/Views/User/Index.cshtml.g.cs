#pragma checksum "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9d4e1db804f86c7e589616cf50a8d54b223ae6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9d4e1db804f86c7e589616cf50a8d54b223ae6a", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5197f4dd6f2319bfb6f757f3f841b353a2e2ed94", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Users>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Membres";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>Liste des membres</h1>\r\n");
#nullable restore
#line 10 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\User\Index.cshtml"
     foreach(Users user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 223, "\"", 252, 2);
            WriteAttributeValue("", 230, "/User/Details/", 230, 14, true);
#nullable restore
#line 12 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\User\Index.cshtml"
WriteAttributeValue("", 244, user.Id, 244, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class =\"row border p-3\">\r\n                ");
#nullable restore
#line 14 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\User\Index.cshtml"
           Write(user.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\User\Index.cshtml"
                           Write(user.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 17 "C:\Users\alexandre.junod\GitHub\MovieFan\MovieFan\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Administrator\source\repos\ConfigurationReaderCodeCase\ConfigurationReader.WebApp\Views\Home\CreateUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95f03fef137036e6563f08db390cd9858004e039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateUpdate), @"mvc.1.0.view", @"/Views/Home/CreateUpdate.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\ConfigurationReaderCodeCase\ConfigurationReader.WebApp\Views\_ViewImports.cshtml"
using ConfigurationReader.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\ConfigurationReaderCodeCase\ConfigurationReader.WebApp\Views\_ViewImports.cshtml"
using ConfigurationReader.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95f03fef137036e6563f08db390cd9858004e039", @"/Views/Home/CreateUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e67bf3c224d6b723f83b19a9c6c27f2070ce31c7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_CreateUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConfigurationReader.Library.Models.Configuration>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\ConfigurationReaderCodeCase\ConfigurationReader.WebApp\Views\Home\CreateUpdate.cshtml"
  
    ViewData["Title"] = "Configuration List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\ConfigurationReaderCodeCase\ConfigurationReader.WebApp\Views\Home\CreateUpdate.cshtml"
     using (Html.BeginForm("CreateUpdate", "Home", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\ConfigurationReaderCodeCase\ConfigurationReader.WebApp\Views\Home\CreateUpdate.cshtml"
   Write(Html.HiddenFor(m=>m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"Name\">Name:</label>\r\n            ");
#nullable restore
#line 14 "C:\Users\Administrator\source\repos\ConfigurationReaderCodeCase\ConfigurationReader.WebApp\Views\Home\CreateUpdate.cshtml"
       Write(Html.TextBoxFor(m=>m.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"Type\">Type:</label>\r\n\r\n\r\n                ");
#nullable restore
#line 22 "C:\Users\Administrator\source\repos\ConfigurationReaderCodeCase\ConfigurationReader.WebApp\Views\Home\CreateUpdate.cshtml"
           Write(Html.DropDownListFor(m=>m.Type,  new List<SelectListItem> {
                    new SelectListItem { Value="integer", Text="Integer" },
                    new SelectListItem { Value="string", Text="String" },
                    new SelectListItem { Value="double", Text="Double" },
                    new SelectListItem { Value="boolean", Text="Boolean" },
                }, new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                \r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"Value\">Value:</label>\r\n            ");
#nullable restore
#line 36 "C:\Users\Administrator\source\repos\ConfigurationReaderCodeCase\ConfigurationReader.WebApp\Views\Home\CreateUpdate.cshtml"
       Write(Html.TextBoxFor(m=>m.Value, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"IsActive\">IsActive?:</label>\r\n            ");
#nullable restore
#line 41 "C:\Users\Administrator\source\repos\ConfigurationReaderCodeCase\ConfigurationReader.WebApp\Views\Home\CreateUpdate.cshtml"
       Write(Html.DropDownListFor(m=>m.IsActive,  new List<SelectListItem> {
        new SelectListItem {
        Text="Active",
        Value="true"
        },
        new SelectListItem {
        Text="Inactive",
        Value="false",
        },
        }, new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"ApplicationName\">ApplicationName:</label>\r\n            ");
#nullable restore
#line 58 "C:\Users\Administrator\source\repos\ConfigurationReaderCodeCase\ConfigurationReader.WebApp\Views\Home\CreateUpdate.cshtml"
       Write(Html.TextBoxFor(m=>m.ApplicationName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Submit\">\r\n        </div>\r\n");
#nullable restore
#line 64 "C:\Users\Administrator\source\repos\ConfigurationReaderCodeCase\ConfigurationReader.WebApp\Views\Home\CreateUpdate.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfigurationReader.Library.Models.Configuration> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Career\Career.Web\Views\Config\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4801dc7c1aea707fe18b5ec203cd442752552616"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Config_Index), @"mvc.1.0.view", @"/Views/Config/Index.cshtml")]
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
#line 1 "D:\Career\Career.Web\Views\_ViewImports.cshtml"
using Career.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Career\Career.Web\Views\_ViewImports.cshtml"
using Career.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Career\Career.Web\Views\Config\Index.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4801dc7c1aea707fe18b5ec203cd442752552616", @"/Views/Config/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4c4ce2d3ee5329601e99b2b0586a30182595dcc", @"/Views/_ViewImports.cshtml")]
    public class Views_Config_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CareerSetting>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Career\Career.Web\Views\Config\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.7/css/bootstrap.min.css"" />
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.0/jquery.min.js""></script>
<div class=""container"">
    <h1>Config Listesi</h1>


    <br />
    <table class=""table table-bordered data-table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Type</th>
                <th>Value</th>
                <th>IsActive</th>
                <th>Application Name</th>
                <th width=""200px"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "D:\Career\Career.Web\Views\Config\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 30 "D:\Career\Career.Web\Views\Config\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "D:\Career\Career.Web\Views\Config\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\Career\Career.Web\Views\Config\Index.cshtml"
                   Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "D:\Career\Career.Web\Views\Config\Index.cshtml"
                   Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "D:\Career\Career.Web\Views\Config\Index.cshtml"
                   Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "D:\Career\Career.Web\Views\Config\Index.cshtml"
                   Write(item.ApplicationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "D:\Career\Career.Web\Views\Config\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CareerSetting>> Html { get; private set; }
    }
}
#pragma warning restore 1591

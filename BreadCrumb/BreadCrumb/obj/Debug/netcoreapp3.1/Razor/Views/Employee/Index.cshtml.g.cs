#pragma checksum "C:\Users\Neha Goel\source\repos\BreadCrumb\BreadCrumb\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bafdcf8e40ab780de56ddb5da9ebf8a431fab432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\Neha Goel\source\repos\BreadCrumb\BreadCrumb\Views\_ViewImports.cshtml"
using BreadCrumb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Neha Goel\source\repos\BreadCrumb\BreadCrumb\Views\_ViewImports.cshtml"
using BreadCrumb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Neha Goel\source\repos\BreadCrumb\BreadCrumb\Views\_ViewImports.cshtml"
using System.Web.Mvc.Ajax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Neha Goel\source\repos\BreadCrumb\BreadCrumb\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bafdcf8e40ab780de56ddb5da9ebf8a431fab432", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267ac130d7036b58afd1e7e77685552c535e5036", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Neha Goel\source\repos\BreadCrumb\BreadCrumb\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Neha Goel\source\repos\BreadCrumb\BreadCrumb\Views\Employee\Index.cshtml"
Write(Html.ActionLink(
    "List All Employees",
    "Get",
      "Employee",
      null,
      null, null,
                 new AjaxOptions
                 {
                     UpdateTargetId = "UpdateContentDiv",
                     InsertionMode = InsertionMode.Replace,
                     HttpMethod = "GET"

                 },
      new { @class = "btn btn-primary" }
     ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

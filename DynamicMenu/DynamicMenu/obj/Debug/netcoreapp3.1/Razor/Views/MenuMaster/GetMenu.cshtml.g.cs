#pragma checksum "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba9bdc3a9e89fcf417266a59965e2c98da7595e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MenuMaster_GetMenu), @"mvc.1.0.view", @"/Views/MenuMaster/GetMenu.cshtml")]
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
#line 1 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\_ViewImports.cshtml"
using DynamicMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\_ViewImports.cshtml"
using DynamicMenu.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba9bdc3a9e89fcf417266a59965e2c98da7595e6", @"/Views/MenuMaster/GetMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6681bf449bfa59a5897104328341132e5a23ce77", @"/Views/_ViewImports.cshtml")]
    public class Views_MenuMaster_GetMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DynamicMenu.Models.MenuMaster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNew", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
  
    ViewData["Title"] = "GetMenu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"mt-2\">Menu </h4>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
 if (role.Roles.Any())
{
    var roles = role.Roles;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
     foreach (var roleName in roles)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-check form-check-inline\">\r\n            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 336, "\"", 413, 3);
            WriteAttributeValue("", 346, "location.href=\'", 346, 15, true);
#nullable restore
#line 16 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
WriteAttributeValue("", 361, Url.Action("GetMenuByRole",new { role=@roleName }), 361, 51, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 412, "\'", 412, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input type=\"radio\" class=\"form-check-input\" name=\"role\">\r\n                <label class=\"form-check-label\">");
#nullable restore
#line 18 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
                                           Write(roleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba9bdc3a9e89fcf417266a59965e2c98da7595e66474", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table table-striped table-bordered\" style=\"width:100%\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.MenuID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.MenuName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.Parent_MenuID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.User_Roll));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.User_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.MenuFileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.MenuURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.USE_YN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.IsParent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 65 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
               Write(Html.DisplayFor(modelItem => item.MenuID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
               Write(Html.DisplayFor(modelItem => item.MenuName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
               Write(Html.DisplayFor(modelItem => item.Parent_MenuID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
               Write(Html.DisplayFor(modelItem => item.User_Roll));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
               Write(Html.DisplayFor(modelItem => item.User_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 84 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
               Write(Html.DisplayFor(modelItem => item.MenuFileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 87 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
               Write(Html.DisplayFor(modelItem => item.MenuURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
               Write(Html.DisplayFor(modelItem => item.USE_YN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 96 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsParent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba9bdc3a9e89fcf417266a59965e2c98da7595e614205", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
                                           WriteLiteral(item.MenuIdentity);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba9bdc3a9e89fcf417266a59965e2c98da7595e616395", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
                                             WriteLiteral(item.MenuIdentity);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 103 "C:\Users\Neha Goel\source\repos\DynamicMenu\DynamicMenu\Views\MenuMaster\GetMenu.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RoleManager<IdentityRole> role { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DynamicMenu.Models.MenuMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591

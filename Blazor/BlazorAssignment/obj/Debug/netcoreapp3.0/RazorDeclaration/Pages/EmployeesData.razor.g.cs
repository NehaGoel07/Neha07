#pragma checksum "C:\Users\Neha Goel\source\repos\BlazorAssignment\Pages\EmployeesData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "010adf0b37911a59e7725359dfcb80b2924183ba"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAssignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Neha Goel\source\repos\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Neha Goel\source\repos\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Neha Goel\source\repos\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Neha Goel\source\repos\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Neha Goel\source\repos\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Neha Goel\source\repos\BlazorAssignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Neha Goel\source\repos\BlazorAssignment\_Imports.razor"
using BlazorAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Neha Goel\source\repos\BlazorAssignment\_Imports.razor"
using BlazorAssignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Neha Goel\source\repos\BlazorAssignment\_Imports.razor"
using BlazorAssignmentClassLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Neha Goel\source\repos\BlazorAssignment\Pages\EmployeesData.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AllEmployees")]
    public partial class EmployeesData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Neha Goel\source\repos\BlazorAssignment\Pages\EmployeesData.razor"
        
    
    protected override Task OnInitializedAsync()
        {


        
        HttpRequestMessage httpRequestMessage = new HttpRequestMessage();

        httpRequestMessage.Method = new HttpMethod("GET");
        httpRequestMessage.RequestUri = new Uri("https://localhost:44357/api/Login/GetStudent");
        httpRequestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        var client = httpClient.CreateClient();
        var res = client.SendAsync(httpRequestMessage).Result;
        var resultStatus = res.StatusCode;
        
        }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigate { get; set; }
    }
}
#pragma warning restore 1591

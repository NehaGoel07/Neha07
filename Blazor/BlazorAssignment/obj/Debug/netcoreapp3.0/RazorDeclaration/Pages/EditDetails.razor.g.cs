#pragma checksum "C:\Users\Neha Goel\source\repos\BlazorAssignment\Pages\EditDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0df0638f1ed47fd7adf3392bf367b76f33192948"
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
#line 1 "C:\Users\Neha Goel\source\repos\BlazorAssignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
#line 2 "C:\Users\Neha Goel\source\repos\BlazorAssignment\Pages\EditDetails.razor"
using BlazorAssignment.Repository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditDetails/{Id}")]
    public partial class EditDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Neha Goel\source\repos\BlazorAssignment\Pages\EditDetails.razor"
      

    [Parameter]
    public string Id { get; set; }

    TblStudentDetails studentDetails;

    protected override void OnInitialized()
    {

        studentDetails= new TblStudentDetails();
        GetStudentById();

        base.OnInitialized();

    }

    public void GetStudentById()
    {
        studentDetails=student.GetStudentById(Id);

    }

    public void UpdateData()
    {
        var res = student.EditDetails(studentDetails);
        if (res)
        {
            StateHasChanged();
            _navigate.NavigateTo("allstudents");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudent student { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\repos\ThreeBlazor\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b70fcf2a6695e539d7d3f6210821a9df696d1535"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ThreeBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\repos\ThreeBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\ThreeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\ThreeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\ThreeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\ThreeBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\ThreeBlazor\_Imports.razor"
using ThreeBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\ThreeBlazor\_Imports.razor"
using ThreeBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\ThreeBlazor\_Imports.razor"
using ThreeBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\ThreeBlazor\_Imports.razor"
using ThreeBlazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\ThreeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-employee/{departmentId}")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\repos\ThreeBlazor\Pages\AddEmployee.razor"
 
    [Parameter]
    public string departmentId { get; set; }

    public ThreeBlazor.Models.Employee employee = new ThreeBlazor.Models.Employee();

    private void OnGenderSelected(ChangeEventArgs e)
    {
        var gender = Enum.Parse(typeof(Gender), (string)e.Value);
        employee.Gender = (Gender)gender;

    }
    public async Task HandleValidSubmit()
    {
        employee.DepartmentId = int.Parse(departmentId);
        await employeeService.Add(employee);
        navigationManager.NavigateTo($"/employee/{departmentId}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\eatcl\RiderProjects\FINALAssignment\FINALAssignment\Pages\RegisterAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "427632056f73c00cb1860eb4cbf0482d7071ff5e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FINALAssignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\eatcl\RiderProjects\FINALAssignment\FINALAssignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eatcl\RiderProjects\FINALAssignment\FINALAssignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eatcl\RiderProjects\FINALAssignment\FINALAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\eatcl\RiderProjects\FINALAssignment\FINALAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\eatcl\RiderProjects\FINALAssignment\FINALAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\eatcl\RiderProjects\FINALAssignment\FINALAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\eatcl\RiderProjects\FINALAssignment\FINALAssignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\eatcl\RiderProjects\FINALAssignment\FINALAssignment\_Imports.razor"
using FINALAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\eatcl\RiderProjects\FINALAssignment\FINALAssignment\_Imports.razor"
using FINALAssignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eatcl\RiderProjects\FINALAssignment\FINALAssignment\Pages\RegisterAdult.razor"
using FINALAssignment.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegisterAdult")]
    public partial class RegisterAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\eatcl\RiderProjects\FINALAssignment\FINALAssignment\Pages\RegisterAdult.razor"
       
    private String username;
    private String password;
    private String name;
    private String errorMessage;
    private int ID;
    
    public async Task CreateAdult() {
        errorMessage = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).CreateUser(name, username, password, ID);
            name = "";
            username = "";
            password = "";
            NavigationManager.NavigateTo("/RegisterAdult");
        } catch (Exception e) {
            errorMessage = e.Message;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591

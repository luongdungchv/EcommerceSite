// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FrontEnd.Shared.Components
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using FrontEnd.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using FrontEnd.Shared.ItemSiteComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using MongoDB.Driver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\MyProjects\Github\EcommerceSite\FrontEnd\_Imports.razor"
using FrontEnd.Shared.ProductListSite;

#line default
#line hidden
#nullable disable
    public partial class ProductBtn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Shared\Components\ProductBtn.razor"
      
    [Parameter]
    public ProductData Data{get;set;}
    [Parameter]
    public int Position{get;set;}
    [Parameter]
    public string CustomStyle{get;set;}
    private void OnClick(){
        navManager.NavigateTo($"item/{Data.Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
    }
}
#pragma warning restore 1591

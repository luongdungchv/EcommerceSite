#pragma checksum "D:\MyProjects\Github\EcommerceSite\FrontEnd\Shared\ProductListSite\FilterPanel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be783100bc6329ceeb365dc96378ba1b983a7480"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontEnd.Shared.ProductListSite
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
    public partial class FilterPanel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "filter-panel");
            __builder.AddAttribute(2, "b-90w05fdzij");
            __builder.OpenElement(3, "p");
            __builder.AddAttribute(4, "b-90w05fdzij");
            __builder.AddContent(5, 
#nullable restore
#line 2 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Shared\ProductListSite\FilterPanel.razor"
        Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 3 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Shared\ProductListSite\FilterPanel.razor"
      Console.WriteLine(filterMenu.Count.ToString()+"S");

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Shared\ProductListSite\FilterPanel.razor"
     foreach(var i in filterMenu){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "label");
            __builder.AddAttribute(7, "class", "filter-item");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Shared\ProductListSite\FilterPanel.razor"
                                               () => ClickCallback(i.Value)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "b-90w05fdzij");
            __builder.AddMarkupContent(10, "<input type=\"radio\" name=\"items\" b-90w05fdzij>\r\n            <div class=\"checkmark\" b-90w05fdzij></div>\r\n            ");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "class", "text");
            __builder.AddAttribute(13, "b-90w05fdzij");
            __builder.AddContent(14, 
#nullable restore
#line 8 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Shared\ProductListSite\FilterPanel.razor"
                                i.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 10 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Shared\ProductListSite\FilterPanel.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Shared\ProductListSite\FilterPanel.razor"
      
    [Parameter]
    public Dictionary<string, Expression<Func<ProductData, bool>>> filterMenu{get;set;}
    [Parameter]
    public string Name{get;set;}
    [Parameter]
    public Action<Expression<Func<ProductData, bool>>> ClickCallback{get;set;}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\Shared\Components\ProductCategoryBtn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea28a86c3e1372a7180576aa25e8117b6a601e4e"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontEnd.Shared.Components
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using FrontEnd.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using FrontEnd.Shared.ItemSiteComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using MongoDB.Driver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\_Imports.razor"
using FrontEnd.Shared.ProductListSite;

#line default
#line hidden
#nullable disable
    public partial class ProductCategoryBtn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "product-cate-btn");
            __builder.AddAttribute(2, "b-ur6xjcq6vq");
            __builder.AddMarkupContent(3, "<span b-ur6xjcq6vq>Something written here</span>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "banner-color");
            __builder.AddAttribute(6, "style", "background-color:" + " " + (
#nullable restore
#line 3 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\Shared\Components\ProductCategoryBtn.razor"
                                                         Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-ur6xjcq6vq");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 5 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\Shared\Components\ProductCategoryBtn.razor"
               ImgSrc

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "alt");
            __builder.AddAttribute(12, "b-ur6xjcq6vq");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\Shared\Components\ProductCategoryBtn.razor"
      
    [Parameter]
    public string Color {get;set;}
    [Parameter]
    public string ImgSrc {get;set;}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

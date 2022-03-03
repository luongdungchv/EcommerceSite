#pragma checksum "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f59eac7b17da71063e3a54a769a90cec082c4a53"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontEnd.Pages
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainPageLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main-site");
            __builder.AddAttribute(2, "b-0at5ar3qz3");
            __builder.OpenComponent<FrontEnd.Shared.Components.ImgSlider>(3);
            __builder.AddAttribute(4, "SrcList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 6 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\Pages\Index.razor"
                     srcList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ImgWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Single>(
#nullable restore
#line 6 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\Pages\Index.razor"
                                          73

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ImgWidthUnit", "vw");
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenComponent<FrontEnd.Shared.Components.BannerTitle>(8);
            __builder.AddAttribute(9, "Name", "Product Categories");
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenComponent<FrontEnd.Shared.Components.ProductCategory>(11);
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenComponent<FrontEnd.Shared.Components.BannerTitle>(13);
            __builder.AddAttribute(14, "Name", "Discounts");
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenComponent<FrontEnd.Shared.Components.ProductDiscounts>(16);
            __builder.AddAttribute(17, "productDatas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProductData[]>(
#nullable restore
#line 10 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\Pages\Index.razor"
                                     dataList

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\MyProjects\VScode Projects\EcommerceSite\FrontEnd\Pages\Index.razor"
 
    private string[] srcList = {
        "https://www.tncstore.vn/image/catalog/banner/2022/Thang1/Banner_Web_1650_660.png",
        "https://www.tncstore.vn/image/catalog/banner/2021/thang%2011/Banner%201650x660%20-%202.png",
        "https://www.tncstore.vn/image/catalog/banner/2021/thang%2011/Banner%201650x660%20-%203.png"
    };
    private ProductData[] dataList = {
        new ProductData("Something called a computer", 7000000, 6000000),    
        new ProductData("Something called a computer", 7000000, 6000000),
        new ProductData("Something called a computer", 7000000, 6000000),
        new ProductData("Something called a computer", 7000000, 6000000),
        new ProductData("Something called a computer", 7000000, 6000000),
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

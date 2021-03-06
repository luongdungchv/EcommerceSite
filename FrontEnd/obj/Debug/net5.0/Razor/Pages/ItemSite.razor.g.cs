#pragma checksum "D:\MyProjects\Github\EcommerceSite\FrontEnd\Pages\ItemSite.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e4cb421df3ab9530a07c68c33a89bed75baa98e"
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
#nullable restore
#line 3 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Pages\ItemSite.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainPageLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/item/{Id}")]
    public partial class ItemSite : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "item-site");
            __builder.AddAttribute(2, "b-s12hx1azxv");
            __builder.OpenComponent<FrontEnd.Shared.Components.NavTree>(3);
            __builder.AddAttribute(4, "navigatorTree", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 6 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Pages\ItemSite.razor"
                               navigatorTree

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenComponent<FrontEnd.Shared.ItemSiteComponents.ItemSummary>(6);
            __builder.AddAttribute(7, "data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProductData>(
#nullable restore
#line 7 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Pages\ItemSite.razor"
                        data

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenComponent<FrontEnd.Shared.Components.BannerTitle>(9);
            __builder.AddAttribute(10, "Name", "Product Infos");
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenComponent<FrontEnd.Shared.ItemSiteComponents.ItemDetails>(12);
            __builder.AddAttribute(13, "data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProductData>(
#nullable restore
#line 9 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Pages\ItemSite.razor"
                          data

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\MyProjects\Github\EcommerceSite\FrontEnd\Pages\ItemSite.razor"
       
    [Parameter]
    public string Id { get; set; }
    private ProductData data;
    private string dataStr = "";
    private List<string> navigatorTree = new();
    protected override async Task OnInitializedAsync()
    {
        var client = new MongoClient("mongodb://127.0.0.1:27017");
        var db = client.GetDatabase("EcommerceSite");
        var collection = db.GetCollection<ProductData>("Items");
        var filter = Builders<ProductData>.Filter.Eq(m => m.Id, Id);
        data = await collection.Find(filter).FirstOrDefaultAsync();
        navigatorTree = Category.GetTree(data.Type);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Source\Repos\Blazor\BlazorTrader\Components\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3acd95e5604f15d500bd9ba828b196119b41b794"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTrader.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using BlazorTrader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using BlazorTrader.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Source\Repos\Blazor\BlazorTrader\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Source\Repos\Blazor\BlazorTrader\Components\ChildComponent.razor"
using BlazorTrader.Data;

#line default
#line hidden
#nullable disable
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "background-color:lightgray;");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "padding:1vw;");
            __builder.AddMarkupContent(5, "\r\n        Name: <br>\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 7 "D:\Source\Repos\Blazor\BlazorTrader\Components\ChildComponent.razor"
                                                                      KeyPressed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "D:\Source\Repos\Blazor\BlazorTrader\Components\ChildComponent.razor"
                       Customer.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Customer.Name = __value, Customer.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        <br><br>\r\n        Email: <br>\r\n        ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 10 "D:\Source\Repos\Blazor\BlazorTrader\Components\ChildComponent.razor"
                                                                       KeyPressed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\Source\Repos\Blazor\BlazorTrader\Components\ChildComponent.razor"
                       Customer.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Customer.Email = __value, Customer.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\Source\Repos\Blazor\BlazorTrader\Components\ChildComponent.razor"
       

    [Parameter]
    public CustomerClass Customer { get; set; }

    [Parameter]
    public EventCallback<string> ComponentDataUpdated { get; set; }

    /// <summary>
    /// This invokes a parent-supplied event to update a parent value.
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    async Task KeyPressed(KeyboardEventArgs args) {
        await ComponentDataUpdated.InvokeAsync("");
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

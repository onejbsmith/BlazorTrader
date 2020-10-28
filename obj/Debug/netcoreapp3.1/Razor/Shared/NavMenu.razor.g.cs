#pragma checksum "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b29b54ecdcffba450eb300c5958efae2fea4fe1"
// <auto-generated/>
#pragma warning disable 1591
namespace tdaStreamHub.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using tdaStreamHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using tdaStreamHub.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\Shared\NavMenu.razor"
using tdaStreamHub.Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-2 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    <img src=\"./favicon.ico\" style=\"width:16px;margin-right:5px\">\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href><i style=\"color:#009bec\">tape</i>Stream</a>\r\n    ");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "src", 
#nullable restore
#line 5 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\Shared\NavMenu.razor"
               hubStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "style", "width:16px;");
            __builder.AddAttribute(7, "title", "tapeStream Hub Connection Status");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<span>&nbsp;&nbsp;</span>\r\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "navbar-toggler");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", 
#nullable restore
#line 14 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "style", "top:30px");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\Shared\NavMenu.razor"
                                                         ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "ul");
            __builder.AddAttribute(22, "class", "nav flex-column");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "li");
            __builder.AddAttribute(25, "class", "nav-item px-3");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(27);
            __builder.AddAttribute(28, "class", "nav-link");
            __builder.AddAttribute(29, "href", "");
            __builder.AddAttribute(30, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 17 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.OpenElement(33, "span");
                __builder2.AddAttribute(34, "class", "oi");
                __builder2.AddAttribute(35, "aria-hidden", "true");
                __builder2.OpenComponent<Radzen.Blazor.RadzenIcon>(36);
                __builder2.AddAttribute(37, "Icon", "home");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddContent(38, "  The  ");
                __builder2.AddMarkupContent(39, "<i style=\"color:#009bec\">tape</i>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n        ");
            __builder.OpenElement(42, "li");
            __builder.AddAttribute(43, "class", "nav-item px-3");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
            __builder.AddAttribute(46, "class", "nav-link");
            __builder.AddAttribute(47, "href", "streamer");
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.OpenElement(50, "span");
                __builder2.AddAttribute(51, "class", "oi");
                __builder2.AddAttribute(52, "aria-hidden", "true");
                __builder2.OpenComponent<Radzen.Blazor.RadzenIcon>(53);
                __builder2.AddAttribute(54, "Icon", "waves");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, " &nbsp;Streaming\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n        ");
            __builder.OpenElement(58, "li");
            __builder.AddAttribute(59, "class", "nav-item px-3");
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(61);
            __builder.AddAttribute(62, "class", "nav-link");
            __builder.AddAttribute(63, "href", "tdaAuth");
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.OpenElement(66, "span");
                __builder2.AddAttribute(67, "class", "oi");
                __builder2.AddAttribute(68, "aria-hidden", "true");
                __builder2.OpenComponent<Radzen.Blazor.RadzenIcon>(69);
                __builder2.AddAttribute(70, "Icon", "security");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, " &nbsp;Authorization\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n\r\n");
            __builder.AddMarkupContent(76, "<style>\r\n    html, body, body * {\r\n        background-color: transparent;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\Source\Repos\Blazor\Server Projects\BlazorTrader\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    string hubStatus = "";

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    protected override async Task OnInitializedAsync()
    {
        hubStatus = TDAStreamerData.hubStatus;

        TDAStreamerData.OnHubStatusChanged += HubStatusChanged;
        await Task.CompletedTask;
    }

    public void HubStatusChanged()
    {
        hubStatus = TDAStreamerData.hubStatus;
        StateChangedAsync();
    }

    private async Task StateChangedAsync()
    {
        await InvokeAsync(() => StateHasChanged());
    }

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Source\Repos\Blazor\BlazorTrader\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c016af6b978c9e73b199246e6b6e1347515e371"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTrader
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.ThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Theme>(
#nullable restore
#line 1 "D:\Source\Repos\Blazor\BlazorTrader\App.razor"
                                 theme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(4);
                __builder2.AddAttribute(5, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "D:\Source\Repos\Blazor\BlazorTrader\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(8);
                    __builder3.AddAttribute(9, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 5 "D:\Source\Repos\Blazor\BlazorTrader\App.razor"
                                   routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 5 "D:\Source\Repos\Blazor\BlazorTrader\App.razor"
                                                              typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n        ");
                }
                ));
                __builder2.AddAttribute(12, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(14);
                    __builder3.AddAttribute(15, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 8 "D:\Source\Repos\Blazor\BlazorTrader\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(17, "\r\n                ");
                        __builder4.AddMarkupContent(18, "<p>Sorry, there\'s nothing at this address.</p>\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\Source\Repos\Blazor\BlazorTrader\App.razor"
      
    private Blazorise.Theme theme = new Blazorise.Theme
    {
        // theme settings
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Source\Repos\Blazor\BlazorTrader\Components\BookGaugeChart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "990579cba4707654d9e80539ca912c966f4f6b22"
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
#line 2 "D:\Source\Repos\Blazor\BlazorTrader\Components\BookGaugeChart.razor"
using BlazorTrader.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Source\Repos\Blazor\BlazorTrader\Components\BookGaugeChart.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    public partial class BookGaugeChart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(1);
            __builder.AddAttribute(2, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "D:\Source\Repos\Blazor\BlazorTrader\Components\BookGaugeChart.razor"
                        bids

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", 
#nullable restore
#line 5 "D:\Source\Repos\Blazor\BlazorTrader\Components\BookGaugeChart.razor"
                                      badgeClass

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n   ");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(5);
            __builder.AddAttribute(6, "Style", "\r\n        width: 75px; height: 75px;\r\n        position: relative; right: 55px; top: 40px");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n    ");
                __Blazor.BlazorTrader.Components.BookGaugeChart.TypeInference.CreateRadzenPieSeries_0(__builder2, 9, 10, 
#nullable restore
#line 11 "D:\Source\Repos\Blazor\BlazorTrader\Components\BookGaugeChart.razor"
               bookData

#line default
#line hidden
#nullable disable
                , 11, "Price", 12, 
#nullable restore
#line 11 "D:\Source\Repos\Blazor\BlazorTrader\Components\BookGaugeChart.razor"
                                                          30

#line default
#line hidden
#nullable disable
                , 13, 
#nullable restore
#line 12 "D:\Source\Repos\Blazor\BlazorTrader\Components\BookGaugeChart.razor"
                 seconds.ToString()

#line default
#line hidden
#nullable disable
                , 14, 
#nullable restore
#line 13 "D:\Source\Repos\Blazor\BlazorTrader\Components\BookGaugeChart.razor"
                 new List<string>() {  "green","red"}

#line default
#line hidden
#nullable disable
                , 15, "Size");
                __builder2.AddMarkupContent(16, "\r\n\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenChartTooltipOptions>(17);
                __builder2.AddAttribute(18, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\Source\Repos\Blazor\BlazorTrader\Components\BookGaugeChart.razor"
                                        false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLegend>(20);
                __builder2.AddAttribute(21, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\Source\Repos\Blazor\BlazorTrader\Components\BookGaugeChart.razor"
                           false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.AddMarkupContent(24, "<style>\r\n\r\n    .article {\r\n        flex: 1 0 auto;\r\n        border: solid 2px green;\r\n        max-height: 40px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\Source\Repos\Blazor\BlazorTrader\Components\BookGaugeChart.razor"
       

    string badgeClass = "btn";
    string bids;
    string asks;

    [Parameter]
    public string symbol { get; set; }

    [Parameter]
    public int seconds { get; set; }

    [Parameter]
    public bool isPrintsSize { get; set; }


    BookDataItem[] bookData = new BookDataItem[0];
    //   {
    //new BookDataItem { Price = 350.11m, Size = 1000 },
    //new BookDataItem { Price = 351m, Size = 501 } };


    protected override async Task OnInitializedAsync()
    {
        TDAStreamerData.OnStatusesChanged += getBookData;
        StateHasChanged();
        await Task.CompletedTask;
    }

    public void getBookData()
    {
        TDAStreamerData.getBookCompositePieData(ref bookData, seconds, isPrintsSize, symbol);

        if (bookData == null || bookData[0]==null || bookData.Length == 0) return;
        bids = (100 * (bookData[1].Size / bookData[0].Size - 1)).ToString("n0");
        int nBids = Convert.ToInt16(bids);

        //if (nBids < -20)
        //    badgeClass = "alert-danger article";
        //else if (nBids > 20)
        //    badgeClass = "alert-success article";
        //else
        //    badgeClass = "alert-warning article";

        StateHasChanged();

    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorTrader.Components.BookGaugeChart
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenPieSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Double? __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Collections.Generic.IEnumerable<global::System.String> __arg4, int __seq5, global::System.String __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenPieSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "Radius", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "Fills", __arg4);
        __builder.AddAttribute(__seq5, "ValueProperty", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f187bac322cb8ebb55f09152ad1284221495683b"
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
#line 2 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
    public partial class SyncfusionStackedColumnChart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "control-section");
            __builder.AddAttribute(2, "style", "padding-bottom:150px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfChart>(4);
            __builder.AddAttribute(5, "Title", "");
            __builder.AddAttribute(6, "Palettes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 6 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                 palettes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "EnableAnimation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                            false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "EnableAutoIntervalOnBothAxis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                                 false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartEvents>(11);
                __builder2.AddAttribute(12, "Load", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Charts.ILoadedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Charts.ILoadedEventArgs>(this, 
#nullable restore
#line 7 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                           ChartLoad

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartArea>(14);
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartAreaBorder>(16);
                    __builder3.AddAttribute(17, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 8 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                           0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryXAxis>(19);
                __builder2.AddAttribute(20, "ValueType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ValueType>(
#nullable restore
#line 9 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                      Syncfusion.Blazor.Charts.ValueType.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Interval", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 9 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                             1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "LabelIntersectAction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.LabelIntersectAction>(
#nullable restore
#line 9 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                                                      LabelIntersectAction.Rotate45

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(24, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisMajorGridLines>(25);
                    __builder3.AddAttribute(26, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 10 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                            0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisMinorGridLines>(28);
                    __builder3.AddAttribute(29, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 11 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                            0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisMajorTickLines>(31);
                    __builder3.AddAttribute(32, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 12 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                            0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisMinorTickLines>(34);
                    __builder3.AddAttribute(35, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 13 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                            0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisLineStyle>(37);
                    __builder3.AddAttribute(38, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 14 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                       0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryYAxis>(41);
                __builder2.AddAttribute(42, "Title", "Sales");
                __builder2.AddAttribute(43, "Minimum", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                  0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "Maximum", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                               maxY

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "Interval", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                intervalY

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "LabelFormat", "{value}");
                __builder2.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(48, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisLineStyle>(49);
                    __builder3.AddAttribute(50, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 17 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                       0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisMajorGridLines>(52);
                    __builder3.AddAttribute(53, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 18 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                            1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisMinorGridLines>(55);
                    __builder3.AddAttribute(56, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 19 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                            1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisMajorTickLines>(58);
                    __builder3.AddAttribute(59, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 20 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                            0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisMinorTickLines>(61);
                    __builder3.AddAttribute(62, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 21 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                            0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartSeriesCollection>(65);
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(67, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(68);
                    __builder3.AddAttribute(69, "EnableTooltip", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                        false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                            DataSource

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "XName", "x");
                    __builder3.AddAttribute(72, "YName", "y");
                    __builder3.AddAttribute(73, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 24 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                                   5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "Name", "Below");
                    __builder3.AddAttribute(75, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 24 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                                                         ChartSeriesType.StackingColumn

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(77);
                    __builder3.AddAttribute(78, "EnableTooltip", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                        false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                            DataSource

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "XName", "x");
                    __builder3.AddAttribute(81, "YName", "y1");
                    __builder3.AddAttribute(82, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 26 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                                    5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "Name", "At Bid");
                    __builder3.AddAttribute(84, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 26 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                                                           ChartSeriesType.StackingColumn

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(86);
                    __builder3.AddAttribute(87, "EnableTooltip", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                        false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 28 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                            DataSource

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(89, "XName", "x");
                    __builder3.AddAttribute(90, "YName", "y2");
                    __builder3.AddAttribute(91, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 28 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                                    5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(92, "Name", "Between");
                    __builder3.AddAttribute(93, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 28 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                                                            ChartSeriesType.StackingColumn

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(94, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(95);
                    __builder3.AddAttribute(96, "EnableTooltip", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                        false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(97, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                            DataSource

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(98, "XName", "x");
                    __builder3.AddAttribute(99, "YName", "y3");
                    __builder3.AddAttribute(100, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 30 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                                    5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(101, "Name", "At Ask");
                    __builder3.AddAttribute(102, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 30 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                                                           ChartSeriesType.StackingColumn

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(104);
                    __builder3.AddAttribute(105, "EnableTooltip", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                        false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(106, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 32 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                            DataSource

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(107, "XName", "x");
                    __builder3.AddAttribute(108, "YName", "y4");
                    __builder3.AddAttribute(109, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 32 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                                    5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(110, "Name", "Above");
                    __builder3.AddAttribute(111, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 32 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                                                                                          ChartSeriesType.StackingColumn

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(112, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartTooltipSettings>(114);
                __builder2.AddAttribute(115, "Enable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                      false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(116, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(117, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(118);
            __builder.AddAttribute(119, "Text", "Seconds:");
            __builder.CloseComponent();
            __builder.AddMarkupContent(120, "\r\n    ");
            __Blazor.BlazorTrader.Components.SyncfusionStackedColumnChart.TypeInference.CreateRadzenNumeric_0(__builder, 121, 122, 
#nullable restore
#line 38 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                        2

#line default
#line hidden
#nullable disable
            , 123, 
#nullable restore
#line 38 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                600

#line default
#line hidden
#nullable disable
            , 124, "1", 125, 
#nullable restore
#line 38 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
                                                      seconds

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(126, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\Source\Repos\Blazor\BlazorTrader\Components\SyncfusionStackedColumnChart.razor"
      
    [Parameter]
    public string symbol { get; set; }

    [Parameter]
    public int seconds { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.BlazorTrader.Components.SyncfusionStackedColumnChart
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Decimal? __arg0, int __seq1, global::System.Decimal? __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Min", __arg0);
        __builder.AddAttribute(__seq1, "Max", __arg1);
        __builder.AddAttribute(__seq2, "Step", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

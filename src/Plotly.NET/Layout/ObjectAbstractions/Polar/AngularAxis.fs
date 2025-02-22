﻿namespace Plotly.NET.LayoutObjects

open Plotly.NET
open DynamicObj
open System
open System.Runtime.InteropServices


/// <summary>Angular axes can be used as a scale for the angular coordinates in polar plots.</summary>
type AngularAxis() =
    inherit DynamicObj()

    /// <summary>
    /// Initialize an AngularAxis object that can be used as a angular scale for polar coordinates.
    /// </summary>
    /// <param name="Visible">A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false</param>
    /// <param name="AxisType">Sets the angular axis type. If "linear", set `thetaunit` to determine the unit in which axis value are shown. If "category, use `period` to set the number of integer coordinates around polar axis.</param>
    /// <param name="AutoTypeNumbers">Using "strict" a numeric string in trace data is not converted to a number. Using "convert types" a numeric string in trace data may be treated as a number during automatic axis `type` detection. Defaults to layout.autotypenumbers.</param>
    /// <param name="CategoryOrder">Specifies the ordering logic for the case of categorical variables. By default, plotly uses "trace", which specifies the order that is present in the data supplied. Set `categoryorder` to "category ascending" or "category descending" if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to "array" to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the "trace" mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to "total ascending" or "total descending" if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.</param>
    /// <param name="CategoryArray">Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to "array". Used with `categoryorder`.</param>
    /// <param name="ThetaUnit">Sets the format unit of the formatted "theta" values. Has an effect only when `angularaxis.type` is "linear".</param>
    /// <param name="Period">Set the angular period. Has an effect only when `angularaxis.type` is "category".</param>
    /// <param name="Direction">Sets the direction corresponding to positive angles.</param>
    /// <param name="Rotation">Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to "counterclockwise" get a `rotation` of "0" which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to "clockwise" get a rotation of "90" which corresponds to due North (like on a compass),</param>
    /// <param name="HoverFormat">Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format. And for dates see: https://github.com/d3/d3-time-format#locale_format. We add two items to d3's date formatter: "%h" for half of the year as a decimal number as well as "%{n}f" for fractional seconds with n digits. For example, "2016-10-13 09:15:23.456" with TickFormat "%H~%M~%S.%2f" would display "09~15~23.46"</param>
    /// <param name="UIRevision">Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar&lt;N&gt;.uirevision`.</param>
    /// <param name="Color">Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.</param>
    /// <param name="ShowLine">Determines whether or not a line bounding this axis is drawn.</param>
    /// <param name="LineColor">Sets the axis line color.</param>
    /// <param name="LineWidth">Sets the width (in px) of the axis line.</param>
    /// <param name="ShowGrid">Determines whether or not grid lines are drawn. If "true", the grid lines are drawn at every tick mark.</param>
    /// <param name="GridColor">Sets the color of the grid lines.</param>
    /// <param name="GridWidth">Sets the width (in px) of the grid lines.</param>
    /// <param name="TickMode">Sets the tick mode for this axis. If "auto", the number of ticks is set via `nticks`. If "linear", the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` ("linear" is the default value if `tick0` and `dtick` are provided). If "array", the placement of the ticks is set via `TickVals` and the tick text is `TickText`. ("array" is the default value if `TickVals` is provided).</param>
    /// <param name="NTicks">Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to "auto".</param>
    /// <param name="Tick0">Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is "log", then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`="L&lt;f&gt;" (see `dtick` for more info). If the axis `type` is "date", it should be a date string, like date data. If the axis `type` is "category", it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.</param>
    /// <param name="DTick">Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to "log" and "date" axes. If the axis `type` is "log", then ticks are set every 10^(n"dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. "log" has several special values; "L&lt;f&gt;", where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = "L0.5" will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use "D1" (all digits) or "D2" (only 2 and 5). `tick0` is ignored for "D1" and "D2". If the axis `type` is "date", then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. "date" also has special values "M&lt;n&gt;" gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to "2000-01-15" and `dtick` to "M3". To set ticks every 4 years, set `dtick` to "M48"</param>
    /// <param name="TickVals">Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to "array". Used with `TickText`.</param>
    /// <param name="TickText">Sets the text displayed at the ticks position via `TickVals`. Only has an effect if `tickmode` is set to "array". Used with `TickVals`.</param>
    /// <param name="Ticks">Determines whether ticks are drawn or not. If "", this axis' ticks are not drawn. If "outside" ("inside"), this axis' are drawn outside (inside) the axis lines.</param>
    /// <param name="TickLen">Sets the tick length (in px).</param>
    /// <param name="TickWidth">Sets the tick width (in px).</param>
    /// <param name="TickColor">Sets the tick color.</param>
    /// <param name="ShowTickLabels">Determines whether or not the tick labels are drawn.</param>
    /// <param name="ShowTickPrefix">If "all", all tick labels are displayed with a prefix. If "first", only the first tick is displayed with a prefix. If "last", only the last tick is displayed with a suffix. If "none", tick prefixes are hidden.</param>
    /// <param name="TickPrefix">Sets a tick label prefix.</param>
    /// <param name="ShowTickSuffix">Same as `showtickprefix` but for tick suffixes.</param>
    /// <param name="TickSuffix">Sets a tick label suffix.</param>
    /// <param name="ShowExponent">If "all", all exponents are shown besides their significands. If "first", only the exponent of the first tick is shown. If "last", only the exponent of the last tick is shown. If "none", no exponents appear.</param>
    /// <param name="ExponentFormat">Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If "none", it appears as 1,000,000,000. If "e", 1e+9. If "E", 1E+9. If "power", 1x10^9 (with 9 in a super script). If "SI", 1G. If "B", 1B.</param>
    /// <param name="MinExponent">Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `TickFormat` is "SI" or "B".</param>
    /// <param name="SeparateThousands">If "true", even 4-digit integers are separated</param>
    /// <param name="TickFont">Sets the tick font.</param>
    /// <param name="TickAngle">Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.</param>
    /// <param name="TickFormat">Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format. And for dates see: https://github.com/d3/d3-time-format#locale_format. We add two items to d3's date formatter: "%h" for half of the year as a decimal number as well as "%{n}f" for fractional seconds with n digits. For example, "2016-10-13 09:15:23.456" with TickFormat "%H~%M~%S.%2f" would display "09~15~23.46"</param>
    /// <param name="TickFormatStops">Set rules for customizing TickFormat on different zoom levels</param>
    /// <param name="TickLabelStep">Sets the spacing between tick labels as compared to the spacing between ticks. A value of 1 (default) means each tick gets a label. A value of 2 means shows every 2nd label. A larger value n means only every nth tick is labeled. `tick0` determines which labels are shown. Not implemented for axes with `type` "log" or "multicategory", or when `tickmode` is "array".</param>
    /// <param name="Layer">Sets the layer on which this axis is displayed. If "above traces", this axis is displayed above all the subplot's traces If "below traces", this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to "false" to show markers and/or text nodes above this axis.</param>
    static member init
        (
            [<Optional; DefaultParameterValue(null)>] ?Visible: bool,
            [<Optional; DefaultParameterValue(null)>] ?AxisType: StyleParam.AxisType,
            [<Optional; DefaultParameterValue(null)>] ?AutoTypeNumbers: StyleParam.AutoTypeNumbers,
            [<Optional; DefaultParameterValue(null)>] ?CategoryOrder: StyleParam.CategoryOrder,
            [<Optional; DefaultParameterValue(null)>] ?CategoryArray: seq<#IConvertible>,
            [<Optional; DefaultParameterValue(null)>] ?ThetaUnit: StyleParam.AngularUnit,
            [<Optional; DefaultParameterValue(null)>] ?Period: float,
            [<Optional; DefaultParameterValue(null)>] ?Direction: StyleParam.Direction,
            [<Optional; DefaultParameterValue(null)>] ?Rotation: int,
            [<Optional; DefaultParameterValue(null)>] ?HoverFormat: string,
            [<Optional; DefaultParameterValue(null)>] ?UIRevision: #IConvertible,
            [<Optional; DefaultParameterValue(null)>] ?Color: Color,
            [<Optional; DefaultParameterValue(null)>] ?ShowLine: bool,
            [<Optional; DefaultParameterValue(null)>] ?LineColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?LineWidth: int,
            [<Optional; DefaultParameterValue(null)>] ?ShowGrid: bool,
            [<Optional; DefaultParameterValue(null)>] ?GridColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?GridWidth: int,
            [<Optional; DefaultParameterValue(null)>] ?TickMode: StyleParam.TickMode,
            [<Optional; DefaultParameterValue(null)>] ?NTicks: int,
            [<Optional; DefaultParameterValue(null)>] ?Tick0: #IConvertible,
            [<Optional; DefaultParameterValue(null)>] ?DTick: #IConvertible,
            [<Optional; DefaultParameterValue(null)>] ?TickVals: seq<#IConvertible>,
            [<Optional; DefaultParameterValue(null)>] ?TickText: seq<#IConvertible>,
            [<Optional; DefaultParameterValue(null)>] ?Ticks: StyleParam.TickOptions,
            [<Optional; DefaultParameterValue(null)>] ?TickLen: int,
            [<Optional; DefaultParameterValue(null)>] ?TickWidth: int,
            [<Optional; DefaultParameterValue(null)>] ?TickColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?ShowTickLabels: bool,
            [<Optional; DefaultParameterValue(null)>] ?ShowTickPrefix: StyleParam.ShowTickOption,
            [<Optional; DefaultParameterValue(null)>] ?TickPrefix: string,
            [<Optional; DefaultParameterValue(null)>] ?ShowTickSuffix: StyleParam.ShowTickOption,
            [<Optional; DefaultParameterValue(null)>] ?TickSuffix: string,
            [<Optional; DefaultParameterValue(null)>] ?ShowExponent: StyleParam.ShowExponent,
            [<Optional; DefaultParameterValue(null)>] ?ExponentFormat: StyleParam.ExponentFormat,
            [<Optional; DefaultParameterValue(null)>] ?MinExponent: float,
            [<Optional; DefaultParameterValue(null)>] ?SeparateThousands: bool,
            [<Optional; DefaultParameterValue(null)>] ?TickFont: Font,
            [<Optional; DefaultParameterValue(null)>] ?TickAngle: int,
            [<Optional; DefaultParameterValue(null)>] ?TickFormat: string,
            [<Optional; DefaultParameterValue(null)>] ?TickFormatStops: seq<TickFormatStop>,
            [<Optional; DefaultParameterValue(null)>] ?TickLabelStep: int,
            [<Optional; DefaultParameterValue(null)>] ?Layer: StyleParam.Layer
        ) =
        AngularAxis()
        |> AngularAxis.style (
            ?Visible = Visible,
            ?AxisType = AxisType,
            ?AutoTypeNumbers = AutoTypeNumbers,
            ?CategoryOrder = CategoryOrder,
            ?CategoryArray = CategoryArray,
            ?ThetaUnit = ThetaUnit,
            ?Period = Period,
            ?Direction = Direction,
            ?Rotation = Rotation,
            ?HoverFormat = HoverFormat,
            ?UIRevision = UIRevision,
            ?Color = Color,
            ?ShowLine = ShowLine,
            ?LineColor = LineColor,
            ?LineWidth = LineWidth,
            ?ShowGrid = ShowGrid,
            ?GridColor = GridColor,
            ?GridWidth = GridWidth,
            ?TickMode = TickMode,
            ?NTicks = NTicks,
            ?Tick0 = Tick0,
            ?DTick = DTick,
            ?TickVals = TickVals,
            ?TickText = TickText,
            ?Ticks = Ticks,
            ?TickLen = TickLen,
            ?TickWidth = TickWidth,
            ?TickColor = TickColor,
            ?ShowTickLabels = ShowTickLabels,
            ?ShowTickPrefix = ShowTickPrefix,
            ?TickPrefix = TickPrefix,
            ?ShowTickSuffix = ShowTickSuffix,
            ?TickSuffix = TickSuffix,
            ?ShowExponent = ShowExponent,
            ?ExponentFormat = ExponentFormat,
            ?MinExponent = MinExponent,
            ?SeparateThousands = SeparateThousands,
            ?TickFont = TickFont,
            ?TickAngle = TickAngle,
            ?TickFormat = TickFormat,
            ?TickFormatStops = TickFormatStops,
            ?TickLabelStep = TickLabelStep,
            ?Layer = Layer
        )

    /// <summary>
    /// Creates a function that applies the given style parameters to a AngularAxis object
    /// </summary>
    /// <param name="Visible">A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false</param>
    /// <param name="AxisType">Sets the angular axis type. If "linear", set `thetaunit` to determine the unit in which axis value are shown. If "category, use `period` to set the number of integer coordinates around polar axis.</param>
    /// <param name="AutoTypeNumbers">Using "strict" a numeric string in trace data is not converted to a number. Using "convert types" a numeric string in trace data may be treated as a number during automatic axis `type` detection. Defaults to layout.autotypenumbers.</param>
    /// <param name="CategoryOrder">Specifies the ordering logic for the case of categorical variables. By default, plotly uses "trace", which specifies the order that is present in the data supplied. Set `categoryorder` to "category ascending" or "category descending" if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to "array" to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the "trace" mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to "total ascending" or "total descending" if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.</param>
    /// <param name="CategoryArray">Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to "array". Used with `categoryorder`.</param>
    /// <param name="ThetaUnit">Sets the format unit of the formatted "theta" values. Has an effect only when `angularaxis.type` is "linear".</param>
    /// <param name="Period">Set the angular period. Has an effect only when `angularaxis.type` is "category".</param>
    /// <param name="Direction">Sets the direction corresponding to positive angles.</param>
    /// <param name="Rotation">Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to "counterclockwise" get a `rotation` of "0" which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to "clockwise" get a rotation of "90" which corresponds to due North (like on a compass),</param>
    /// <param name="HoverFormat">Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format. And for dates see: https://github.com/d3/d3-time-format#locale_format. We add two items to d3's date formatter: "%h" for half of the year as a decimal number as well as "%{n}f" for fractional seconds with n digits. For example, "2016-10-13 09:15:23.456" with TickFormat "%H~%M~%S.%2f" would display "09~15~23.46"</param>
    /// <param name="UIRevision">Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar&lt;N&gt;.uirevision`.</param>
    /// <param name="Color">Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.</param>
    /// <param name="ShowLine">Determines whether or not a line bounding this axis is drawn.</param>
    /// <param name="LineColor">Sets the axis line color.</param>
    /// <param name="LineWidth">Sets the width (in px) of the axis line.</param>
    /// <param name="ShowGrid">Determines whether or not grid lines are drawn. If "true", the grid lines are drawn at every tick mark.</param>
    /// <param name="GridColor">Sets the color of the grid lines.</param>
    /// <param name="GridWidth">Sets the width (in px) of the grid lines.</param>
    /// <param name="TickMode">Sets the tick mode for this axis. If "auto", the number of ticks is set via `nticks`. If "linear", the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` ("linear" is the default value if `tick0` and `dtick` are provided). If "array", the placement of the ticks is set via `TickVals` and the tick text is `TickText`. ("array" is the default value if `TickVals` is provided).</param>
    /// <param name="NTicks">Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to "auto".</param>
    /// <param name="Tick0">Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is "log", then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`="L&lt;f&gt;" (see `dtick` for more info). If the axis `type` is "date", it should be a date string, like date data. If the axis `type` is "category", it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.</param>
    /// <param name="DTick">Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to "log" and "date" axes. If the axis `type` is "log", then ticks are set every 10^(n"dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. "log" has several special values; "L&lt;f&gt;", where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = "L0.5" will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use "D1" (all digits) or "D2" (only 2 and 5). `tick0` is ignored for "D1" and "D2". If the axis `type` is "date", then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. "date" also has special values "M&lt;n&gt;" gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to "2000-01-15" and `dtick` to "M3". To set ticks every 4 years, set `dtick` to "M48"</param>
    /// <param name="TickVals">Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to "array". Used with `TickText`.</param>
    /// <param name="TickText">Sets the text displayed at the ticks position via `TickVals`. Only has an effect if `tickmode` is set to "array". Used with `TickVals`.</param>
    /// <param name="Ticks">Determines whether ticks are drawn or not. If "", this axis' ticks are not drawn. If "outside" ("inside"), this axis' are drawn outside (inside) the axis lines.</param>
    /// <param name="TickLen">Sets the tick length (in px).</param>
    /// <param name="TickWidth">Sets the tick width (in px).</param>
    /// <param name="TickColor">Sets the tick color.</param>
    /// <param name="ShowTickLabels">Determines whether or not the tick labels are drawn.</param>
    /// <param name="ShowTickPrefix">If "all", all tick labels are displayed with a prefix. If "first", only the first tick is displayed with a prefix. If "last", only the last tick is displayed with a suffix. If "none", tick prefixes are hidden.</param>
    /// <param name="TickPrefix">Sets a tick label prefix.</param>
    /// <param name="ShowTickSuffix">Same as `showtickprefix` but for tick suffixes.</param>
    /// <param name="TickSuffix">Sets a tick label suffix.</param>
    /// <param name="ShowExponent">If "all", all exponents are shown besides their significands. If "first", only the exponent of the first tick is shown. If "last", only the exponent of the last tick is shown. If "none", no exponents appear.</param>
    /// <param name="ExponentFormat">Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If "none", it appears as 1,000,000,000. If "e", 1e+9. If "E", 1E+9. If "power", 1x10^9 (with 9 in a super script). If "SI", 1G. If "B", 1B.</param>
    /// <param name="MinExponent">Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `TickFormat` is "SI" or "B".</param>
    /// <param name="SeparateThousands">If "true", even 4-digit integers are separated</param>
    /// <param name="TickFont">Sets the tick font.</param>
    /// <param name="TickAngle">Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.</param>
    /// <param name="TickFormat">Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format. And for dates see: https://github.com/d3/d3-time-format#locale_format. We add two items to d3's date formatter: "%h" for half of the year as a decimal number as well as "%{n}f" for fractional seconds with n digits. For example, "2016-10-13 09:15:23.456" with TickFormat "%H~%M~%S.%2f" would display "09~15~23.46"</param>
    /// <param name="TickFormatStops">Set rules for customizing TickFormat on different zoom levels</param>
    /// <param name="TickLabelStep">Sets the spacing between tick labels as compared to the spacing between ticks. A value of 1 (default) means each tick gets a label. A value of 2 means shows every 2nd label. A larger value n means only every nth tick is labeled. `tick0` determines which labels are shown. Not implemented for axes with `type` "log" or "multicategory", or when `tickmode` is "array".</param>
    /// <param name="Layer">Sets the layer on which this axis is displayed. If "above traces", this axis is displayed above all the subplot's traces If "below traces", this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to "false" to show markers and/or text nodes above this axis.</param>
    static member style
        (
            [<Optional; DefaultParameterValue(null)>] ?Visible: bool,
            [<Optional; DefaultParameterValue(null)>] ?AxisType: StyleParam.AxisType,
            [<Optional; DefaultParameterValue(null)>] ?AutoTypeNumbers: StyleParam.AutoTypeNumbers,
            [<Optional; DefaultParameterValue(null)>] ?CategoryOrder: StyleParam.CategoryOrder,
            [<Optional; DefaultParameterValue(null)>] ?CategoryArray: seq<#IConvertible>,
            [<Optional; DefaultParameterValue(null)>] ?ThetaUnit: StyleParam.AngularUnit,
            [<Optional; DefaultParameterValue(null)>] ?Period: float,
            [<Optional; DefaultParameterValue(null)>] ?Direction: StyleParam.Direction,
            [<Optional; DefaultParameterValue(null)>] ?Rotation: int,
            [<Optional; DefaultParameterValue(null)>] ?HoverFormat: string,
            [<Optional; DefaultParameterValue(null)>] ?UIRevision: #IConvertible,
            [<Optional; DefaultParameterValue(null)>] ?Color: Color,
            [<Optional; DefaultParameterValue(null)>] ?ShowLine: bool,
            [<Optional; DefaultParameterValue(null)>] ?LineColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?LineWidth: int,
            [<Optional; DefaultParameterValue(null)>] ?ShowGrid: bool,
            [<Optional; DefaultParameterValue(null)>] ?GridColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?GridWidth: int,
            [<Optional; DefaultParameterValue(null)>] ?TickMode: StyleParam.TickMode,
            [<Optional; DefaultParameterValue(null)>] ?NTicks: int,
            [<Optional; DefaultParameterValue(null)>] ?Tick0: #IConvertible,
            [<Optional; DefaultParameterValue(null)>] ?DTick: #IConvertible,
            [<Optional; DefaultParameterValue(null)>] ?TickVals: seq<#IConvertible>,
            [<Optional; DefaultParameterValue(null)>] ?TickText: seq<#IConvertible>,
            [<Optional; DefaultParameterValue(null)>] ?Ticks: StyleParam.TickOptions,
            [<Optional; DefaultParameterValue(null)>] ?TickLen: int,
            [<Optional; DefaultParameterValue(null)>] ?TickWidth: int,
            [<Optional; DefaultParameterValue(null)>] ?TickColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?ShowTickLabels: bool,
            [<Optional; DefaultParameterValue(null)>] ?ShowTickPrefix: StyleParam.ShowTickOption,
            [<Optional; DefaultParameterValue(null)>] ?TickPrefix: string,
            [<Optional; DefaultParameterValue(null)>] ?ShowTickSuffix: StyleParam.ShowTickOption,
            [<Optional; DefaultParameterValue(null)>] ?TickSuffix: string,
            [<Optional; DefaultParameterValue(null)>] ?ShowExponent: StyleParam.ShowExponent,
            [<Optional; DefaultParameterValue(null)>] ?ExponentFormat: StyleParam.ExponentFormat,
            [<Optional; DefaultParameterValue(null)>] ?MinExponent: float,
            [<Optional; DefaultParameterValue(null)>] ?SeparateThousands: bool,
            [<Optional; DefaultParameterValue(null)>] ?TickFont: Font,
            [<Optional; DefaultParameterValue(null)>] ?TickAngle: int,
            [<Optional; DefaultParameterValue(null)>] ?TickFormat: string,
            [<Optional; DefaultParameterValue(null)>] ?TickFormatStops: seq<TickFormatStop>,
            [<Optional; DefaultParameterValue(null)>] ?TickLabelStep: int,
            [<Optional; DefaultParameterValue(null)>] ?Layer: StyleParam.Layer
        ) =
        fun (angularAxis: AngularAxis) ->

            Visible |> DynObj.setValueOpt angularAxis "visible"
            AxisType |> DynObj.setValueOptBy angularAxis "type" StyleParam.AxisType.convert
            AutoTypeNumbers |> DynObj.setValueOptBy angularAxis "autotypenumbers" StyleParam.AutoTypeNumbers.convert
            CategoryOrder |> DynObj.setValueOptBy angularAxis "categoryorder" StyleParam.CategoryOrder.convert
            CategoryArray |> DynObj.setValueOpt angularAxis "categoryarray"
            ThetaUnit |> DynObj.setValueOpt angularAxis "thetaunit"
            Period |> DynObj.setValueOpt angularAxis "period"
            Direction |> DynObj.setValueOptBy angularAxis "direction" StyleParam.Direction.convert
            Rotation |> DynObj.setValueOpt angularAxis "rotation"
            HoverFormat |> DynObj.setValueOpt angularAxis "hoverformat"
            UIRevision |> DynObj.setValueOpt angularAxis "uirevision"
            Color |> DynObj.setValueOpt angularAxis "color"
            ShowLine |> DynObj.setValueOpt angularAxis "showline"
            LineColor |> DynObj.setValueOpt angularAxis "linecolor"
            LineWidth |> DynObj.setValueOpt angularAxis "linewidth"
            ShowGrid |> DynObj.setValueOpt angularAxis "showgrid"
            GridColor |> DynObj.setValueOpt angularAxis "gridcolor"
            GridWidth |> DynObj.setValueOpt angularAxis "gridwidth"
            TickMode |> DynObj.setValueOptBy angularAxis "tickmode" StyleParam.TickMode.convert
            NTicks |> DynObj.setValueOpt angularAxis "nticks"
            Tick0 |> DynObj.setValueOpt angularAxis "tick0"
            DTick |> DynObj.setValueOpt angularAxis "dtick"
            TickVals |> DynObj.setValueOpt angularAxis "tickvals"
            TickText |> DynObj.setValueOpt angularAxis "ticktext"
            Ticks |> DynObj.setValueOptBy angularAxis "ticks" StyleParam.TickOptions.convert
            TickLen |> DynObj.setValueOpt angularAxis "ticklen"
            TickWidth |> DynObj.setValueOpt angularAxis "tickwidth"
            TickColor |> DynObj.setValueOpt angularAxis "tickcolor"
            ShowTickLabels |> DynObj.setValueOpt angularAxis "showticklabels"
            ShowTickPrefix |> DynObj.setValueOptBy angularAxis "showtickprefix" StyleParam.ShowTickOption.convert
            TickPrefix |> DynObj.setValueOpt angularAxis "tickprefix"
            ShowTickSuffix |> DynObj.setValueOptBy angularAxis "showticksuffix" StyleParam.ShowTickOption.convert
            TickSuffix |> DynObj.setValueOpt angularAxis "ticksuffix"
            ShowExponent |> DynObj.setValueOptBy angularAxis "showexponent" StyleParam.ShowExponent.convert
            ExponentFormat |> DynObj.setValueOptBy angularAxis "exponentformat" StyleParam.ExponentFormat.convert
            MinExponent |> DynObj.setValueOpt angularAxis "minexponent"
            SeparateThousands |> DynObj.setValueOpt angularAxis "separatethousands"
            TickFont |> DynObj.setValueOpt angularAxis "tickfont"
            TickAngle |> DynObj.setValueOpt angularAxis "tickangle"
            TickFormat |> DynObj.setValueOpt angularAxis "tickformat"
            TickFormatStops |> DynObj.setValueOpt angularAxis "tickformatstops"
            TickLabelStep |> DynObj.setValueOpt angularAxis "ticklabelstep"
            Layer |> DynObj.setValueOptBy angularAxis "layer" StyleParam.Layer.convert

            angularAxis

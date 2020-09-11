(*** hide ***)
#r "netstandard"
#r "../../bin/Plotly.NET/netstandard2.0/Plotly.NET.dll"


(** 
# Plotly.NET: Polar chart

*Summary:* This example shows how to create polar charts in F#.

A polar chart is a graphical method of displaying multivariate data in the form of a two-dimensional chart 
of three or more quantitative variables represented on axes starting from the same point.
The relative position and angle of the axes is typically uninformative.
*)

open Plotly.NET 
  
let r   = [1; 2; 3; 4; 5; 6; 7;]
let r'  = [ 5; 6; 7; 1; 2; 3; 4;]
let r'' = [ 3; 1; 5; 2; 8; 7; 5;]


let t  = [0; 45; 90; 135; 200; 320; 184;]
  
let polar1 =
        [
            Chart.Polar(r,t,StyleParam.Mode.Markers,Name="1")
            Chart.Polar(r',t,StyleParam.Mode.Markers,Name="2")
            Chart.Polar(r'',t,StyleParam.Mode.Markers,Name="3")
        ]
        |> Chart.Combine

(***do-not-eval***)
polar1 |> Chart.Show

(*** include-value:polar1 ***)


namespace Fable.BizCharts

open Fable.React
open Fable.Core.JsInterop

type BizInterval() =
    inherit BizElement<BizInterval>(ofImport "Interval" "bizcharts")
    member x.position (v: string) = x.attribute "position" v
    member x.color (v: string) = x.attribute "color" v
    member x.label (v: string) = x.attribute "label" v
    member x.adjust (v: string) = x.attribute "adjust" v
    member x.shape (v: string) = x.attribute "shape" v
    member x.size (v: obj) = x.attribute "size" v
    member x.tooltip (v: bool) = x.attribute "tooltip" v
    member x.style (v: obj) = x.attribute "style" v
    member x.animate (v: bool) = x.attribute "animate" v
namespace Fable.BizCharts

open Fable.Core
open Fable.React

type BizGraphic<'T when 'T :> BizElement<'T>>(partialImport) =
    inherit BizElement<'T>(partialImport)
    member x.position (v: string) = x.attribute "position" v
    member x.color (v: string) = x.attribute "color" v
    member x.label (v: string) = x.attribute "label" v
    member x.adjust (v: string) = x.attribute "adjust" v
    member x.size (v: obj) = x.attribute "size" v
    member x.tooltip (v: bool) = x.attribute "tooltip" v
    member x.style (v: obj) = x.attribute "style" v
    member x.animate (v: bool) = x.attribute "animate" v

[<StringEnum; RequireQualifiedAccess>]
type LineShape =
    | Line | Smooth | Dot | Dash | Hv | Vh | Hvh | Vhv

type BizLine() =
    inherit BizGraphic<BizLine>(ofImport "default" "bizcharts/lib/components/Line")
    member x.shape (v: LineShape) = x.attribute "shape" v

[<StringEnum; RequireQualifiedAccess>]
type IntervalShape =
    | Rect | HollowRect | Line | Tick | Stroke | Funnel | Pyramid

type BizInterval() =
    inherit BizGraphic<BizInterval>(ofImport "default" "bizcharts/lib/components/Interval")
    member x.shape (v: IntervalShape) = x.attribute "shape" v

[<StringEnum; RequireQualifiedAccess>]
type PointShape =
    | Circle
    | Square
    | Bowtie
    | Diamond
    | Hexagon
    | Triangle
    | [<CompiledName("triangle-down")>] TriangleDown
    | Tick
    | Plus
    | Hyphen
    | Line
    | Cross
    | [<CompiledName("hollow-circle")>] HollowCircle
    | [<CompiledName("hollow-square")>] HollowSquare
    | [<CompiledName("hollow-bowtie")>] HollowBowtie
    | [<CompiledName("hollow-diamond")>] HollowDiamond
    | [<CompiledName("hollow-hexagon")>] HollowHexagon
    | [<CompiledName("hollow-triangle")>] HollowTriangle
    | [<CompiledName("hollow-triangle-down")>] HollowTriangleDown

type BizPoint() =
    inherit BizGraphic<BizPoint>(ofImport "default" "bizcharts/lib/geometry/Point")
    member x.shape (v: PointShape) = x.attribute "shape" v

[<StringEnum; RequireQualifiedAccess>]
type AreaShape =
    | Circle    
    | Area
    | Smooth
    | Line
    | DotLine
    | SmoothLine
    | DotSmoothLine'

type BizArea() =
    inherit BizGraphic<BizArea>(ofImport "default" "bizcharts/lib/geometry/Area")
    member x.shape (v: AreaShape) = x.attribute "shape" v
    
type BizPolygon() =
    inherit BizGraphic<BizPolygon>(ofImport "default" "bizcharts/lib/geometry/Polygon")

[<StringEnum; RequireQualifiedAccess>]
type SchemaShape =
    | Box    
    | Candle
    
type BizSchema() =
    inherit BizGraphic<BizSchema>(ofImport "default" "bizcharts/lib/geometry/Schema")
    member x.shape (v: SchemaShape) = x.attribute "shape" v
    
[<StringEnum; RequireQualifiedAccess>]
type PathShape =
    | Line    
    | Smooth
    | Dot
    | Dash
    | Hv | Vh | Hvh | Vhv
    
type BizPath() =
    inherit BizGraphic<BizPath>(ofImport "default" "bizcharts/lib/geometry/Path")
    member x.shape (v: PathShape) = x.attribute "shape" v
    
type BizHeatmap() =
    inherit BizGraphic<BizHeatmap>(ofImport "default" "bizcharts/lib/geometry/Heatmap")

[<StringEnum; RequireQualifiedAccess>]
type EdgeShape =
    | Line
    | Vhv
    | Smooth
    | Arc
    
type BizEdge() =
    inherit BizGraphic<BizEdge>(ofImport "default" "bizcharts/lib/geometry/Edge")
    member x.shape (v: EdgeShape) = x.attribute "shape" v
    
// TODO label
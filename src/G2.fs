namespace Fable.BizCharts

open Browser.Types
open Fable.React

type BizCanvas() =
    inherit BizElement<BizCanvas>(ofImport "Canvas" "bizcharts/lib/g-components/Canvas")
    member x.renderer (v: string) = x.attribute "renderer" v
    member x.width (v: int) = x.attribute "width" v
    member x.height (v: int) = x.attribute "height" v
    member x.container (v: HTMLElement) = x.attribute "container" v
    member x.cursor (v: string) = x.attribute "cursor" v
    
type BizGroup() =
    inherit BizElement<BizGroup>(ofImport "Group" "bizcharts/lib/g-components/Group")
    member x.translate (v: float array) = x.attribute "translate" v
    
type CircleAttrs =
    {
        x: float option
        y: float option
        r: float option        
    }
    
type BizCircle() =
    inherit BizElement<BizCircle>(ofImport "Circle" "bizcharts/lib/g-components/Circle")
    member x.attrs (v: CircleAttrs) = x.attribute "attrs" v

type EllipseAttrs =
    {
        x: float option
        y: float option
        rx: float option
        ry: float option
    }
  
type BizEllipse() =
    inherit BizElement<BizEllipse>(ofImport "Ellipse" "bizcharts/lib/g-components/Ellipse")
    member x.attrs (v: EllipseAttrs) = x.attribute "attrs" v
    
type ImageAttrs =
    {
        x: float option
        y: float option
        width: float option
        height: float option
    }
  
type BizImage() =
    inherit BizElement<BizImage>(ofImport "Image" "bizcharts/lib/g-components/Image")
    member x.attrs (v: ImageAttrs) = x.attribute "attrs" v
    
type LineAttrs =
    {
        x1: float option
        y1: float option
        x2: float option
        y2: float option
    }
  
type BizLine() =
    inherit BizElement<BizLine>(ofImport "Line" "bizcharts/lib/g-components/Line")
    member x.attrs (v: LineAttrs) = x.attribute "attrs" v
    
type MarkerAttrs =
    {
        x: float option
        y: float option
        r: float option
        symbol: float option
    }
  
type BizMarker() =
    inherit BizElement<BizMarker>(ofImport "Marker" "bizcharts/lib/g-components/Marker")
    member x.attrs (v: MarkerAttrs) = x.attribute "attrs" v
    
type PathAttrs =
    {
        path: string
    }
  
type BizPath() =
    inherit BizElement<BizPath>(ofImport "Path" "bizcharts/lib/g-components/Path")
    member x.attrs (v: PathAttrs) = x.attribute "attrs" v
    
type PolygonAttrs =
    {
        points: float array array
    }
  
type BizPolygon() =
    inherit BizElement<BizPolygon>(ofImport "Polygon" "bizcharts/lib/g-components/Polygon")
    member x.attrs (v: PolygonAttrs) = x.attribute "attrs" v
    
type PolylineAttrs =
    {
        points: float array array
    }
  
type BizPolyline() =
    inherit BizElement<BizPolyline>(ofImport "Polyline" "bizcharts/lib/g-components/Polyline")
    member x.attrs (v: PolylineAttrs) = x.attribute "attrs" v
    
type RectAttrs =
    {
        x: float option
        y: float option
        width: float option
        height: float option
        radius: float option
    }
  
type BizRect() =
    inherit BizElement<BizRect>(ofImport "Rect" "bizcharts/lib/g-components/Rect")
    member x.attrs (v: RectAttrs) = x.attribute "attrs" v
    
type TextAttrs =
    {
        x: float option
        y: float option
        text: string
    }
  
type BizText() =
    inherit BizElement<BizText>(ofImport "Text" "bizcharts/lib/g-components/Text")
    member x.attrs (v: TextAttrs) = x.attribute "attrs" v
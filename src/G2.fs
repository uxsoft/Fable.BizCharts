namespace Fable.BizCharts

open Browser.Types
open Fable.React
open Fable.BizCharts

type BizCanvas() =
    inherit BizElement<BizCanvas>(ofImport "GComponents.Canvas" "bizcharts")
    member x.renderer (v: string) = x.attribute "renderer" v
    member x.width (v: int) = x.attribute "width" v
    member x.height (v: int) = x.attribute "height" v
    member x.container (v: HTMLElement) = x.attribute "container" v
    member x.cursor (v: string) = x.attribute "cursor" v
    
type BizGGroup() =
    inherit BizElement<BizGGroup>(ofImport "GComponents.Group" "bizcharts")
    member x.translate (v: float array) = x.attribute "translate" v
    
type CircleAttrs =
    {
        x: float option
        y: float option
        r: float option        
    }
    
type BizGCircle() =
    inherit BizElement<BizGCircle>(ofImport "GComponents.Circle" "bizcharts")
    member x.attrs (v: CircleAttrs) = x.attribute "attrs" v

type EllipseAttrs =
    {
        x: float option
        y: float option
        rx: float option
        ry: float option
    }
  
type BizGEllipse() =
    inherit BizElement<BizGEllipse>(ofImport "GComponents.Ellipse" "bizcharts")
    member x.attrs (v: EllipseAttrs) = x.attribute "attrs" v
    
type ImageAttrs =
    {
        x: float option
        y: float option
        width: float option
        height: float option
    }
  
type BizGImage() =
    inherit BizElement<BizGImage>(ofImport "GComponents.Image" "bizcharts")
    member x.attrs (v: ImageAttrs) = x.attribute "attrs" v
    
type LineAttrs =
    {
        x1: float option
        y1: float option
        x2: float option
        y2: float option
    }
  
type BizGLine() =
    inherit BizElement<BizGLine>(ofImport "GComponents.Line" "bizcharts")
    member x.attrs (v: LineAttrs) = x.attribute "attrs" v
    
type MarkerAttrs =
    {
        x: float option
        y: float option
        r: float option
        symbol: float option
    }
  
type BizGMarker() =
    inherit BizElement<BizGMarker>(ofImport "GComponents.Marker" "bizcharts")
    member x.attrs (v: MarkerAttrs) = x.attribute "attrs" v
    
type PathAttrs =
    {
        path: string
    }
  
type BizGPath() =
    inherit BizElement<BizGPath>(ofImport "GComponents.Path" "bizcharts")
    member x.attrs (v: PathAttrs) = x.attribute "attrs" v
    
type PolygonAttrs =
    {
        points: float array array
    }
  
type BizGPolygon() =
    inherit BizElement<BizGPolygon>(ofImport "GComponents.Polygon" "bizcharts")
    member x.attrs (v: PolygonAttrs) = x.attribute "attrs" v
    
type PolylineAttrs =
    {
        points: float array array
    }
  
type BizGPolyline() =
    inherit BizElement<BizGPolyline>(ofImport "GComponents.Polyline" "bizcharts")
    member x.attrs (v: PolylineAttrs) = x.attribute "attrs" v
    
type RectAttrs =
    {
        x: float option
        y: float option
        width: float option
        height: float option
        radius: float option
    }
  
type BizGRect() =
    inherit BizElement<BizGRect>(ofImport "GComponents.Rect" "bizcharts")
    member x.attrs (v: RectAttrs) = x.attribute "attrs" v
    
type TextAttrs =
    {
        x: float option
        y: float option
        text: string
    }
  
type BizGText() =
    inherit BizElement<BizGText>(ofImport "GComponents.Text" "bizcharts")
    member x.attrs (v: TextAttrs) = x.attribute "attrs" v
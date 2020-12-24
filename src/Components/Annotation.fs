[<AutoOpen>]
module Fable.BizCharts.Components.Annotation

open Fable.Core
open Fable.React
open Fable.BizCharts

type BizAnnotationBase<'T when 'T :> BizElement<'T>>(partialImport) =
    inherit BizElement<'T>(partialImport)
    member x.top (?v: bool) = x.attribute "top" (Option.defaultValue true v)
    member x.style (v: 'A) = x.attribute "style" v
    member x.animate (?v: bool) = x.attribute "animate" (Option.defaultValue true v)
    member x.offsetX (v: int) = x.attribute "offsetX" v
    member x.offsetY (v: int) = x.attribute "offsetY" v
    member this.start (x: 'A, y: 'B) = this.attribute "start" [| x :> obj; y :> obj |]
    member this.``end`` (x: 'A, y: 'B) = this.attribute "end" [| x :> obj; y :> obj |]

type BizAnnotationTextConfig() =
    inherit BizObject<BizAnnotationTextConfig>()
    member x.position (v: string) = x.attribute "position" v
    member x.autoRotate (v: bool) = x.attribute "autoRotate" v
    member x.content (v: string) = x.attribute "content" v
    member x.style (v: 'T) = x.attribute "style" v
    member x.offsetX (v: int) = x.attribute "offsetX" v
    member x.offsetY (v: int) = x.attribute "offsetY" v

type BizAnnotationLine() =
    inherit BizAnnotationBase<BizAnnotationLine>(ofImport "Line" "bizcharts/lib/components/Annotation")
    member x.text (v: BizAnnotationTextConfig) = x.attribute "text" v
    
type BizAnnotationText() =
    inherit BizAnnotationBase<BizAnnotationText>(ofImport "Text" "bizcharts/lib/components/Annotation")
    member this.position (x: 'A, y: 'B) = this.attribute "position" [| x :> obj; y :> obj |]
    member x.content (v: string) = x.attribute "content" v
    member x.rotate (v: float) = x.attribute "rotate" v
    
type BizAnnotationImage() =
    inherit BizAnnotationBase<BizAnnotationImage>(ofImport "Image" "bizcharts/lib/components/Annotation")
    member x.src (v: string) = x.attribute "src" v
    
type BizAnnotationRegionFilter() =
    inherit BizAnnotationBase<BizAnnotationRegionFilter>(ofImport "RegionFilter" "bizcharts/lib/components/Annotation")
    member x.color (v: string) = x.attribute "color" v
    member x.area (v: string array) = x.attribute "color" v
    
[<StringEnum; RequireQualifiedAccess>] type DataMarkerDirection = Downward | Upward

type BizAnnotationDataMarker() =
    inherit BizAnnotationBase<BizAnnotationDataMarker>(ofImport "DataMarker" "bizcharts/lib/components/Annotation")
    member this.position (x: 'A, y: 'B) = this.attribute "position" [| x :> obj; y :> obj |]
    member x.point (v: {| style: 'T |}) = x.attribute "point" v 
    member x.line (v: 'T) = x.attribute "line" v
    member x.text (v: BizAnnotationTextConfig) = x.attribute "text" v    
    member x.src (v: string) = x.attribute "src" v
    member x.autoAdjust (?v: bool) = x.attribute "autoAdjust" (Option.defaultValue true v)
    member x.direction (v: DataMarkerDirection) = x.attribute "direction" v 
    
type BizAnnotationDataRegion() =
    inherit BizAnnotationBase<BizAnnotationDataRegion>(ofImport "DataRegion" "bizcharts/lib/components/Annotation")
    member x.region (v: {| style: 'T |}) = x.attribute "region" v 
    member x.lineLength (v: int) = x.attribute "lineLength" v
    member x.text (v: BizAnnotationTextConfig) = x.attribute "text" v
    
type BizAnnotationRegion() =
    inherit BizAnnotationBase<BizAnnotationRegion>(ofImport "Region" "bizcharts/lib/components/Annotation")
    
type BizAnnotationArc() =
    inherit BizAnnotationBase<BizAnnotationArc>(ofImport "Arc" "bizcharts/lib/components/Annotation")

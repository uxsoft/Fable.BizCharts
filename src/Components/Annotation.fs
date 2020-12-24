[<AutoOpen>]
module Fable.BizCharts.Components.Annotation

open Fable.Core
open Fable.React
open Fable.BizCharts

type BizAnnotationBase(partialImport) =
    inherit BizElement<BizAnnotationBase>(partialImport)
    member x.top (?v: bool) = x.attribute "top" (Option.defaultValue true v)
    member x.style (v: 'T) = x.attribute "style" v
    member x.animate (?v: bool) = x.attribute "animate" (Option.defaultValue true v)
    member x.offsetX (v: int) = x.attribute "offsetX" v
    member x.offsetY (v: int) = x.attribute "offsetY" v
    member this.start (x: string, y: string) = this.attribute "start" [| x; y |]
    member this.``end`` (x: string, y: string) = this.attribute "end" [| x; y |]

type BizAnnotationTextConfig() =
    inherit BizObject<BizAnnotationTextConfig>()
    member x.position (v: string) = x.attribute "position" v
    member x.autoRotate (v: bool) = x.attribute "autoRotate" v
    member x.content (v: string) = x.attribute "content" v
    member x.style (v: 'T) = x.attribute "style" v
    member x.offsetX (v: int) = x.attribute "offsetX" v
    member x.offsetY (v: int) = x.attribute "offsetY" v

type BizAnnotationLine() =
    inherit BizAnnotationBase(ofImport "Line" "bizcharts/lib/components/Annotation")
    member x.text (v: BizAnnotationTextConfig) = x.attribute "text" v
    
type BizAnnotationText() =
    inherit BizAnnotationBase(ofImport "Text" "bizcharts/lib/components/Annotation")
    member this.position (x: string, y: string) = this.attribute "position" [| x; y |]
    member x.content (v: string) = x.attribute "content" v
    member x.rotate (v: float) = x.attribute "rotate" v
    
type BizAnnotationImage() =
    inherit BizAnnotationBase(ofImport "Image" "bizcharts/lib/components/Annotation")
    member x.src (v: string) = x.attribute "src" v
    
type BizAnnotationRegionFilter() =
    inherit BizAnnotationBase(ofImport "RegionFilter" "bizcharts/lib/components/Annotation")
    member x.color (v: string) = x.attribute "color" v
    member x.area (v: string array) = x.attribute "color" v
    
[<StringEnum; RequireQualifiedAccess>] type DataMarkerDirection = Downward | Upward

type BizAnnotationDataMarker() =
    inherit BizAnnotationBase(ofImport "DataMarker" "bizcharts/lib/components/Annotation")
    member this.position (x: string, y: string) = this.attribute "position" [| x; y |]
    member x.point (v: {| style: 'T |}) = x.attribute "point" v 
    member x.line (v: 'T) = x.attribute "line" v
    member x.text (v: BizAnnotationTextConfig) = x.attribute "text" v    
    member x.src (v: string) = x.attribute "src" v
    member x.autoAdjust (?v: bool) = x.attribute "autoAdjust" (Option.defaultValue true v)
    member x.direction (v: DataMarkerDirection) = x.attribute "direction" v 
    
type BizAnnotationDataRegion() =
    inherit BizAnnotationBase(ofImport "DataRegion" "bizcharts/lib/components/Annotation")
    member x.region (v: {| style: 'T |}) = x.attribute "region" v 
    member x.lineLength (v: int) = x.attribute "lineLength" v
    member x.text (v: BizAnnotationTextConfig) = x.attribute "text" v
    
type BizAnnotationRegion() =
    inherit BizAnnotationBase(ofImport "Region" "bizcharts/lib/components/Annotation")
    
type BizAnnotationArc() =
    inherit BizAnnotationBase(ofImport "Arc" "bizcharts/lib/components/Annotation")

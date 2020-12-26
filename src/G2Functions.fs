module Fable.BizCharts.G2Functions

open Fable.Core.JsInterop

type ShapePoint =
    {
        x: int array
        y: int array
        y0: int
        size: int
    }

type Point =
    {
        x: int
        y: int
    }

type ShapeMarkerCfg =
    {
        color: string
        isInPolar: bool
    }
    
type ShapeMarkerAttrs =
    {
        symbol: string
        style: obj
    }
    
type ShapeInfo =
    {
        x: int array
        y: int array
        shape: string array
        size: int
        color: string
        style: obj
        isInCircle: bool
        data: obj
        mappingData: obj
        points: Point array
        nextPoints: Point array
        text: string
        isStack: bool
        connectNulls: bool
        showSinglePoint: bool
        defaultStyle: obj
        customInfo: obj
    }

type RegisterShapeCfg = 
    {
        getPoints: (ShapePoint -> Point array) option
        getMarker: (ShapeMarkerCfg -> ShapeMarkerAttrs) option
        draw: (ShapeInfo -> obj) -> obj
    }

let registerShape (factoryName: string) (shapeType: string) (cfg: RegisterShapeCfg) =
    importMember "bizcharts"
namespace Fable.BizCharts

open Fable.React
open Fable.Core.JsInterop

type BizObject<'T when 'T :> BizObject<'T>>() =
    let mutable props = []

    member x.JSON = createObj props
    member internal x.attribute name value =
        props <- props @ [name ==> value]
        x :?> 'T

type BizElement<'T when 'T :> BizElement<'T>> (partialImport: obj -> ReactElement seq -> ReactElement) =
    inherit BizObject<'T>()

    member x.Item
        with get(children: ReactElement list) = partialImport x.JSON children

    member x.children (children: ReactElement list) =
        partialImport x.JSON children

    member x.build () =
        partialImport x.JSON []

    // Common Attributes
    member x.set (v: string * obj) = match v with (name, value) -> x.attribute name value
    member x.key (v: string) = x.attribute "key" v
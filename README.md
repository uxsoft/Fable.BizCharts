# Fable.BizCharts

```fsharp
let data = [|
    {|
        item = "Item 1"
        count = 40
        percent = 0.4
    |} :> obj
    {|
        item = "Item 2"
        count = 21
        percent = 0.21
    |} :> obj
    {|
        item = "Item 3"
        count = 17
        percent = 0.17
    |} :> obj
|]

let cols =
    {|
        percent =
            {|
                formatter = fun v -> v+"%"
            |}
    |}

let render (app: App) =
    BizChart(data)
        .height(400)
        .scale(cols)
        .autoFit(true)
        .[[
            BizCoordinate()
                .coordinateType(CoordinateType.Theta)
                .radius(0.75)
                .[[]]
            BizTooltip()
                .showTitle(false)
                .[[]]
            BizAxis()
                .visible(false)
                .[[]]
            BizInterval()
                .position("percent")
                .adjust("stack")
                .color("item")
                .[[]]
            BizInteraction()
                .interactionType(InteractionType.ElementSingleSelected)
                .[[]]
        ]]
```
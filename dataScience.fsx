#r "nuget: FSharp.Stats"
#r "nuget: Plotly.NET"

open FSharp.Stats
open FSharp.Stats.Signal
open Plotly.NET

// gerar uma amostra aleatória com 300 observaççoes

let normalDistribution = Distributions.Continuous.Normal.Init 25. 0.1
let sample = Array.init 300 (fun _ -> normalDistribution.Sample())

// criar e personalizar o gráfico com plotly
let histogramChart =
    Chart.Histogram(sample)
    |> Chart.withTitle "Distribuição Amostral N(25, 0.1)"
    |> Chart.withXAxisStyle "Intervalo (Bins)"
    |> Chart.withYAxisStyle "Frequência Absoluta"

// renderizar o gráfico no navegador padrão
histogramChart |> Chart.show
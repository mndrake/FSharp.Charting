#I "bin/Debug"
#r "OxyPlot"
#r "OxyPlot.GtkSharp"
#r "FSharp.Charting.Gtk"

open FSharp.Charting

let ch = Chart.Line [ for i in 0. .. 10. -> i, i*i ]

let ms = ch.ToPng()
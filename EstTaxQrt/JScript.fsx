(*
// look for this !
#r "/home/evxyz/FS/Dojo-Type-Provider-Treasure-Hunt/Dojo/bin/Debug/FSharp.Data.dll"

// #load "../../../packages/FSharp.Charting/FSharp.Charting.fsx"
open FSharp.Data
open FSharp.Charting

let data = WorldBankData.GetDataContext()
data
  .Countries.``United Kingdom``
  .Indicators.``School enrollment, tertiary (% gross)``
|> Seq.maxBy fst
*)

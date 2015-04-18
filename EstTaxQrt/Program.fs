module Program
open System
// constants
let nycOglig        = 0.03534
let albanyOblig     = 0.059
let fedObligat      = 0.3 
// datafiles
open Data1stQrt
let f1 = Data1stQrt.feb2015
let j1 = Data1stQrt.jan2015
let m1 = Data1stQrt.mar2015
// collecting expenses
let sumM1 = (List.sumBy snd m1)
let sumF1 = (List.sumBy snd f1)  
let sumJ1 = (List.sumBy snd j1) 
let firstQrtExpSum = (List.sum[sumF1;sumJ1;sumM1])
// earnings  
let earnJan = 0 
let earnFeb = 0   
let earnMar = 0 
let earn1Qt = (List.sum [earnJan;earnFeb;earnMar]) 

// 
let taxFed = earned4Qt * fedObligat
let taxAlbany = ( earned4Qt*albanyOblig)
let taxNYC = ( earned4Qt*nycOglig)
let taxTotalObligado = sum[taxFed, taxAlbany, taxNYC]   
// output
printfn "%A"  firstQrtExpSum 

[<EntryPoint>] 
let main argv = 
     printfn "%A" argv
     0 // return an integer exit code



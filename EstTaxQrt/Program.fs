module EstTax
open System

// load datafiles
open Data1stQrt

// assiging data to functions
let f1 = Data1stQrt.feb2015
let j1 = Data1stQrt.jan2015
let m1 = Data1stQrt.mar2015
// constant tax rates
let nycOglig        = 0.03534
let albanyOblig     = 0.059
let fedObligat      = 0.3 

// collecting expenses
let sumM1 = (List.sumBy snd m1)
let sumF1 = (List.sumBy snd f1)  
let sumJ1 = (List.sumBy snd j1) 
let firstQrtExpSum = (List.sum[sumF1;sumJ1;sumM1])

// earnings  
let earnJan = 0.0 
let earnFeb = 3300.0   
let earnMar = 0.0 
let earn1Qt = (List.sum [earnJan;earnFeb;earnMar]) 

// exp against earn 
let taxableEarn = earn1Qt - firstQrtExpSum

// applying tax rates
let taxFed = taxableEarn * fedObligat
let taxAlbany = ( taxableEarn*albanyOblig)
let taxNYC = ( taxableEarn*nycOglig)
let taxTotalObligado = (List.sum [taxFed; taxAlbany; taxNYC])   

// output
printfn "taxable Fed $ %A \n "  taxFed
printfn "taxable NYS $ %A \n "  taxAlbany
printfn "taxable nyc $ %A \n "  taxNYC
printfn "taxable Total Obligation $ %A \n "  taxTotalObligado

//////////////////////////////////////////////////////////////
[<EntryPoint>] 
let main argv = 
     printfn "%A" argv
     0 // return an integer exit code

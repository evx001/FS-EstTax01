module Program
open System

// datafiles
open Data1stQrt
// unpacked  
let f1 = Data1stQrt.feb2015
let j1 = Data1stQrt.jan2015
let m1 = Data1stQrt.mar2015
let sumM1 = (List.sumBy snd m1)
let sumF1 = (List.sumBy snd f1)  
let sumJ1 = (List.sumBy snd j1) 
let firstQrtExpSum = (List.sum[sumF1;sumJ1;sumM1])  
printfn "%A"  firstQrtExpSum 

[<EntryPoint>] 
let main argv = 
     printfn "%A" argv
     0 // return an integer exit code



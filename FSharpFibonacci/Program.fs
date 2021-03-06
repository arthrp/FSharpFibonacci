﻿open System

let rec fibonnacci n =
    match n with
    | 0 -> 0
    | 1 -> 1
    | _ -> fibonnacci (n - 1) + fibonnacci (n - 2)

[<EntryPoint>]
let main argv =
    let num = int argv.[0]
    let x = fibonnacci num
    printfn "Result: %d" x
    0 // return an integer exit code

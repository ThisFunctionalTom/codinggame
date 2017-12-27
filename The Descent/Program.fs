// Learn more about F# at http://fsharp.org

open System

let rec loop () =
    List.init 8 (fun i -> i, Console.ReadLine() |> Int32.Parse)
    |> List.maxBy snd
    |> fst
    |> printfn "%d"

[<EntryPoint>]
let main argv =
    loop()
    0 // return an integer exit code

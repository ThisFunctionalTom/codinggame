(* --- *)
(* Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders. *)
open System

(* lightX: the X position of the light of power *)
(* lightY: the Y position of the light of power *)
(* initialTX: Thor's starting X position *)
(* initialTY: Thor's starting Y position *)
let [|lightX; lightY; initialTX; initialTY|] =
    let split sep (str: string) = 
        str.Split([|sep|])
    
    Console.In.ReadLine()
    |> split ' '
    |> Array.map int

let rec loop (tx, ty) (lx, ly) =
    let _remainingTurns = Console.In.ReadLine() |> int

    let vert, ty' =
        if ty < ly then "S", ty+1
        elif ty > ly then "N", ty-1 
        else "", ty
    let horiz, tx' =
        if tx < lx then "E", tx+1
        elif tx > lx then "W", tx-1
        else "", tx
    let move = vert + horiz

    printfn "%s" move
    loop (tx', ty') (lx, ly)

loop (initialTX, initialTY) (lightX, lightY)
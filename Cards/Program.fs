//usando funções para trabalhar com listas e coleções

let hand = [0; 25; 31]
let cardValue card =
    let value = card % 13
    if value = 0 then 11
    elif value = 10 || value = 11 || value = 12 then 10
    else value

let sum = List.sumBy(fun card -> cardValue card) hand
printfn "%i" sum

(* let cards = [ 0 .. 5 ]
let hand = []

let drawCard (tuple: int list * int list) =
    let deck = fst tuple
    let draw = snd tuple
    let firstCard = deck.Head
    printfn "%i" firstCard
  
    let hand =
        draw
        |> List.append [firstCard]

    (deck.Tail, hand)

let d, h = (cards, hand) |> drawCard |> drawCard

printfn "Deck: %A Hand: %A" d h *)


printfn "Hello Wold!"

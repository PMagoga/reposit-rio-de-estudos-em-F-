

(* open System

let suit (no:int) : string = 
    let suitNo:int = no / 13
    if suitNo = 0 then "Hearts"
    elif suitNo = 1 then "Spades"
    elif suitNo = 2 then "Diamonds"
    else "Clubs" 

let cardDescription (card: int) : string =
    let cardNo: int = card % 13
    if cardNo = 1 then "Ace"
    elif cardNo = 11 then "Jack"
    elif cardNo = 12 then "Queen"
    elif cardNo = 0 then "King"
    else string cardNo

[<EntryPoint>]
let main argv =

    let cards = [ 1; 10; 2; 34 ]

    for card in cards do
      printfn "%s of %s" (cardDescription(card)) (suit(card))
    0 // return an integer exit code *)

(* let cardFace (card:int) : string =
    let no = card % 13
    if no = 14 || no = 1 then "Ace"
    elif  no = 0 then "King"
    elif no = 12 then "Queen"
    elif no = 11 then "Jack"
    else string no

printfn "%s" (cardFace 11) *)


//operadores de composição e pipe
(* let cards = [21; 3; 1; 7; 9; 23]
let cardFace card = 
    let no = card % 13
    if no = 1 then "Ace"
    elif no = 0 then "King"
    elif no = 12 then "Queen"
    elif no = 11 then "Jack"
    else string no

let suit card =
    let no = card / 13
    if no = 0 then "Hearts"
    elif no = 1 then "Spades"
    elif no = 2 then "Diamonds"
    else "Clubs"

let shuffle list =
    let random = System.Random()
    list |> List.sortBy (fun x -> random.Next())

let printCard card = printfn "%s of %s" (cardFace card) (suit card)

let printAll list = List.iter(fun x -> printCard(x)) list

let take (no:int) (list) = List.take no list

cards |> shuffle |> take 3 |> printAll *)


let cylinderVolume radius lenght =
    let pi = 3.14159
    lenght * pi * radius * radius
    |> printfn "O resultado é %f" 

cylinderVolume 2.5 4.8


let apply (transform: int -> int) y = transform y

let result = apply (fun x -> x + 1) 100

// Square the odd values of the input and add one, using F# pipe operators.
let squareAndAddOdd values =
    values
    |> List.map (fun x-> x * x + 1)
    |> List.filter (fun x -> x % 2 <> 0) 

let numbers = [1..5]
let result1 = squareAndAddOdd numbers

// composição de funções
let function1 x = x + 1
let function2 x = x * 2
let h = function1 >> function2
let result3 = h 100


type Chicken =
    {
        Name : string
        Size : float
    }

let c1 = { Name = "Galo"; Size = 10.0}

let fullNotation = ["a"; "ab"; "abc"] |> List.find ( fun texto -> texto.EndsWith("c"))

printfn "%A" fullNotation

let shorthandNotation = ["a"; "b"; "abc" ] |> List.find ( _.EndsWith("c"))

let test x y =
    if x = y then "equals"
    elif x < y then "is less than"
    else "is greater than"


printfn "%d %s %d" 10 (test 10 20) 20

printfn "Qual seu nome?"
let nameString = System.Console.ReadLine()

printfn "Qual sua idade?"
let ageString = 
    System.Console.ReadLine()
    |> System.Int32.Parse

if ageString < 10 then
    printfn "Que legal você tem %d anos e já coda em F#" ageString


//structs
[<Struct>]
type Chicken1 =
    {
        Name : string
        Size : float
    }
let c10 = {Name = "John"; Size = 10.0}



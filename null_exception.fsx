// trabalhando com options

open System

(* let tryParseDateTime (input:string)=
    let (success, value) = DateTime.TryParse input
    if success then Some value else None *)

// o mesmo código acima usando pattern matching
(* Em F#, métodos que retornam valores de saída (out parameters em C#) são traduzidos automaticamente para uma tupla no formato (bool, resultado)  por isso no match with, precisamos de um valor booleano e um resultado*)
let tryParseDateTime (input: string) =
    match DateTime.TryParse input with
    | true, result -> Some result
    | false, _ -> None // _ é o wildcard

// O método do .NET DateTime.TryParse
let isDate = tryParseDateTime "2019-08-01"

let isNoDate = tryParseDateTime "Hello"

// outra forma de usar o tipo Option
type PersonName = {
    FirstName : string
    Middlename : Option<string> // nesse caso, pode ser a pessoa não tenha nome do meio
    LastName : string
}

let person = { FirstName = "Ian"; Middlename = None; LastName = "Russel"}

// aqui utilizamos o copy and update, criando uma nova instância de uma record que já existe, alterando alguns campos
let person2 = { person with Middlename = Some "????"}

// acima nós usamos o estilo Option<'T>, mas nós podemos usar a keyword option
type PersonName1 = {
    FirstName : string
    Middlename : string option
    LastName : string
}
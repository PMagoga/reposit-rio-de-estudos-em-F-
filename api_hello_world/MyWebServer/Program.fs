open System.Runtime.Serialization
open Suave
open Suave.Operators
open Suave.Writers
open Suave.Json

[<DataContract>]
type Person =
    { [<field: DataMember(Name = "name")>] name : string
      [<field: DataMember(Name = "age")>] age: int}

let person = { name = "Alice"; age = 30 }

// para json
let app =
    toJson person
    |> Successful.ok
    >=> setMimeType "application/json"

startWebServer defaultConfig app

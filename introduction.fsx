type RegisteredCustomer = {
    Id : string
}

type UnregisteredCustomer = {
    Id : string
}

type Customer =
    | Eligible of RegisteredCustomer
    | Registered of RegisteredCustomer
    | Guest of UnregisteredCustomer

let calculateTotal customer spend =
    let discount =
        match customer with
        | Eligible _ when spend >= 100.0M -> spend * 0.1M
        | _ -> 0.0M
    spend - discount

let john = Eligible {Id = "John"}
let mary = Eligible {Id = "Mary"}

let assertJohn = calculateTotal john 100.0M
let assertMary = calculateTotal mary 99.0M
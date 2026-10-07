type Customer = {
    Id : string
    IsEligible : bool
    IsRegistered : bool
}

let calculateTotal customer spend =
    let discount =
        if customer.IsEligible && spend >= 100.0M then spend * 0.1M
        else 0.0M
    spend - discount

let john = { Id = "John"; IsEligible = true; IsRegistered = true}
let mary = {Id = "Mary"; IsEligible = true; IsRegistered = true}
let richard = { Id = "Richard"; IsEligible = false; IsRegistered = true}
let sarah = { Id = "Sarah"; IsEligible = false; IsRegistered = false}

let assertJohn = (calculateTotal john 100.0M)
let assertMary = (calculateTotal mary 99.0M)
let assertRichard = (calculateTotal richard 100.0M)
let assertSarah = calculateTotal sarah 100.0M

let partial = calculateTotal john
let complete = partial 100.0M
namespace Register.FSharp

type Product = {
    Name: string
    Price: decimal
}

type AddItemModel = {
    Name: string
    Price: decimal
    Quantity: int
}

module AddItemController =
    let addItem name price quantity = 
        let item = {Name = name; Price = price}
        item
namespace Register.FSharp

type Product = {
    name: string
    price: double
}

type MainModel = {
    ShoppingCart: (Product * int) list
    Subtotal: decimal
    Tax: decimal
    Total: decimal
}

module MainController = 
    let initModel = {ShoppingCart = []; Subtotal = 0m; Tax = 0m; Total = 0m}

namespace Register.FSharp
open FSharpCashRegister
open System.Windows.Forms
open System.Drawing
open TrivialBehind
open System.Runtime.InteropServices

type Product = {
    Name: string
    Price: decimal
    Quantity: int}

type MainModel = {
    ShoppingCart: Product list
    Subtotal: decimal
    Tax: decimal
    Total: decimal
}
with
    static member Default = {
    ShoppingCart = []
    Subtotal = 0m
    Tax = 0m
    Total = 0m
    }

type CRMainController(ui: CashRegisterMain) =
    let mutable model = {
        ShoppingCart = []
        Subtotal = 0m
        Tax = 0m
        Total = 0m
        }
    
    let UpdateForm newModel =
        ui.ShoppingCart.Items.Clear()
        model <- newModel
        model.ShoppingCart |> List.map(fun item -> ui.ShoppingCart.Items.Add(item))
        ui.Subtotal.Text <- model.Subtotal.ToString()
        ui.Tax.Text <- model.Tax.ToString()
        ui.Total.Text <- model.Total.ToString()
        ui.ItemName.Text <- ""
        ui.Price.Text <- ""
        ui.Quantity.Text <- ""

    let CalculateValues model =
        let subtotal = model.ShoppingCart |> List.sumBy(fun p -> p.Price * (decimal <| p.Quantity))
        let tax = subtotal * 0.08m
        let total = subtotal + tax
        { model with Subtotal = subtotal; Tax = tax; Total = total }

    let AddItem model =
        let newItem = 
            { Name = ui.ItemName.Text; Price = ui.Price.Text |> decimal; Quantity = ui.Quantity.Text |> int } 
        { model with ShoppingCart = newItem :: model.ShoppingCart }
    
    do ui.btnAddItems.Click.Add(fun _ ->
        AddItem model |> CalculateValues |> UpdateForm |> ignore
        )

    let DeleteItem model =
        let newCart = model.ShoppingCart |> List.filter(fun i -> i.ToString() <> ui.ShoppingCart.SelectedItem.ToString())
        { model with ShoppingCart = newCart }

    do ui.btnDeleteItem.Click.Add(fun _ ->
        DeleteItem model |> CalculateValues |> UpdateForm |> ignore
        )
     
    do ui.btnClear.Click.Add(fun _ ->
        MainModel.Default |> UpdateForm
    )
    
    do ui.btnCheckout.Click.Add(fun _ ->
    //open Checkout form
    ())

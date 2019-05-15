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

type CRMainController(ui: CashRegisterMain) =
    let initModel = {ShoppingCart = [];
                     Subtotal = 0m;
                     Tax = 0m;
                     Total = 0m}
    
    let UpdateForm model =
        ui.ShoppingCart.Items.Clear()
        model.ShoppingCart |> List.map(fun item -> ui.ShoppingCart.Items.Add(item))
        ui.Subtotal.Text = model.Subtotal.ToString()
        ui.Tax.Text = model.Tax.ToString()
        ui.Total.Text = model.Total.ToString()

    let AddItem model =
        let newModel = {ShoppingCart = {Name = ui.ItemName.Text; Price = ui.Price.Text |> decimal; Quantity = ui.Quantity.Text |> int} :: model.ShoppingCart;
                        Subtotal = 0m;
                        Tax = 0m;
                        Total = 0m;}
        newModel
        
    
    do ui.btnAddItems.Click.Add(fun _ ->
        UpdateForm (AddItem initModel) |> ignore
        )


    do ui.btnDeleteItem.Click.Add(fun _ ->
        //delete item from model and update view with new model
        ())
     
    do ui.btnClear.Click.Add(fun _ ->
    //reset model to initModel and update view with initModel
    ())
    
    do ui.btnCheckout.Click.Add(fun _ ->
    //open Checkout form
    ())


(*
    
    let CheckoutClicked =
        let form = new FSharpCashRegister.Checkout()
        
     
*)
namespace Register.FSharp
open FSharpCashRegister
open System.Windows.Forms
open System.Drawing
open TrivialBehind
open System.Runtime.InteropServices

type CheckoutModel = {
    Subtotal: decimal
    Tax: decimal
    Total: decimal
    Payment: decimal
    Change: decimal
}

type CheckoutController(ui: CheckoutForm) =
    let mutable model = {
                        Subtotal = ui.Subtotal.Text |> decimal;
                        Tax = ui.Tax.Text |> decimal;
                        Total = ui.Total.Text |> decimal;
                        Payment = 0m;
                        Change = 0m
                        }

    let UpdateForm newModel =
        model <- newModel
        ui.Change.Text <- model.Change.ToString()

    let Checkout model = 
        if (ui.Payment.Text |> decimal) < model.Total
        then
            MessageBox.Show("Insufficient payment amount")
            model
        else
            { model with Payment = ui.Payment.Text |> decimal; Change = (ui.Payment.Text |> decimal) - model.Total }

    do ui.btnCheckout.Click.Add(fun _ ->
        Checkout model |> UpdateForm |> ignore
    )
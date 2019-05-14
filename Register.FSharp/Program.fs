open System.Windows.Forms
open FSharpCashRegister
open Register.FSharp
open TrivialBehind

[<EntryPoint>]
let main argv = 
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)

    TrivialBehinds.RegisterBehind<CashRegisterMain, CRMainController>()
    let form = new CashRegisterMain()
    Application.Run(form)
    0

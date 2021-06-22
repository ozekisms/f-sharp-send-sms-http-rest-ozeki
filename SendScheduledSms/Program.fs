open Ozeki.Libs.Rest
open System

[<EntryPoint>]
let main argv =
    let configuration = new Configuration (
        Username = "http_user",
        Password = "qwe123",
        ApiUrl = "http://127.0.0.1:9509/api")

    let msg = new Message(
        ToAddress = "+36201111111", 
        Text = "Hello, World!",
        TimeToSend = DateTime.Parse("2021-06-07 11:44:00"))

    let api = new MessageApi(configuration)

    let result = api.Send(msg)

    printfn $"{result.ToString()}"
    0
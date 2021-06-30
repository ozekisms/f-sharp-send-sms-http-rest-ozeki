open Ozeki.Libs.Rest

[<EntryPoint>]
let main argv =
    let configuration = new Configuration (
        Username = "http_user",
        Password = "qwe123",
        ApiUrl = "http://127.0.0.1:9509/api")

    let msg = new Message(
        ToAddress = "+36201111111", 
        Text = "Hello, World!")

    let api = new MessageApi(configuration)

    let result = api.Send(msg)

    printfn $"{result}"
    0
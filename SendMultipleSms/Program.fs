open Ozeki.Libs.Rest

[<EntryPoint>]
let main argv =
    let configuration = new Configuration (
        Username = "http_user",
        Password = "qwe123",
        ApiUrl = "http://127.0.0.1:9509/api")

    let msg1 = new Message(
        ToAddress = "+36201111111", 
        Text = "Hello, World 1")

    let msg2 = new Message(
        ToAddress = "+36202222222", 
        Text = "Hello, World 2")

    let msg3 = new Message(
        ToAddress = "+36203333333", 
        Text = "Hello, World 3")

    let messages = [ msg1; msg2; msg3 ]

    let api = new MessageApi(configuration)

    let result = api.Send(messages)

    printfn $"{result}"
    0
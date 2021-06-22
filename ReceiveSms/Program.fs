open Ozeki.Libs.Rest

[<EntryPoint>]
let main argv =
    let configuration = new Configuration (
        Username = "http_user",
        Password = "qwe123",
        ApiUrl = "http://127.0.0.1:9509/api")

    let api = new MessageApi(configuration)

    let result = api.DownloadIncoming();

    printfn $"There are {result.Length} messages in the inbox folder:"
    for message in result do
        printfn $"From: {message.FromAddress} - Text: {message.Text}"
    0
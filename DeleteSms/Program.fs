open Ozeki.Libs.Rest

[<EntryPoint>]
let main argv =
    let configuration = new Configuration (
        Username = "http_user",
        Password = "qwe123",
        ApiUrl = "http://127.0.0.1:9509/api")

    let msg = new Message(
        ID = "89177ea8-d4d9-492c-bca8-69d4fdcb4a31")

    let api = new MessageApi(configuration)

    let result = api.Delete(Folder.Inbox, msg);

    printfn $"{result}"
    0
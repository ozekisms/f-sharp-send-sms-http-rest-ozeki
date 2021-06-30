# F# sms library to send sms with http/rest/json

This F# sms library enables you to **send** and **receive sms** from F# with http requests. 
The library uses HTTP Post requests and JSON encoded content to send the text
messages to the mobile network1. This library uses the HTTP API of 
[Ozeki SMS gateway](https://ozeki-sms-gateway.com). Visit the link the learn about the gateway. 
This repository is better for implementing SMS solutions then other alternatives, because it allows
you to use the same code to send SMS through an Android mobile, through
a high performance IP SMS connection or a GSM modem or modem pool. This
library gives you SMS service provider independence.

## What is Ozeki SMS Gateway 

The Ozeki SMS Gateway is a high performance and high speed gateway that is capable to send 1000 SMS / second, while being reliable and safe. It runs on your computer, so you have maximum security for your data and contact list. It is easy to use and versatile because it offers service provider independence. It allows you to connect to various SMS service providers. You can install the gateway to Windows, Linux or and Android device. Ozeki also provides direct access to the mobile network through wireless connections.

Download: [Ozeki SMS Gateway download page](https://ozeki-sms-gateway.com/p_727-download-sms-gateway.html)

Tutorial: [F# send sms sample and tutorial](https://ozeki-sms-gateway.com/p_825-how-to-send-sms-from-f-sharp.html)

## How to send sms from F#: 

**To send sms from F#**
1. [Download Ozeki SMS Gateway](https://ozeki-sms-gateway.com/p_727-download-sms-gateway.html)
2. [Connect Ozeki SMS Gateway to the mobile network](https://ozeki-sms-gateway.com/p_70-mobile-network-connections.html)
3. [Create an HTTP SMS API user](https://ozeki-sms-gateway.com/p_2102-create-an-http-sms-api-user-account.html)
4. Start Visual Studio
5. Create a solution called Send-SMS.sln
6. Add a F# console project: Send-SMS.fsproj
7. Put the code into Program.fs or Send-SMS.fs
8. Create a F# function called Send_SMS
9. Create the SMS Json data
10. Create a http request to send the SMS


## How to use the code

To use the code you need to import the Ozeki.Libs.Rest sms library. This
sms library is also included in this repositry with it's full source code.
After the library is imported with the using statiment, you need to define
the username, password and the api url. You can create the username and 
password when you install an HTTP API user in your Ozeki SMS Gateway system.

The URL is the default http api URL to connect to your SMS gateway. If you
run the SMS gateway on the same computer where your F# code is runing, you
can use 127.0.0.1 as the ip address. You need to change this if you install
the sms gateway on a different computer (or mobile phone).


```
open System
open Ozeki.Libs.Rest
 
[<entrypoint>]
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
</entrypoint>
```

## Manual / API reference

To get a better understanding of the above **SMS code sample**, feel free to visit the provided tutorial on the link below.
You can find videos, explanations and downloadable content here.

Link: [How to send sms from F#](https://ozeki-sms-gateway.com/p_825-how-to-send-sms-from-f-sharp.html)


## How to send sms through your Android mobile phone

If you wish to [send SMS through your Android mobile phone from F#](https://android-sms-gateway.com/), 
you need to [install Ozeki SMS Gateway on your Android](https://ozeki-sms-gateway.com/p_2847-how-to-install-ozeki-sms-gateway-on-android.html) 
mobile phone. It is recommended to use an Android mobile phone with a minimum of 
4GB RAM and a quad core CPU. Most devices today meet these specs. The advantage
of using your mobile, is that it is quick to setup and it often allows you
to [send sms free of charge](https://android-sms-gateway.com/p_246-how-to-send-sms-free-of-charge.html).

[Android SMS Gateway](https://android-sms-gateway.com)

## Get started now

Stop wasting time, use the repository and start sending SMS.

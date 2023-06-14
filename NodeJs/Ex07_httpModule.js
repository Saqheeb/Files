//http module is a very importtant module that is used for creating server side programming in NodeJs
//with this, it allows to process web pages(HTML) using httpRequest and HttpResponse objects
//with Http module, we can create webApps, web API's and other kinds od Internet based applications. HTTP is the standard protocol for all internet activivties

const http = require('http')
const fs = require('fs')
const currDir = __dirname

function processUrl(request,response){
    const url =request.url
    const content = url + " and its contents are processed and sent"
    response.write(content)
    response.end()
}


http.createServer((request, response)=>{
    if(request.url != "/favicon.ico"){
        if(request.url == "/client"){
            fs.createReadStream(currDir + "\\Client.html").pipe(response)
            return
        }else{
            processUrl(request,response)
            return
        }
    }
    // response.write("hello saqheeb i hope you are doing well")
    // response.end()//send the response to the request
}).listen(3000)

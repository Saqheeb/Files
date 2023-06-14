const http = require('http')
const fs = require('fs')
const parse = require('url').parse
const qs = require('querystring')
const currDir = __dirname
const data = require('./MyData.json')
const empList = [
    { "id": 115, "empName": "Saqheeb", "empAddres": "Shimoga" }, { "id": 116, "empName": "Sanchitha", "empAddres": "Gangavati" }, { "id": 117, "empName": "Shaghil", "empAddres": "Sagar" }, { "id": 118, "empName": "Vijesh", "empAddres": "Bengaluru" }
]


function errorPage(res) {
    fs.createReadStream(currDir + "//ErrorPage.html").pipe(res)
}

function addRecordToFile(data) {
    let name = data.userName
    let mail = data.userMail
    appendData(name, mail)
}

function appendData(name, mail){
    const csv = `${name},${mail}\n`;
    fs.appendFileSync("./records.csv",csv)
}

function processGet(req, res) {
    let data = parse(req.url, true).query
    console.log(data)
    const msg = `<p>Thanks Mr.${data.userName} for registering with us`
    res.write(msg)
    addRecordToFile(data)
    res.end()
}

function processPost(req, res){
    let inputValues = ""
    req.on("data",function(result){//form is posted
        inputValues += result
    })
    req.on("end",function(){//when posted form reaches the server
        let postedData = qs.parse(inputValues)
        // const msg =`<p>Thanks Mr.${postedData.userName} for registering with us`
        res.write("Check the CSV file for the values")
        appendData(postedData.userName, postedData.userMail)
        res.end()
    })
}

function showAll(res){
    const collection = []
    const data = fs.readFileSync("./records.csv","utf-8")
    for(const line of data.split("\n")){
        if(line.name != ""){
            const words = line.split(',')
            collection.push({ "name": words[0], "email": words[1] })
        }
    }
    console.table(collection)
    res.write(JSON.stringify(collection))
    res.end()
}

http.createServer((req, res) => {
    if (req.method == "GET") {
        const query = parse(req.url).query
        // console.log("start" + query +"end")
        if (query != null) {
            processGet(req, res)
            return
        }
    }else if (req.method == "POST") {
        processPost(req, res)
        return
    } 
    console.log(req.url)
    switch (req.url.toLowerCase()) {
        case "/employees":
            res.write(JSON.stringify(empList));
            break
        case "/data":
            res.write(JSON.stringify(data));
            break
        case "/registration":
            fs.createReadStream(currDir + "//Registration.html").pipe(res)
            return;
        case "/showall":
            showAll(res)    
            return
        default:
            errorPage(res);
            return
    }
    res.end()
}).listen(3000)
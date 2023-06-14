const express = require('express')
const app = express()
const PORT = 3000
const root = __dirname


//bodyParser
const bodyParser = require('body-parser')
app.use(bodyParser.json())
app.use(bodyParser.urlencoded({ extended: true }))





app.get('/',(req,res)=>{
    res.send("Welcome Mohammed Saqheeb HR")
})

app.get('/employees',(req,res)=>{
    res.send("Awaiting Employees List")
})

app.get('/client',(req,res)=>{
    res.sendFile(root + "/client/client.html")
})

app.get('/registration',(req,res)=>{
    res.sendFile(root + "/client/registration.html")
})

app.get('/afterRegistration',(req,res)=>{
    const name = req.query.userName
    const mail = req.query.userMail
    const msg = `Mr.${name}. Thanks for joining us.<br>You will be cosntacted using ${mail} for further communication`
    res.send(msg)
})

app.post('/afterRegistration',(req,res)=>{
    if(req.body == undefined)
        console.log("No body is formed while th eform is posted")
    else{
        const name = req.body.userName
        const mail = req.body.userMail
        console.log(name +"\n"+ mail)
        const msg = `Mr.${name}. Thanks for joining us.<br>You will be cosntacted using ${mail} for further communication`
        res.send(msg) 
    }    
})

app.listen(PORT,()=>{
    console.log(`The Application is running on port number: ${PORT}`)
})
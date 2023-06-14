const app = require('express')()
const parser = require('body-parser')
const server = require('mssql/msnodesqlv8')


const PORT = 3000


const config = {
    server : ".",
    database : 'InternTraining',
    driver : "msnodesqlv8",
    options : {
        trustedConnection : true,
        TrustedServerCertificate : true
    }
}


const pool = new server.ConnectionPool(config, (err)=>{
    console.log(err)
})

app.get("/AllEmployees", (req,res)=>{
    pool.connect().then(()=>{
        pool.request().query("SELECT * FROM EmpTable",(err,result)=>{
            if(err)
                console.error(err)
            else
                res.send(result.recordset)    
        })
    }).catch((err)=>{
        if(err) console.error(err)
    })
})

app.listen(PORT, ()=> console.log(`Server running @ port: ${PORT}`))
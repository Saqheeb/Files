const sql = require("mssql")
async function test(){
    sql.connect("Server =.; Database=InternTraining; Encrypt=true").then((pool)=>{
        pool.request().query("SELECT * FROM EmpTable").then((resp)=>{
            console.log(resp)
        })
    })
}

test();
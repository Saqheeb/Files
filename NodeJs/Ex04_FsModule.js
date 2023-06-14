const fs = require('fs')

//fs module contains APIs for the file 10 operations.NodeJs supports both Synx and Async Funcitons to perform 10 ops
const filename = "./Ex04_FsModule.js"

/////////////SYNC
// const contents = fs.readFileSync(filename,'utf-8')
// console.log(contents)

///////////ASYNC
// fs.readFile(filename,'utf-8',(err,data)=>{
//     if(err)console.log(err)
//     else{
//         console.log(data)
//     }
// })
// console.log("Execute this line first")

//////////WRITE

// const obj ={}
// obj.id=111
// obj.name="Saqheeb"
// obj.address="Bengaluru"
// fs.writeFileSync("sample.txt",JSON.stringify(obj),"utf-8")
// console.log("Sync file written completely")

const obj ={}
obj.id=112
obj.name="Vijesh"
obj.address="Mangaluru"

fs.appendFileSync("sample.txt",JSON.stringify(obj),"utf-8")
console.log("Sync file appended completely")



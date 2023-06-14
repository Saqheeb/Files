console.log("Saqheeb Mohammed")


const addFunc = (v1,v2) => v1+v2
const subFunc = (v1,v2) => v1-v2
const mulFunc = (v1,v2) => v1*v2
const divFunc = (v1,v2) => v1/v2


console.log(addFunc(13,54))
console.log(subFunc(13,54))
console.log(mulFunc(13,54))
console.log(divFunc(13,54))

const data = [
    {"id": 153, "name": "Saqheeb", "address": "Shimoga"},
    {"id": 154, "name": "Shaghil", "address": "Sagar"},
    {"id": 155, "name": "Sanchitha", "address": "Gangavati"},
    {"id": 156, "name": "Abhishek", "address": "Bihar"},
    {"id": 157, "name": "Vijesh", "address": "Bengaluru"}
]


for(const emp of data){
    console.log(emp)
}
console.table(data)
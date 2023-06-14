const externalModule = require("./CustomModule")

console.log(externalModule)

externalModule.simpleFunc()
externalModule.mathOpe()


const empObj = new externalModule.empClass(158, "Gopal", "AndraPradesh")
const customerObj = new externalModule.customer(111, "GnanaPrasad", 60000)

// console.log(customerObj.display())
console.log(JSON.stringify(empObj))
console.log(JSON.stringify(customerObj))

const data = [empObj, customerObj]
console.table(data)
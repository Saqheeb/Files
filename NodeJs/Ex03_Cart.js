const shoppingApp = require("./CartIIFE")
console.log(shoppingApp)

// debugger;
shoppingApp.insertItem({"id" : 111, "itemName" : "Apples", "price": 200 })
shoppingApp.insertItem({"id" : 112, "itemName" : "Banana", "price": 100 })
shoppingApp.insertItem({"id" : 113, "itemName" : "Dragon Fruit", "price": 600 })
shoppingApp.insertItem({"id" : 114, "itemName" : "Mango", "price": 400 })


const items = shoppingApp.getAllItems()

const foundItems = shoppingApp.findItem(113)

console.table(items)
console.log(foundItems)
// 3 ways of creating an object 
//1.Singleton Object
// const emp = { }
// emp.id = 46145;
// emp.name = "Saqheeb"
// emp.phone = 446564654
// emp.address = "Bengaluru"

// console.log(emp)


// let temp = emp
// temp.name = "Sahil"
// console.log(temp)
// console.log(emp)

// const book ={
//     bookId:6546545, bookTitle:"Everyd@y lif3", bookAuthor:"Saqheeb"
// }
// console.log(book)

// for(const attr in book){
//     let msg = `${attr} is the attribute name and its value is ${book[attr]}`
//     console.log(msg)
// }


//2.Function based Classes

// const employee = function(id, name, address){
//     this.empId = id
//     this.empName = name
//     this.empAddress = address;
// }

// const empObj = new employee(564644,"Saqheeb","Bengaluru")
// console.log(empObj)

// const empObj2 = new employee(64654654,"Sahil","Mangalore")
// console.log(empObj2)

//Method 3 Uding ED6 syntax 

class customer{

    constructor(id, name, address, billAmount){
        this.cstID = id;
        this.cstName = name;
        this.cstAddress = address;
        this.billAmount = billAmount;
    }

    display()
    {
        return `${this.cstName} spent an amount of Rs.${this.billAmount} and the products were shipped to ${this.cstAddress}.For further correspondance, the customer should use the id ${this.cstID}`
        // return JSON.stringify(cst)
    }
}


const cst = new customer(6143436, "Saqheeb", "Bengaluru", 56464)
console.log(cst)
console.log(cst.display())
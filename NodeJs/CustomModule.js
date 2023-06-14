module.exports.simpleFunc = () => {
    console.log("Simple funciton to be executed")
}


module.exports.mathOpe = (num=5) =>{
    console.log(`Multiplication Table for ${num}`)

    for (let i = 0; i <= 10 ; i++) {
        console.log(`${num} X ${i} = ${num*i}`)
    }
}


module.exports.empClass = function(id, name, address){
    this.id = id
    this.name = name
    this.address = address
}

module.exports.customer = class{
    constructor(id, name, billAmt){
        this.id = id
        this.name = name
        this.billAmt = billAmt
    }
}
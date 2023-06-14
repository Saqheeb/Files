//Named Function
function sayGreeting(msg){
    console.log(msg)
}


//anonymous Function
const addFunc = function (v1,v2){
    const val1 = parseInt(v1)
    const val2= parseInt(v2)

    return val1+val2
}

sayGreeting("Hello...motherFathher")

const res = addFunc(12,54)
console.log(res)


//Arrow Function
const subFunc = (v1,v2)=>v1-v2

const divFunc = (v1,v2)=>{
    if(v2==0){
        // alert("Division by zero is not allowed!!!")
        return 0;
    }
    else
    return v1/v2
}


const divVal = divFunc(123,0) 
const divVal2 = divFunc(80,2)

console.log(divVal)
console.log(divVal2)


//rest parameter
function addNumbers(...args) {
   let res = 0
   for(const val of args){
        res+=val
   } 
   return res
}

const addedVal = addNumbers(123,23,54,76,46,92)
console.log(addedVal)

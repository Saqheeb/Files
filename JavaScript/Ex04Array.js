//Arrays

let arr = [];

//array in Js is Dynamic
arr.push(16)
arr.push(33)
arr.push(61)
arr.push(45)
arr.push(158)
arr.push(654)


//Iteration the Array
//1.Standard for loop
for(let i =0; i<arr.length; i++){
    console.log(arr[i])
}

//2.For...of loop ES6
for(const val of arr){
    console.log(val)
}

//3.For...in loop ES6
for(const index in arr){
    let msg =`The index ${index} and the value at the index is ${arr[index]}`
    console.log(msg)
}


arr.unshift(111)//add's the element
console.log(arr)

arr = [arr,654,23,541]
console.log(arr)

arr.shift() //removes the element
console.log(arr)

const removedElements = arr.splice(0,2,546,44,76,13)
console.log(removedElements)
console.log(arr)
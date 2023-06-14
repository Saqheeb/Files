// //////1.Default parameters
// function sampleFunc(message="Good Morning"){

//     console.log(message)
// }

// sampleFunc()
// sampleFunc("Good evening")

// function createDiv(height = "350px", width = "400px", display="inline-block", border = "2px solid blue"){
//     const div = document.createElement("div")
//     div.style.height = height
//     div.style.width = width
//     div.style.display = display
//     div.style.border = border

//     const area = document.querySelector("#divArea")
//     area.appendChild(div)
// }

// createDiv()


/////////2.Spred Operators

// function addNumbers(...values){
//     let result =0

//     for(let val of values)
//         result+=val
//     return result    
// }

// console.log(addNumbers(132, 22))
// console.log(addNumbers(132, 22, 45))
// console.log(addNumbers(132, 22, 46, 45))
// console.log(addNumbers(132, 22, 46, 64, 79))


// const data = [1, 2, 3, 4, 5]
// const newData = [0, ...data]
// console.log(newData)

// const south = ["KAR","KL","AP","TN","TS"]
// const north = ["HY","HP","UK","JK","UP","DEL","JHK"]

// const indianStates = [...south, ...north]
// console.log(indianStates)
// console.log(...south)



////////3.Static 

class MathClass{
    static addFunc = (v1, v2) => v1+v2

    callStaticFunc = () => this.constructor.addFunc(123,3)
}

console.log(MathClass.addFunc(123,127))

const cls = new MathClass()
cls.callStaticFunc()
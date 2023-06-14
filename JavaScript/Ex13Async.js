const boilWater = () => console.log("Water is boiling")
const addTea = ()=> console.log("Tea is added to boiling water")
const addMilk = () => console.log("Milk is added to boiling water")
const drinkTea = () => console.log("Tea is being drunk after the previous tasks are completed")

// setTimeout(boilWater,5000)
// setTimeout(addTea,5000)
// setTimeout(addMilk,5000)
// setTimeout(drinkTea,5000)


// function doAsyncOpe(callback, func){
//     setTimeout(() => {
//         callback(func)
//     }, 5000);
// }

// doAsyncOpe(boilWater, addTea)








//1.Promise -> resolve reject
// const boilingOperation = new Promise(function(resolve, reject){
//     console.log("This statement execute immideatly")
//     const value = prompt("Enter a value from 1 - 10:")
//     setTimeout(()=>{
//         if(value < 6){
//             boilWater()
//             resolve("Water has boiled")
//         }else{
//             reject("lets goo....something is wrong in the program")    
//         }
//     },5000)
// })
// console.log("Middlewares are coming perfectly!!!!")
// boilingOperation.then((data)=>{
//     alert(data)
// }).catch((msg)=>{
//     alert(msg)
// }).finally(()=>{
//     console.log("Drink MotherFather")
// })






//2.Async and Await
debugger;
async function doAsyncOpe(){
    const someOp = new Promise((resolve,reject)=>{
        setTimeout(() => {
            alert("some Big Task is gong on")
            resolve("The task is completed")
        }, 5000);
    })

    const status = await someOp;
    alert(status) 
    return "returning some value"
}


doAsyncOpe().then((result)=>{
    alert(result)
})
console.log("is this going to be executed first?")
// 3 ways for interacting with user interface

function uiRelatedFunc() {
    const name = prompt("Enter your Name")
    alert("The Name entered is "+ name)
    const status = confirm("Are you sure?")

    if(status)
        console.log("True")
    else
        console.log("False")    
}


// uiRelatedFunc()



//3 ways to declare Variable in Jd

function variableDeclarartion() {
    const data = "testing Data"//once created cannot be modified
    var test = "variable creation in Js(Old Style)"
    let example = "New way of declaring the variable which more scoped bassed"

    alert(data)
    alert(test)
    alert(example)
}

// var test = 123;//Global vAriable

// function testingCode() {
//     var test = "Apple"
//     alert(test)
// }

// variableDeclarartion()
// testingCode()
// alert(test)




//testing let and var
let test = 123;
console.warn(window.test)
console.log("The value of test: "+ test)
function testFunc(){
    let test =234
    console.log("The value of test: "+ test)
    {
        let test = 345;
    }
    console.log("THe value of test: "+ test)
}
console.log("The value of test: "+ test)
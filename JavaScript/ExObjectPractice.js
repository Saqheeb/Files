const employee = function(id, name, address){
    this.empId = id
    this.empName = name
    this.empAddress = address;
}

const addProperties = () =>{
    const empId = parseInt(document.getElementById('txtId').value)
    console.log(empId)
    const empName = document.getElementById('txtName').value
    console.log(empName)
    const empAddress = document.getElementById('txtAddress').value
    console.log(empAddress)
    
    const obj = employee(empId, empName, empAddress)
    console.log(obj)
    const span = document.getElementById("displayObject")
    span.innerText = JSON.stringify(obj)   
}



/*

const id = parseInt(document.getElementById('txtId').value)
const name = document.getElementById('txtName').value
const address = document.getElementById('txtAddress').value
//create object 
const obj = new employee(id,name,address)
//display the details
const span = document.getElementById("displayObject")
//Method1 using JSON Parsing
span.innerText = JSON.stringify(obj)
//Method2 using interpolation
// span.innerText = `The Name of the employee is ${obj.empName} with ID ${obj.empId} lives in ${obj.empAddress}`
*/
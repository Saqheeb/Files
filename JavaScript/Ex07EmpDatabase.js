///////////////////Entity Class//////////////////////////////////////

class Employee{
    constructor(id, name, email, phone){
        this.id =id;
        this.name = name;
        this.email = email;
        this.phone = phone;
    }
}
///////////////////Repo Class//////////////////////////////////////

class EmpRepo{
    data = []

    // getData

    addEmployee = (emp) => this.data.push (emp)


    getAllEmployee = () => this.data

    findEmployee = (id) => this.data.find((e)=>e.id ===id);

    updateEmployee = (emp) =>{
        const index = this.data.findIndex((e)=>e.id === emp.id)

        if(index === -1)
            throw "Employeee not found"
        this.data.splice(index, 1, emp)    
    }

    deleteEmployee = (id) =>{
        const index = this.data.findIndex((e)=>e.id == id)

        if(index === -1)
            throw "Employeee not found"
        this.data.splice(index, 1) 
    }
}
///////////////////Helper Class////////////////////////////////////

function $get(id) {
    return document.getElementById(id)
}




///////////HTML SCRIPT////////////////

let flag = false; //for add and update button
let db = new EmpRepo();

function getDetails(id){
    const foundEmp = db.findEmployee(id)
    $get("empId").disabled = true;
    $get("empId").value = foundEmp.id;
    $get("empName").value = foundEmp.name;
    $get("empMail").value = foundEmp.email;
    $get("empPhone").value = foundEmp.phone;
    flag=true;
}
 function deleteEmp(id){
    db.deleteEmployee(id)
    displayAll()
    alert("Employee Deleted!!")
 }



function displayAll(){
    const table = $get("tblId")
    table.innerHTML = "<tr><th>Employee ID</th><th>Employee Name</th><th>Options</th></tr>"
    const data = db.getAllEmployee()
    for(const emp of data){
        // console.log(emp)
        const rec = `<tr><td>${emp.id}</td><td>${emp.name}</td><td><a href="#" onCLick="getDetails(${emp.id})">Edit</a><a href="#" onClick="deleteEmp(${emp.id})" >Delete</a></td></tr>`
        table.innerHTML += rec
    }
}


function onAddRecord(){
    $get("id").disabled = false
    flag = false
    clear()
}

function onUpdate(){
    const id = $get("empId").value
}


function clear(){
    $get("empId").value = ""
    $get("empName").value = ""
    $get("empMail").value = ""
    $get("empPhone").value = ""

}

function onAddNew() {
    // debugger;
    let id = parseInt($get("empId").value)
    let name = $get("empName").value
    let email = $get("empMail").value
    let phone = parseInt($get("empPhone").value)
    const newEmp = new Employee(id, name, email, phone)

    if(flag){
        db.updateEmployee(newEmp)
        alert("Employee updated successfully")
    }else{
        db.addEmployee(newEmp)
        alert("Employee added successfully")
    }
    displayAll();
}

function initialize(){
    //add some records manually
    // db.addEmployee(new Employee(157,"Saqheeb","saqheeb@gmail.com",9556464646))
    // db.addEmployee(new Employee(761,"Sahil","sahil@gmail.com",9556464646))
    // db.addEmployee(new Employee(157,"Shaghil","shaghil@gmail.com",9556464646))
    // db.addEmployee(new Employee(157,"vijesh","vijesh@gmail.com",9556464646))


    const allLink = document.getElementsByTagName("a")
    const allRecLink = allLink[0]
    allRecLink.addEventListener("click",displayAll)
    const addRecLink = allLink[1]
    addRecLink.addEventListener("click",onAddRecord)

    const allButtons = document.getElementsByTagName("button")
    allButtons[0].addEventListener("click",onAddNew)//add   
    allButtons[1].addEventListener("click",onAddNew)//update
}

window.addEventListener("load",initialize)
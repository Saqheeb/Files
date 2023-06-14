
// const data = new Map();

// data.set("Saqheeb","hairyFairy79")

// if(data.has("Saqheeb"))
//     alert("Saqheeb is Here")


function $get(id) {
    return document.getElementById(id)
}


/////////////////////////////
const users = new Map();


window.addEventListener("load",initializeMaps);


function signUp(uname, pwd){
    if(users.has(uname)){
        alert("User already Exists")
        return
    }
    users.set(uname, ped)
    alert("The user is registered with us!!")
    console.log(users)
}

function signIn(uname, ped){
    if(!users.has(uname)){
        alert("User name is not available")
        return
    }
    if(users.get(uname) == pwd){
        alert("User name is not available")
    }else{
        alert("Password is wrong")
    }
    console.log(users)
}

function initializeMaps(){
    // const allButtons = document.getElementsByTagName("button")
    // allButtons[0].addEventListener("click",signIn($get("txtUserName"),$get("txtPwd")))
    // allButtons[1].addEventListener("click",signUp($get("txtNewUserName"),$get("txtNewPwd")))
    let signBtn = $get("signBtn")
    signBtn.addEventListener("click",()=>{
        const uname = $get("txtNewUserName").value
        const pwd = $get("txtNewPwd").value
        signUp(uname, pwd)
    })

    let regBtn = $get("regBtn").value
    regBtn.addEventListener("click",()=>{
        const uname = $get("txtUserName").value
        const pwd = $get("txtPwd").value
        signIn(uname, pwd)
    })

}


let fruits=[]

window.addEventListener("load",function () {
    if(localStorage.getItem("Data") != undefined){
        const value = localStorage.getItem("Data")
        $get("ulData").innerHTML +="<li>"+value+"</li>"
    }

    $get("btnSave").addEventListener("click",function(){
        let value = $get("txtInput").value
        fruits.push(value)
        localStorage.setItem("Data",JSON.stringify(fruits))
        for(const item of fruits){
            $get("ulData").innerHTML += "<li>"+ item + "</li>" 
        }
    })

    //Erorrs!!
    $get("btnPop").addEventListener("click",function(){
        let val = fruits.pop()
        localStorage.removeItem("Data")
        console.log(val)
        for(const item of fruits){
            $get("ulData").innerHTML += "<li>"+ item + "</li>" 
        }
    })
})


function $get(id) {
    return document.getElementById(id)
}
function invokeFunc(v1,v2,func){
    const result = func(v1,v2)
    alert(result)
}

invokeFunc(13,12,(v1,v2)=>{
    return v1*v2
})
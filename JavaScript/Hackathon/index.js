const mainStr = "the quick brown fox jumps over the lazy dog"
const mainArr = mainStr.split(' ')
// console.log(mainStrArr)

function encrypt(){
    const inputStr = document.getElementById("txtInput").value
    // const str = inputStr.toLowerCase
    // console.log(str)
    
    // encryptLogic(str.toLowerCase());
    encryptLogic(inputStr)


}

function encryptLogic(str){
   let res=""

   for(let i=0; i<str.length; i++){
       let searchTerm = str.charAt(i).toLowerCase()
       
       for(let j=0; j<mainArr.length; j++){
            console.log(searchTerm)
            if(searchTerm === " "){
                res=res + "-"
                break;
            }else{
                unit = mainArr[j].indexOf(searchTerm)
                console.log(unit)
            
                if(unit == -1)
                    continue
                else
                    res = res + j + unit    
                break
            }
        }
        res = res +","
    }
    
    // document.getElementById("txtOutput").innerHTML += res
    let txtOutput = document.getElementById("txtOutput")
    txtOutput.innerHTML = res.substring(0,res.length-1)
}
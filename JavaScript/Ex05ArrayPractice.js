let arr = []

function addFunc(val) {
    arr.push(val)
    console.log(arr)
}

const getAll = () =>arr

const deleteVal = (item) =>{
    let index = arr.indexOf(item)

    if(index == -1)
        alert("Item not Found!!!!")
    else
        arr.splice(index,1)    
}

function populateItems() {
    let ul = document.getElementById("listValues")
    ul.innerHTML = " "
    const items = getAll();
    for(const val of items){
        let li = `<li>${val}<a href="#" onClick=onRemoveItems("${val}")>X</li>`
        ul.innerHTML +=li;    
    }
}
function addItems() {
    const val = document.getElementById("inputVal").value
    addFunc(val)
    populateItems();
}

function onRemoveItems(item){
    deleteVal(item);
    populateItems();
}
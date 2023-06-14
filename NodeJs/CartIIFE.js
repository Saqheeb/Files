module.exports = (function(){
    let cart = []

    function addItem(item){
        cart.push(item)
    }

    function getAllItems(){
        return cart
    }

    function findItem(id){
        return cart.find((item)=> item.id == id) 

        /*OR
        //Arrow Function expression way but you need to use return statement 
        return cart.find((item)=> {
            console.log(item.id)
            return item.id == id
        })
        */
    }

    return{
        insertItem : addItem, //Giving addItem alais
        getAllItems,
        findItem
    }

})()
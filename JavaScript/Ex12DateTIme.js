const currentDate = new Date()

let months = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December']

const dateFormat = `${currentDate.getDate()}/${currentDate.getMonth()+1}/${currentDate.getFullYear()}`

console.log(dateFormat)
console.log(currentDate)
console.log(currentDate.getMonth()+1)
console.log(currentDate.getFullYear())
console.log(currentDate.getDate())
console.log(currentDate.getDay()+1)
console.log(`The current time is ${currentDate.getHours()}:${currentDate.getMinutes()}`)
const currentMonth = currentDate.getMonth();
console.log(`${months[currentMonth]}`)


function displayDate(_date){
    // debugger;
    const div = document.createElement("div")
    const year = _date.getFullYear()
    const month = months[_date.getMonth()]
    const dt = _date.getDate()
    div.innerHTML = `${dt} - ${month}-${year}`
    document.body.appendChild(div)
}

function displayTime(time){
    const hr = time.getHours()
    const min = time.getMinutes()
    const sec = time.getSeconds()
    // const div = document.createElement("div")
    const div = document.getElementById("time")
    div.innerHTML = `${hr}:${min}:${sec}<br>`
    document.body.appendChild(div)
}


function createDate(){
    year = parseInt(prompt("Enter the year of the date"))
    month = parseInt(prompt("Enter the month of the year"))
    dt = parseInt(prompt("Enter the date of the month"))
    return new Date(year, month, dt)
}

function onDispaly(){
    const value = document.getElementById("txtDate").value
    const dateobj = new Date(value)
    displayDate(dateObj)
}

function onSetTime(){
    const currentDate = new Date()
    displayTime(currentDate)
}
setInterval(onSetTime,1000)

const date = createDate()
displayDate(date)
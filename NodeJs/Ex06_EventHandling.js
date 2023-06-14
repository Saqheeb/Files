const events = require('events')

const button = new events()

//register event
button.on("test", (msg)=> console.log(msg))
button.on("click", ()=> console.log("click event has occured"))

//Emit method is used to trigger the event
button.emit("test","testing has happened once")
button.emit("click")
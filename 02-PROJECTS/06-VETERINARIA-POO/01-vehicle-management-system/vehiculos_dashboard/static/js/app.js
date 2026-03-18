let speed = 0

function accelerate(){

speed += 10

document.getElementById("speed").textContent = speed

}

function brake(){

speed -= 10

if(speed < 0) speed = 0

document.getElementById("speed").textContent = speed

}
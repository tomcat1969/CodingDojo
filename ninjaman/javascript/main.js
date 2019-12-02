var world = [];
var worldScale = 16;
var lifes = 3;
function r() {   // generate a random number 0 1 2 3
    return Math.floor(Math.random() * 4 );
}
for(var i = 0; i < worldScale; i++) {
    world[i] = []
    for(var j = 0; j < worldScale; j++) {
        if( i == 0 || j == 0 || i == worldScale - 1|| j == worldScale - 1) {
            world[i][j] = 1;
        }else{

            world[i][j] = r();
        }

    }
}

var worldDict = {
    0:'blank',
    1:'wall',
    2:'sushi',
    3:'onigiri'
}

var scores = 0




function drawWorld() {
    output = ""

    for(var row = 0; row < world.length; row++) {
        output += "<div class = 'row'>"
        for(var x = 0; x < world[row].length; x++) {
            output += "<div class='" + worldDict[world[row][x]] + "' ></div>"
        }
        output += "</div>";
    }

    document.getElementById('world').innerHTML = output;
}

drawWorld()


var ninjaman = {
    x:1,
    y:1
}


var scaredy = {
    x:worldScale - 2,
    y:worldScale - 2
}






function drawNinjaman() {
    document.getElementById('ninjaman').style.top = ninjaman.y * 40 + 'px'
    document.getElementById('ninjaman').style.left = ninjaman.x * 40 + 'px'
}

function drawScaredy() {
    document.getElementById('scaredy').style.top = scaredy.y * 40 + 'px'
    document.getElementById('scaredy').style.left = scaredy.x * 40 + 'px'
}

drawNinjaman()
drawScaredy()

function ghostHit() {
    if(ninjaman.x == scaredy.x && ninjaman.y == scaredy.y) {
        return true;
    }
}

function changeDirection() {
    var direction = Math.floor(Math.random() * 4 )
    console.log(direction)
    if(direction == 0) {
        goleft();
    }else if(direction == 1) {
        goright();
    }else if(direction == 2) {
        goup();
    }else if(direction == 3) {
        godown();
    }
    drawScaredy();
    if(ghostHit()) {
        lifes--;
    }
    if(lifes == 0) {
        alert("game over")
    }
    console.log("lifes is ",lifes)
}

function goleft() {
    if(world[scaredy.y][scaredy.x - 1] != 1) {
        scaredy.x--;
    }
}
function goright() {
    if(world[scaredy.y][scaredy.x + 1] != 1) {
        scaredy.x++;
    }
}
function goup() {
    if(world[scaredy.y - 1][scaredy.x] != 1) {
        scaredy.y--;
    }
}
function godown() {
    if(world[scaredy.y + 1][scaredy.x] != 1) {
        scaredy.y++;
    }
}

setInterval(changeDirection, 100)

document.onkeydown = function(e){

    if(e.keyCode == 37 && world[ninjaman.y][ninjaman.x - 1] != 1) { // LEFT
        if(world[ninjaman.y][ninjaman.x - 1] == 2) {
            scores += 10;
        } else if(world[ninjaman.y][ninjaman.x - 1] == 3) {
            scores += 5;
        }
        ninjaman.x--

    }
    if (e.keyCode == 39 && world[ninjaman.y][ninjaman.x + 1] != 1) { // RIGHT
        //console.log('x = ',ninjaman.x,'y = ',ninjaman.y,'world[y][x] = ',world[ninjaman.y][ninjaman.x + 1])
        if(world[ninjaman.y][ninjaman.x + 1] == 2) {
            scores += 10;
        }else if(world[ninjaman.y][ninjaman.x + 1] == 3) {
            scores += 5;
        }
        ninjaman.x++

    }
    if (e.keyCode == 40 && world[ninjaman.y + 1][ninjaman.x] != 1) { // DOWN
        if(world[ninjaman.y + 1][ninjaman.x] == 2) {
            scores += 10;
        }else if(world[ninjaman.y + 1][ninjaman.x] == 3) {
            scores += 5;
        }
         ninjaman.y++

    }
    if (e.keyCode == 38 && world[ninjaman.y - 1][ninjaman.x] != 1) { // up
        if(world[ninjaman.y - 1][ninjaman.x] == 2) {
            scores += 10;
        }else if(world[ninjaman.y - 1][ninjaman.x] == 3) {
            scores += 5;
        }
        ninjaman.y--

    }



     world[ninjaman.y][ninjaman.x] = 0;
    drawNinjaman()
    drawWorld()
    console.log('score is ',scores)
    document.getElementById('score').innerHTML = scores;

}

//keep score of how many sushi's ninjaman eats
//sushi = 10pts onigiri = 5pts
//advanced challenges - random world
//hacker challenges - create ghosts that chase ninjaman



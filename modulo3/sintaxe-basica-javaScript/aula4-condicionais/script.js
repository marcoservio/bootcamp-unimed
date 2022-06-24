var jogador1 = 0;
var jogador2 = 0;
var placar;

// if ternário
jogador1 != -1 && jogador2 != -1 ? console.log('Os jogadores são validos') : console.log('Jogadores inválidos');

if(jogador1 > 0 && jogador2 == 0) {
    console.log('Jogador1 marcou ponto');
     placar = jogador1 > jogador2;
} else if(jogador2 > 0 && jogador1 == 0){
    console.log('Jogador2 marcou ponto');
    placar = jogador2 > jogador1;
} else {
    console.log('Ninguém marcou ponto');
}

switch(placar) {
    case placar = jogador1 > jogador2:
        console.log('Jogador1 ganhou');
        break;
    case placar = jogador2 > jogador1:
        console.log('Jogador2 ganhou');
        break;
    default:
        console.log('Ninguem ganhou');
}

let array = ['valor1', 'valor2', 'valor3', 'valor4', 'valor5'];
let object = {propriedade1: 'valor1', propriedade2: 'valor2', propriedade3: 'valor3'}

for(let indice = 0; indice < array.length; indice++) {
    console.log(indice);
}

// For/in
for(let i in array) {
    console.log(i);
}

for(i in object) {
    console.log(i);
}

// For/of
for(i of array) {
    console.log(i);
}

// Não da pra usar for of com objetos
for(i of object.propriedade1) {
    console.log(i);
}

var a = 0;
while(a < 10) {
    a++;
    console.log(a);
}

a = 0;
do {
    a++
    console.log(a);
} while(a < 10)
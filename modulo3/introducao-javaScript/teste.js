// Comentario multlinha
/* var y = 0;
var x = 1; */

// Comentaria unica linha
// var z = 2;

//var preco = 2;
var desconto = 0.2;
// Constante com letras maiúsculas
const PRECO = 2;

var total = PRECO - desconto;

function soma(a, b) {
    console.log(a + b);
    return a + b;
}

soma(3 + 5);

console.log('Hello World');

// Entrar na pasta pelo terminal -> node nomeArquivo.js

function returnEvenValues(array) {
    var evenNums = [];
    for(var i = 0; i < array.length; i++) {
        if(array[i] % 2 == 0) {
            evenNums.push(array[i])
        } else {
            console.log(`${array[i]} não é par`);
        }
    }
    console.log('Os números pares são: ', evenNums);
}

var array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
returnEvenValues(array);
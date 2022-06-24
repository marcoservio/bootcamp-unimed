// Tipos de função
function funcao() {
    console.log('Essa mensagem veio de uma função');
}
funcao();

var func = function func2() {
    console.log('Sou uma mensagem de função de expressão');
}
func();

var func2 = function() {
    console.log('Sou uma mensagem de função de expressão');
}
func2();

var arrowFunc = () => {
    console.log('Sou uma arrow function');
}
arrowFunc();

function mensagem(primeiro, segundo) {
    console.log(primeiro, segundo);
}
mensagem('Tudo certo', 'jovem!');


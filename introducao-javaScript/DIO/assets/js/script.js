var currentNumberWrapper = document.getElementById('currentNumber');

var currentNumber = 0;

function adicionar() {
    alert('Adicioando 1');
}

function subitrair() {
    alert('Subtraindo 1');
}

function addEventos() {
    btn = document.getElementById('adicionar')
    btn.addEventListener('click', teste);
}

window.addEventListener('load', addEventos);

btn = document.getElementById('adicionar');
btn.addEventListener('click', adicionar);

btn2 = document.getElementById('subtrair');
btn2.addEventListener('click', subitrair);

function increment() {
    currentNumber += 1;
    if(currentNumber > 0) {
        currentNumberWrapper.style.color = 'green';
    }
    if(currentNumber > 15) {
        currentNumber = 15;
    }
    currentNumberWrapper.innerHTML = currentNumber;
}

function decrement() {
    currentNumber -= 1;
    if(currentNumber < 0) {
        currentNumberWrapper.style.color = 'red';
    }
    if(currentNumber < -15) {
        currentNumber = -15;
    }
    currentNumberWrapper.innerHTML = currentNumber;
}


var adc = document.getElementById('add');
var txt = document.getElementById('txtLista');
var box = document.getElementById('box');

function createLabel() {
    var elemento = document.createElement('label');
    elemento.setAttribute('id', 'label');
    elemento.textContent = txt.value;
    box.appendChild(elemento);
}

function createInput() {
    var elemento = document.createElement('input');
    elemento.setAttribute('type', 'checkbox');
    elemento.setAttribute('id', 'check');    
    box.appendChild(elemento);
}

function pularLinha() {
    var mybr = document.createElement('br');
    box.appendChild(mybr);
}

function add() {
    if(txt.value != '') {
        createInput();
        createLabel();
        pularLinha();
    }
    else {
        alert('Digite alguma coisa.')
    }
}

function apaga() {
    txt.value = '';
}

txt.addEventListener('click', apaga)
adc.addEventListener('click', add);
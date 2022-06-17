function iguais(a, b) {
    var simNao = 'não'
    
    //saoIguais = a === b;
    //return saoIguais ? 'São iguais' : 'não são iguais';

    if(a == b) {
        simNao = '';
    }

    return `Os números ${a} e ${b} ${simNao} são iguais.`;
}

function maiorMenor(a, b) {
    var soma = a + b;
    var compare10 = 'menor';
    var compare20 = 'menor';

    if(soma > 10) {
        compare10 = 'maior';
    }
    if(soma > 20) {
        compare20 = 'maior';
    }

    return `Sua soma é ${soma}, que é ${compare10} do que 10 e ${compare20} do que 20.`;
}

function comparaNumeros(a, b) {    
    if(!a || !b) {        
        if(a == 0) {
            return `${iguais(a, b)} ${maiorMenor(a, b)}`;
        }
        if(b == 0) {
            return `${iguais(a, b)} ${maiorMenor(a, b)}`;
        }
        if(isNaN(a) || isNaN(b)) {
            return 'Digite somente valores numericos';
        }
        return 'Defina dois números';
    }
}

console.log(comparaNumeros(1, 0));
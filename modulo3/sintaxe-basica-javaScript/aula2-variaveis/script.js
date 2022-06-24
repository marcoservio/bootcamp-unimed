// Tipos primitivos

    // boolean
        var vOuF = false;
        console.log(vOuF);
        console.log(typeof(vOuF));

    // number
        var numeroQualquer = 1;
        console.log(numeroQualquer);
        console.log(typeof(numeroQualquer));

    // string
        var nome = 'Marco';
        console.log(nome);
        console.log(typeof(nome));

    // como declarar
        var variavel = 'Marco';
        variavel = 'Marco Sérvio'
        console.log(variavel);

        let variavel2 = 'Marco';
        variavel2 = 'Marco Sérvio';
        console.log(variavel2);

        const constante = 'Andreza';
        //constante = 'Ana' -> Erro constante não pode ter atribuição de valor
        console.log(constante);
    
    // escopo
        var escopoGlobal = 'global';
        console.log(escopoGlobal);

        function escopoLocal() {
            let escopoLocalInterno = 'local';
            console.log(escopoLocalInterno);
        }

        //console.log(escopoLocalInterno); -> Erro variavel esta dentro do escopa da função e so pode ser usada lá.

        escopoLocal();

    // atribuição
        var atribuicao = 'marco';
    
    // comparação
        var comparacao = '0' == 0;
        console.log(comparacao);
    
    // comparação identica
        var comparacaoIdentica = '0' === 0;
        console.log(comparacaoIdentica);

    // adição
        var adicao = 1 + 1;
        console.log(2);
    
    // subtração 
        var subtracao = 2 - 1;
        console.log(subtracao);
    
    // multiplicação
        var multiplicacao = 2 + 3;
        console.log(multiplicacao);

    // divisão real
        var divisaoReal = 6 / 2;
        console.log(divisaoReal);
    
    // divisão inteira
       var divisaoInteira = 5 % 2;
       console.log(divisaoInteira);

    // potenciação
        var potenciacao = 2 ** 10;
        console.log(potenciacao);

    // maior que
        var maiorQue = 5 > 2;
        console.log(maiorQue);
    
    // menor que
        var menorQue = 5 < 2;
        console.log(menorQue);
    
    // maior ou igual a 
        var maiorOuIgual = 5 >= 2;
        console.log(maiorOuIgual);
    
    // menor ou igual a
        var menorOuIgual = 5 <= 2;
        console.log(menorOuIgual);
    
    // operadores logicos
        var e = true && true;
        console.log(e);

        var ou = true || false;
        console.log(ou);

        var nao = !true;
        console.log(nao);
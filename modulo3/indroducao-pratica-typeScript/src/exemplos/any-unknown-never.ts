let anyEstaDeVolta: any;
anyEstaDeVolta = 3;
anyEstaDeVolta = 'teste';
anyEstaDeVolta = 5;

let stringTeste: string = 'verificar';
stringTeste = anyEstaDeVolta;

let unknownValor: unknown;
unknownValor = 3;
unknownValor = 'opa';
unknownValor = true;
unknownValor = 'vai sim';

let stringTeste2: string = 'agora vai';
//stringTeste2 = unknownValor;

if(typeof unknownValor === 'string') {
    stringTeste2 = unknownValor;
}

function jogaErro(erro: string, codigo: number): never {
    throw {erro: erro, code: codigo};
}

jogaErro('deu erro', 500);
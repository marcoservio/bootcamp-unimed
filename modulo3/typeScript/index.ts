function soma(a: number, b: number) {
    return a + b;
}

soma(1, 1);

// types
// interfaces
interface IAnimal {
    nome: string;
    tipo: 'terrestre' | 'aquático';
    executarRugido(alturaEmDecibeis: number): void;
    domestico: boolean;
}

interface IFelino extends IAnimal {
    visaoNoturna: boolean;
}

interface ICanino extends IAnimal {
    porte: 'pequeno' | 'medio' | 'grande';
}

type IDomestico = IFelino | ICanino;

const animal: IDomestico = {
    nome: 'cachorro',
    tipo: 'terrestre',
    domestico: true,
    porte: 'pequeno',
    executarRugido: (alturaEmDecibeis) => (`${alturaEmDecibeis}dB`)
}

animal.executarRugido(10);

const felino: IFelino = {
    nome: 'Leão',
    tipo: 'terrestre',
    visaoNoturna: true,
    domestico: false,
    executarRugido: (alturaEmDecibeis) => (`${alturaEmDecibeis}dB`),    
}

const input = document.getElementById('input') as HTMLInputElement;

input.addEventListener('input', (event) => {
    console.log('Digitei');
    const i = event.currentTarget as HTMLInputElement;
    console.log(i.value);
});

// Generic types

function adicionaApendiceALista<T>(array: T[], valor: T) {
    return array.map(() => valor);
}

adicionaApendiceALista(['1', '2', 3], '1');

interface IUsuario {
    id: string;
    email: string;
    cargo?: 'gerente' | 'coordenador' | 'supervisor' | 'funcionario';
}

function redirecione(usuario: IUsuario) {
    if(usuario.cargo) {
        // redirecionar(usuario.cargo);
    }

    // redirecionar para a area do usuario;
}

interface ICachorro {
    nome: string;
    idade: number;
    parqueFavorito?: string;
}

type CachorroSomenteLeitura = {
    +readonly [K in keyof ICachorro]-? : ICachorro[K];
}

class MeuCachorro implements CachorroSomenteLeitura {
    idade;
    nome;
    parqueFavorito;

    constructor(nome, idade) {
        this.idade = idade;
        this.nome = nome;
    }
}

const cao = new MeuCachorro('Apolo', '14');
cao.idade = 8;

console.log(cao);

import $ from 'jquery';

$.fn.extends({
    novaFuncao() {
        console.log('Chamou nova funcao');
    }
});

$('body').novaFuncao();
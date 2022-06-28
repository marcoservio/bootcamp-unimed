const pessoa = {
    nome: 'Mariana',
    idade: 28,
    profissao: 'Desenvolvedora'
}

pessoa.idade = 29;

const andre: {nome: string, idade: number, profissao: string} = {
    nome: 'Andre',
    idade: 25,
    profissao: 'Pintor'
} 

const paula: {nome: string, idade: number, profissao: string} = {
    nome: 'Paula',
    idade: 25,
    profissao: 'Desenvolvedora'
} 

enum Profissao {
    Professora,
    Atriz,
    Desenvolvedora,
    JogadoraDeFutebol
}

interface Pessoa {
    nome: string,
    idade: number,
    profissao?: Profissao
}

interface Estudante extends Pessoa {
    materias: string[]
}

const vanessa : Pessoa = {
    nome: 'Vanessa',
    idade: 23,
    profissao: Profissao.Professora
}

const Maria : Pessoa = {
    nome: 'Maria',
    idade: 23,
    profissao: Profissao.Desenvolvedora
}

const jessica : Estudante = {
    nome: 'Jessica',
    idade: 25,
    profissao: Profissao.Desenvolvedora,
    materias: ['Matematica discreta', 'Programação']
}

const monica : Estudante = {
    nome: 'Monica',
    idade: 25,
    materias: ['Matematica discreta', 'Programação']
}

function listar(lista: string[]) {
    for(const i of lista) {
        console.log(' - ', i);
    }
}

listar(monica.materias);
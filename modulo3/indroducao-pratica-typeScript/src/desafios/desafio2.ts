// Como podemos melhorar o esse código usando TS? 

enum Prof {
    Padeiro,
    Atriz,
    Desenvolvedora
}

interface Person {
    nome: string,
    idade: number,
    prof: Prof
}

let person1 : Person = {
    nome: "maria",
    idade: 29,
    prof: Prof.Atriz
};
person1.nome = "Maria";
person1.idade = 29;
person1.prof = Prof.Atriz;

let pessoa2 : Person = {nome: "reberto", idade: 19, prof: Prof.Padeiro };
pessoa2.nome = "roberto";
pessoa2.idade = 19;
pessoa2.prof = Prof.Padeiro;

let pessoa3 : Person = {
    nome: "laura",
    idade: 32,
    prof: Prof.Atriz
};

let pessoa4 : Person = {
    nome: "carlos",
    idade: 19,
    prof: Prof.Padeiro
}
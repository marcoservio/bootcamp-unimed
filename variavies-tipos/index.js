// Let -> escopo de bloco -> usar sempre let

numberOne = 1; // -> Hoisting

console.log(numberOne + 2);

var numberOne;

var firstName = "João";
var lastName = "Souza";

if(firstName === "João") {
    let lastName = "Rodrigues";
    var firstName = "Pedro";
    lastName = "Silva";

    console.log(lastName);
}

console.log(firstName, lastName);

const FRIST_NAME = "Marco";


// var -> escopo global ou local
//        pode redeclara
//        pode reatribuir
//        faz hoisting

// let -> escopo bloco
//        não redeclara
//        pode reatribuir
//        não faz hoisting

// const -> escopo bloco
//          não redeclara
//          não reatribuir
//          não faz hoisting
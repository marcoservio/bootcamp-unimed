type input = number | string;

function somaValores(input1: input, input2: input) {
    if(typeof input1 === "string" || typeof input2 === "string") {
        return input1.toString() + input2.toString();
    }

    return input1 + input2;
}

console.log(somaValores(1, 5));
console.log(somaValores('ola ', ', tudo bem?'));
console.log(somaValores('que dia é hoje? ', 5));
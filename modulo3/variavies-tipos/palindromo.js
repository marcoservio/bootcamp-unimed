// solução 1
function verificaPalindromo(str) {
    if(!str) return "string inexistente";

    return str.split("").reverse().join("") === str;
}

console.log(verificaPalindromo("ovo"));

// solução 2
function verificaPalindromo2(str) {
    if(!str) return "string inexistente";

    for(let i = 0; i < str.lenght / 2; i++) {
        if(str[i] !== str[str.lenght - 1 - i]) {
            return false;
        }
    }

    return true;
}

console.log(verificaPalindromo2("abba"));
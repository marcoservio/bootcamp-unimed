// o que são vetores ou arrays

    // como declarar um array
        let array = ['string', 1, true];
        console.log(array);

    // pode guardar varios tipos de dados
        let arrayTipos = ['string', 1, true, ['array1'], ['array2'], ['array3'], ['array4']];
        console.log(arrayTipos);
        console.log(arrayTipos[0]);
        console.log(arrayTipos[3]);
    
    // forEach
        arrayTipos.forEach(function(item, index){console.log(item, index)})

    // push -> adiciona no final do array
        arrayTipos.push('novo item');
        arrayTipos.push(1);
        arrayTipos.push([]);
        console.log(arrayTipos);

    // pop -> remove no final do array
        arrayTipos.pop();
        console.log(arrayTipos);
    
    // shift -> remove no inicio do array 
        arrayTipos.shift();
        console.log(arrayTipos);

    // unshift -> adiciona um item no incio do array
        arrayTipos.unshift('novo item no inicio');
        console.log(arrayTipos);
    
    // indexOf -> retorna o index dentro do array
        console.log(arrayTipos.indexOf(true));

    // splice -> remove ou substitui o item por indice
        arrayTipos.splice(0, 3);
        console.log(arrayTipos);

    // slice -> retorna uma parte do array existente
        let novoArray = arrayTipos.slice(0, 3);
        console.log(novoArray);
    
    // object
        let object = { string: 'string', number: 1, boolean: true, array: ['array'], 
        objectInterno: {objectInterno: 'objeto interno'}};
        console.log(object);
        console.log(object.boolean);
        console.log(object.objectInterno);

        var string = object.string;
        console.log(string);

        var arrayObj = object.array;
        console.log(arrayObj);

        var {string, boolean, objectInterno} = object;
        console.log(string, boolean, objectInterno);
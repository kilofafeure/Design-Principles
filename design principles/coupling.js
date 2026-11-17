// Acoplamiento: grado de dependencia entre módulos o clases; cuanto menor, más independientes son.
class Beer {

    constructor(quantity){
        this.quantity = quantity;
    }

    empty(ml){
        if (this.quantity <= 0){
            return;
        }

        this.quantity -= ml;
    }
}

// Person está acoplada a la API de Beer: drink() necesita que beer implemente empty(ml).
// Si el API cambia, también habría que adaptar Person; cualquier otro objeto usado en su lugar debe cumplir el mismo contrato.
class Person {
    constructor (beer) {
        this.beer = beer;
    }

    drink() {
        this.beer.empty(10);
    }

}

const erdinger = new Beer(100);
const juan = new Person(erdinger);
// Your Aren't Gonna Need It

const products = [
    { name: "Product 1", price: 10, quantity: 2 },
    { name: "Product 2", price: 20, quantity: 1 },
    { name: "Product 3", price: 15, quantity: 3 },
];

// Sin YAGNI
function calculateTotalPrice(items) {
    let total = 0;

    for (let item of items) {
        let discount = 0;

        if (item.hasDiscount) {
             discount = item.price * item.quantity * 0.1;
        }

        if (item.type == "foreign") {
            total += item.price * item.quantity * 1.2 - discount;
            continue;
        }   

        total += item.price * item.quantity - discount;
    }

    return total;

}

console.log(calculateTotalPrice(products));

// Con YAGNI
function calculateTotalPriceWithYAGNI(items) {
    let total = 0;

    for (let item of items) {
        total += item.price * item.quantity;
    }

    return total;
}

console.log(calculateTotalPriceWithYAGNI(products));

// COn YAGNI y reduce
function calculateTotalPriceWithYAGNIReduce(items){
    return items.reduce((total, item) => total + item.price * item.quantity , 0);
}

console.log(calculateTotalPriceWithYAGNIReduce(products))
// Don't Repeat Yourself

// Sin DRY
function calculateProduct(price) {
    const tax = price * 0.15;
    const total = price + tax;
    return total;
}

function calculateSale(products) {
    let totalSale = 0;

    for (let i = 0; i < products.length; i++) {
        const tax = products[i].price * 0.15;
        totalSale += products[i].price + tax;
    }

    return totalSale;
}

console.log(calculateProduct(100));
products = [{ price: 100 }, { price: 200 }];
console.log(calculateSale(products));

// Con DRY
function addTax(price) {
     return price + (price * 0.15);
}

function calculateProductDRY(price) {
    return addTax(price);
}

function calculateSaleDRY(products) {
    let totalSale = 0;

    for (let i = 0; i < products.length; i++) {
        totalSale += addTax(products[i].price);
    }   

    return totalSale;
}

console.log(calculateProductDRY(100));
products = [{ price: 100 }, { price: 200 }];
console.log(calculateSaleDRY(products));
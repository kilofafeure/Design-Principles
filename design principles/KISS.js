// Keep It Simple, Stupid

// Ejemplo 1 *****************************************************

// Sin aplicar KISS
function isAdult(age) {

    let result;

    if (age >= 18) {
        result = true;
    } else {
        result = false;
    }

    return result;
}

console.log(isAdult(20)); 

// Aplicando KISS
function isAdultWithKISS(age) {
    return age >= 18;
}

console.log(isAdultWithKISS(15));

// Ejemplo 2 *****************************************************

// Sin aplicar KISS
function getCity(user) {
    
   if (user) {
        if (user.address ) {
            if (user.address.city ) {
                return user.address.city;
            }
        }
   }
}

const user = { 
    name: 'Juan',
    address: {
        city: 'CDMX'
    }
}
console.log(getCity(user));

// Aplicando KISS
function getCityWithKISS(user) {
    if (user?.address?.city) {
        return user.address.city;
    }

    return "Sin ciudad";
}

console.log(getCityWithKISS(user));
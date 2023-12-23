let products = ["samsung", "iphone", "huawei"];


let result;

result = products.toString(); // stringe çevirir
console.log(result);
result = products.join(" / "); // stringe çevirir
console.log(result);
result = products.indexOf("iphone"); // index numarasını verir
console.log(result);
result = products.includes("iphone"); // true false döner
console.log(result);
result = products.push("xiaomi"); // sona ekler
console.log(result);
result = products.pop(); // sondan siler
console.log(result);
result = products.unshift("xiaomi"); // başa ekler
console.log(result);
result = products.shift(); // baştan siler
console.log(result);
result = products.reverse(); // ters çevirir
console.log(result);
result = products.sort(); // alfabetik sıralar
console.log(result);
result = products.concat(["xiaomi", "asus"]); // birleştirir
console.log(result);
result = products.slice(0, 2); // 0. indexten 2. indexe kadar alır
console.log(result);
result = products.splice(0, 2, "xiaomi", "asus"); // 0. indexten 2. indexe kadar siler ve yerine xiaomi ve asus ekler
console.log(result);
result = products.map(function (product) { // her bir elemanı dolaşır
    return product + " 1";
});
console.log(result);

console.log(products)
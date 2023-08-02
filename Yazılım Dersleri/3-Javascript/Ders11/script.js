const username = "admin";
const yas = 30;

let result;


result = 25;
result = "25";
result = Number("25");
result = parseFloat("25.5");
result = parseInt("25.5");
result = parseInt("a27");
result = isNaN("27");
result = isNaN("a27");

let myNumber = 10.65548;
result = myNumber.toPrecision(3);
console.log(result);
result = myNumber.toFixed(2);
console.log(result);
result = Math.PI;
console.log(result);
result = Math.round(2.4);
console.log(result);
result = Math.round(2.7);
console.log(result);
result = Math.ceil(2.1);
console.log(result);
result = Math.floor(2.9);
console.log(result);
result = Math.sqrt(16);
console.log(result);
result = Math.pow(2, 4);
console.log(result);
result = Math.abs(-100);
console.log(result);
result = Math.min(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
console.log(result);
result = Math.max(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
console.log(result);
result = Math.random();
console.log(result);
result = Math.floor(Math.random() * 100 + 1);
console.log(result);
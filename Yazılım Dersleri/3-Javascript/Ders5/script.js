let number1 = 10;
let number2 = 20;
let number3 = 30;
let result;


// 1- Aritmetik Operatörler
//? +, -, *, /, %, ++, --

result = number1 + number2;
console.log(result)
result = number1 - number2;
console.log(result)
result = number1 * number2;
console.log(result)
result = number1 / number2;
console.log(result)
result = number1 % number2;
console.log(result)
result = number1++;
console.log(result)
result = ++number1;
console.log(result)
result = number1--;
console.log(result)
result = --number1;
console.log(result)
// 2- Atama Operatörleri
//? =, +=, -=, *=, /=, %=
result = null;
result += number1;
console.log(result)
result -= number1;
console.log(result)
result *= number1;
console.log(result)
result /= number1;
console.log(result)
result %= number1;
console.log(result)

// 3- Karşılaştırma Operatörleri
//? ==, ===, !=, !==, >, <, >=, <=
result = null;
result = number1 == number2;
console.log(result)
result = number1 === number2;
console.log(result)
result = number1 != number2;
console.log(result)
result = number1 !== number2;
console.log(result)
result = number1 > number2;
console.log(result)
result = number1 < number2;
console.log(result)
result = number1 >= number2;
console.log(result)
result = number1 <= number2;
console.log(result)

// 4- Mantıksal Operatörler
//? &&, ||, !
result = null;
result = number1 < number2 && number1 < number3;
console.log(result)
result = number1 < number2 || number1 < number3;
console.log(result)
result = !(number1 < number2);
console.log(result)
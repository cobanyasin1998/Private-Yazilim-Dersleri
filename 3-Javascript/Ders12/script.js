let tarih = new Date();
console.log(tarih);

let result;
result = tarih.getDate(); // gün bilgisini verir
console.log(result);
result = tarih.getDay(); //0-6 arası değer döner 0 pazar 6 cumartesi
console.log(result);
result = tarih.getFullYear(); // yıl bilgisini verir
console.log(result);
result = tarih.getHours(); // saat bilgisini verir
console.log(result);
result = tarih.getMinutes(); // dakika bilgisini verir
console.log(result);
result = tarih.getMonth(); // ay bilgisini verir  0-11 arası değer döner
console.log(result);
result = tarih.getSeconds(); // saniye bilgisini verir
console.log(result);
result = tarih.getTime(); // milisaniye cinsinden tarih bilgisini verir
console.log(result);
result = tarih.getMilliseconds();
console.log(result);
result = tarih.setFullYear(2021);
console.log(result);
result = tarih.setHours(12);
console.log(result);
result = tarih.setMinutes(30);
console.log(result);
result = tarih.setSeconds(30);
console.log(result);
result = tarih.setMilliseconds(100);
console.log(result);
result = tarih.setMonth(11);
console.log(result);
result = tarih.setDate(25);
console.log(result);
result = tarih.setFullYear(2021, 11, 25);
console.log(result);
result = tarih.setHours(12, 30, 30, 100);
console.log(result);
result = tarih.setMinutes(30);
console.log(result);
result = tarih.setSeconds(30);
console.log(result);
result = tarih.setMilliseconds(100);
console.log(result);
result = tarih.setMonth(11);
console.log(result);
/*
Öğrenci Bilgileri

1. Öğrenci
Adı: Mehmet
Soyadı: Yılmaz
Doğum Yılı: 1990
Bilgisayar Notları:100, 90, 10

2. Öğrenci
Adı: Eylül
Soyadı: Yılmaz
Doğum Yılı: 1995
Bilgisayar Notları:30, 60, 50

Geçer Not:45



Program Şartları:
1. Öğrenci Yaşlarının Ekrana Yazdırma
2. Öğrencilerin Ortalamalarını Ekrana Yazdırma
3. Öğrencilerin Ortalamalarının Geçer Not Olup Olmadığını Ekrana Yazdırma



*/

let suankiYil = new Date().getFullYear();

let ogr1 = "Mehmet Yılmaz";
let ogr1Yas = suankiYil - 1990;
let ogr1BilgisayarNotlari = [100, 90, 10];

let ogr2 = "Eylül Yılmaz";
let ogr2DogumYili = suankiYil - 1995;
let ogr2BilgisayarNotlari = [30, 60, 50];


//1. Öğrenci Yaşlarının Ekrana Yazdırma

console.log(ogr1 + " Yaşı: " + ogr1Yas);
console.log(ogr2 + " Yaşı: " + ogr2DogumYili);

//2. Öğrencilerin Ortalamalarını Ekrana Yazdırma

let ogr1Ortalama = (ogr1BilgisayarNotlari[0] + ogr1BilgisayarNotlari[1] + ogr1BilgisayarNotlari[2]) / 3;
let ogr2Ortalama = (ogr2BilgisayarNotlari[0] + ogr2BilgisayarNotlari[1] + ogr2BilgisayarNotlari[2]) / 3;

console.log(ogr1 + " Ortalaması: " + ogr1Ortalama);
console.log(ogr2 + " Ortalaması: " + ogr2Ortalama);

//3. Öğrencilerin Ortalamalarının Geçer Not Olup Olmadığını Ekrana Yazdırma

let gecerNot = 45;

ogr1Ortalama >= gecerNot ? console.log(ogr1 + " Geçti") : console.log(ogr1 + " Kaldı");
ogr2Ortalama >= gecerNot ? console.log(ogr2 + " Geçti") : console.log(ogr2 + " Kaldı");
const ad = "Yasin";
const soyad = "Çoban";
const yas = 25;
const sehir = "Ankara";
const meslek = "Mühendis";

const bio = "Benim adım " + ad + " " + soyad + ", " + yas + " yaşındayım. Mesleğim " + meslek + ". Şehrim " + sehir + ".";

const bioBacktick = `Benim adım ${ad} ${soyad}, ${yas} yaşındayım. Mesleğim ${meslek}. Şehrim ${sehir}.`;

console.log(bio);
console.log(bioBacktick);
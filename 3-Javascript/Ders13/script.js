const urun1 = "samsung";
const urun2 = "iphone";
const urun3 = "huawei";
console.log(urun1);
console.log(urun2);
console.log(urun3);
const urunler = ["samsung", "iphone", "huawei"];

console.log("<ul>");
for (let i = 0; i < urunler.length; i++) {
    console.log("<li>" + urunler[i] + "</li>");
}
console.log("</ul>");

const yeniUrunler = ["samsung", "iphone", ["huawei", "xiaomi", "asus"]];
console.log("<ul>");
for (let i = 0; i < yeniUrunler.length; i++) {
    console.log("<li>" + yeniUrunler[i] + "</li>");
}
console.log("</ul>");
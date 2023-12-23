function updateElement(id, value) {
  document.getElementById(id).textContent = value;
}

function getYilbasinaKalanTarih() {
  var simdikiTarih = new Date();
  var yeniYil = new Date(simdikiTarih.getFullYear() + 1, 0, 1, 0, 0, 0); // Bir sonraki yılbaşı

  var kalanSure = Math.floor((yeniYil - simdikiTarih) / 1000); // Saniye cinsinden kalan süre

  var kalanGun = Math.floor(kalanSure / (24 * 60 * 60));
  var kalanSaat = Math.floor((kalanSure % (24 * 60 * 60)) / 3600);
  var kalanDakika = Math.floor((kalanSure % 3600) / 60);
  var kalanSaniye = kalanSure % 60;

  updateElement("gunText", kalanGun);
  updateElement("saatText", kalanSaat);
  updateElement("dakikaText", kalanDakika);
  updateElement("saniyeText", kalanSaniye);
}
setInterval(getYilbasinaKalanTarih, 1000);
getYilbasinaKalanTarih();

function createSnowFlake() {
  const snow_flake = document.createElement("i");
  snow_flake.classList.add("fas");
  snow_flake.classList.add("fa-snowflake");
  snow_flake.style.left = Math.random() * window.innerWidth + "px";
  snow_flake.style.animationDuration = Math.random() * 3 + 2 + "s"; // between 2 - 5 seconds
  snow_flake.style.opacity = Math.random();
  snow_flake.style.fontSize = Math.random() * 10 + 10 + "px";

  document.body.appendChild(snow_flake);

  setTimeout(() => {
    snow_flake.remove();
  }, 5000);
}
setInterval(createSnowFlake, 50);

var models = [
  {
    name: "Polo",
    image: "img/1.jpg",
    link: "https://www.arabam.com/ilan/sahibinden-satilik-volkswagen-polo-1-6-tdi-comfortline/sahibinden-volkswagen-polo-1-6-tdi-comfortline-2012-model/20766505",
  },
  {
    name: "Mustang",
    image: "img/2.jpg",
    link: "https://www.arabam.com/ilan/sahibinden-satilik-volkswagen-polo-1-6-tdi-comfortline/sahibinden-volkswagen-polo-1-6-tdi-comfortline-2012-model/20766505",
  },
  {
    name: "Lamborgini",
    image: "img/3.jpg",
    link: "https://www.arabam.com/ilan/sahibinden-satilik-volkswagen-polo-1-6-tdi-comfortline/sahibinden-volkswagen-polo-1-6-tdi-comfortline-2012-model/20766505",
  },
  {
    name: "Lada",
    image: "img/4.jpg",
    link: "https://www.arabam.com/ilan/sahibinden-satilik-volkswagen-polo-1-6-tdi-comfortline/sahibinden-volkswagen-polo-1-6-tdi-comfortline-2012-model/20766505",
  },
  {
    name: "Bmw",
    image: "img/5.jpg",
    link: "https://www.arabam.com/ilan/sahibinden-satilik-volkswagen-polo-1-6-tdi-comfortline/sahibinden-volkswagen-polo-1-6-tdi-comfortline-2012-model/20766505",
  },
];

var index = 0;
var slaytCount = models.length;
var interval;
var settings = {
  duration: 1000,
  random: false,
};
init(settings);

document
  .querySelector(".fa-arrow-circle-left")
  .addEventListener("click", function () {
    index--;
    showSlide(index);
  });

document
  .querySelector(".fa-arrow-circle-right")
  .addEventListener("click", function () {
    index++;

    showSlide(index);
  });

document.querySelectorAll(".arrowSlider").forEach(function (item) {
  item.addEventListener("mouseenter", function () {
    clearInterval(interval);
  });
});

document.querySelectorAll(".arrowSlider").forEach(function (item) {
  item.addEventListener("mouseleave", function () {
    init(settings);
  });
});

function init(settings) {
  var previous;

  interval = setInterval(function () {
    if (settings.random) {
      do {
        index = Math.floor(Math.random() * slaytCount);
      } while (index == previous);
      {
        prev = index;
      }
    } else {
      if (slaytCount == index + 1) {
        index = 0;
      }
      showSlide(index);
      index++;
    }
    showSlide(index);
  }, settings.duration);
}
function showSlide(i) {
  index = i;

  if (i < 0) {
    index = slaytCount - 1;
  }
  if (i >= slaytCount) {
    index = 0;
  }

  document
    .querySelector(".card-img-top")
    .setAttribute("src", models[index].image);
  document.querySelector(".card-text").textContent = models[index].name;
  document.querySelector(".card-link").setAttribute("href", models[index].link);
}

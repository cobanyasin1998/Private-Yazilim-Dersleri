const word_el = document.getElementById("word");
const popup = document.getElementById("popup-container");
const message_el = document.getElementById("success-message");
const wrongLetters_el = document.getElementById("wrong-letters");
const items = document.querySelectorAll(".item");
const message_wrong_el = document.getElementById("message");
const btn = document.getElementById('play-again');

function getRandomWord() {
  const words = ["JAVASCRIPT", "JAVA", "PYTHON"];
  return words[Math.floor(Math.random() * words.length)];
}

const correctLetters = [];
const wrongLetter = [];
let selectedWord = getRandomWord();

function displayWord() {
  word_el.innerHTML = `${selectedWord
    .split("")
    .map(
      (letter) => `<div class="letter">
      ${correctLetters.includes(letter) ? letter : ""}
      </div>`
    )
    .join("")}
      `;

  const w = word_el.innerText.replace(/\n/g, "");
  if (w == selectedWord) {
    popup.style.display = "flex";
    message_el.innerText = "Tebrikler. Kazandınız";
  }
}
function displayMessage() {
  message_wrong_el.classList.add("show");
  setTimeout(() => {
    message_wrong_el.classList.remove("show");
  }, 1000);
}

btn.addEventListener('click',function(){
  correctLetters.splice(0);
  wrongLetter.splice(0);
  selectedWord = getRandomWord();
  displayWord();
  updateWrongLetters();
  popup.style.display = 'none';
});

window.addEventListener("keydown", function (e) {
  if (e.keyCode >= 65 && e.keyCode <= 90) {
    const letter = e.key;
    if (selectedWord.includes(letter)) {
      if (!correctLetters.includes(letter)) {
        correctLetters.push(letter);
        displayWord();
      } else {
        displayMessage();
      }
    } else {
      if (!wrongLetter.includes(letter)) {
        wrongLetter.push(letter);
        updateWrongLetters();
      } else {
        displayMessage();
      }
    }
  }
});
function updateWrongLetters() {
  wrongLetters_el.innerHTML = `
  
  ${wrongLetter.length > 0 ? "<h3>Hatalı Harfler</h3>" : ""}
  ${wrongLetter.map((letter) => `<span>${letter}</span>`)}

  `;

  items.forEach((item, index) => {
    const errorCount = wrongLetter.length;
    if (index < errorCount) {
      item.style.display = "block";
    } else {
      item.style.display = "none";
    }
  });

  if (wrongLetter.length === items.length) {
    popup.style.display = "flex";
    message_el.innerText = "Maalesef Kaybettiniz.";
  }
}
displayWord();

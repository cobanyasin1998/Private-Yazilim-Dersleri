const generatePassBtn = document.getElementById("generatePassword");
const textPass = document.getElementById("result-password");
const includeUpperCaseLetters = document.getElementById("incUpperCase");
const includeLowerCaseLetters = document.getElementById("incLowerCase");
const includeNumbers = document.getElementById("incNumbers");
const includeSymbols = document.getElementById("incSymbols");
const inputPasswordLength = document.getElementById("passLength");

includeUpperCaseLetters.checked = true;
includeLowerCaseLetters.checked = true;
inputPasswordLength.value = 12;
const randomFunc = {
  lower: getRandomLower,
  upper: getRandomUpper,
  number: getRandomNumber,
  symbol: getRandomSymbol,
};
copyPassword.addEventListener("click", () => {
  const textarea = document.createElement("textarea");
  const password = textPass.innerText;

  if (!password) {
    return;
  }

  textarea.value = password;
  document.body.appendChild(textarea);
  textarea.select();
  document.execCommand("copy");
  textarea.remove();
  alert("Password copied to clipboard");
});
generatePassBtn.addEventListener("click", () => {
  const length = +inputPasswordLength.value;
  const hasLower = includeLowerCaseLetters.checked;
  const hasUpper = includeUpperCaseLetters.checked;
  const hasNumber = includeNumbers.checked;
  const hasSymbol = includeSymbols.checked;

  textPass.innerText = generatePassword(
    hasLower,
    hasUpper,
    hasNumber,
    hasSymbol,
    length
  );
});
function generatePassword(lower, upper, number, symbol, length) {
  let generatedPassword = "";
  const typesCount = lower + upper + number + symbol;
  const typesArr = [{ lower }, { upper }, { number }, { symbol }].filter(
    (item) => Object.values(item)[0]
  );

  // Doesn't have a selected type
  if (typesCount === 0) {
    return "";
  }

  // create a loop
  for (let i = 0; i < length; i += typesCount) {
    typesArr.forEach((type) => {
      const funcName = Object.keys(type)[0];
      generatedPassword += randomFunc[funcName]();
    });
  }

  const finalPassword = generatedPassword.slice(0, length);

  return finalPassword;
}
function getRandomLower() {
  return String.fromCharCode(Math.floor(Math.random() * 26) + 97);
}

function getRandomUpper() {
  return String.fromCharCode(Math.floor(Math.random() * 26) + 65);
}

function getRandomNumber() {
  return +String.fromCharCode(Math.floor(Math.random() * 10) + 48);
}

function getRandomSymbol() {
  const symbols = "!@#$%^&*(){}[]=<>/,.";
  return symbols[Math.floor(Math.random() * symbols.length)];
}

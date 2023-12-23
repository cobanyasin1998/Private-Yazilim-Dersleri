function sayHello(name, callBack) {
    console.log(`Hello ${name}!`);
    callBack();
}

function goodBye() {
    console.log(`Good Bye`);
}
sayHello("Yasin", goodBye);


//Ajax ve Http İstekleri

const xhr = new XMLHttpRequest();
xhr.open("GET", "https://jsonplaceholder.typicode.com/users");
xhr.send();
xhr.onload = function () {
    if (xhr.status === 200) {
        console.log(JSON.parse(xhr.response));
    } else {
        console.log("Bir hata oluştu");
    }
}


// Promise
const number = Math.floor(Math.random() * 10);
if (number % 2 === 0) {
    console.log("Sayı çift");
} else {
    console.log("Sayı tek");
}

function getRandomNumber() {
    return new Promise((resolve, reject) => {
        const number = Math.floor(Math.random() * 10);
        if (number % 2 === 0) {
            resolve(number);
        } else {
            reject(number);
        }
    });
}
getRandomNumber().then((data) => {
    console.log(`Sayı ${data} çifttir`);
}).catch((data) => {

    console.log(`Sayı ${data} tektir`);
});

!!Fetch

fetch("https://jsonplaceholder.typicode.com/users")
    .then((response) => response.json())
    .then((data) => console.log(data))
    .catch((err) => console.log(err));

// Async - Await

async function test(data) {
    let promise = new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve("Bu bir değerdir");
        }, 5000);
    });
    let response = await promise;
    console.log(response);
    console.log("Naber");
    return "Merhaba";
}
test("Merhaba").then((data) => console.log(data));
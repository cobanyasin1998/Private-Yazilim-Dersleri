let araba = {
    renk: "kırmızı",
    hiz: 100,
    hizArttir: function (deger) {
        this.hiz += deger;
    }
};


console.log(araba.renk);
console.log(araba.hiz);
araba.hizArttir(30);
console.log(araba.hiz);


// function Araba(renk, hiz) {
//     this.renk = renk;
//     this.hiz = hiz;

// }
// Araba.prototype.hizlandir = function (deger) {
//     this.hiz += deger;
// }

// const araba1 = new Araba("kırmızı", 100);
// const araba2 = new Araba("mavi", 120);

// console.log(araba1.renk);
// console.log(araba1.hiz);
// araba1.hizlandir(30);
// console.log(araba1.hiz);

// console.log(araba2.renk);
// console.log(araba2.hiz);
// araba2.hizlandir(30);
// console.log(araba2.hiz);



//ES6 


// class Araba {
//     constructor(renk, hiz) {
//         this.renk = renk;
//         this.hiz = hiz;
//     }
//     hizlandir(deger) {
//         this.hiz += deger;
//     }
// }

// let araba1 = new Araba("kırmızı", 100);

// console.log(araba1.renk);
// console.log(araba1.hiz);
// araba1.hizlandir(30);
// console.log(araba1.hiz);


//Inheritance

class Araba {
    constructor(renk) {
        this.renk = renk;
    }
}

class Otomobil extends Araba {
    constructor(renk, hiz) {
        super(renk);
        this.hiz = hiz;
    }
    hizlandir(deger) {
        this.hiz += deger;
    }
}

let araba1 = new Otomobil("kırmızı", 100);

console.log(araba1.renk);
console.log(araba1.hiz);
araba1.hizlandir(30);
console.log(araba1.hiz);

//Encapsulation

class Araba {
    _renk;
    constructor(renk) {
        this._renk = renk;
    }
    set renk(value) {
        this._renk = value;
    }
    get renk() {
        return this._renk;
    }
}

let araba2 = new Araba("kırmızı");

console.log(araba2.renk);
araba2.renk = "mavi";
console.log(araba2.renk);
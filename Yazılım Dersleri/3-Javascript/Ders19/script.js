var kullanici = "global scope:Yasin";

function scopeTest() {
    var kullanici = "local scope:Yasin";
    console.log(kullanici);
}

scopeTest();
console.log(kullanici); {
    var k = 10; {
        var k = 20; {
            var k = 30;
            console.log(k);
        }
        console.log(k);
    }
    console.log(k);
}
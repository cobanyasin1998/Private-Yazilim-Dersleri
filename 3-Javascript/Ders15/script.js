let customers = ["yasin", "ali", "veli", "ahmet", "mehmet"];

customers.push("hasan");

console.log(customers)


//dizinin ilk elemanı
console.log(customers[0])

//dizinin son elemanı
console.log(customers[customers.length - 1])


let customer1 = ["yasin", ["asus", "lenovo", "hp"],
    [10, 20, 30]
]
console.log(`Ürün: ${customer1[1][0]} Fiyat: ${customer1[2][0]}`)
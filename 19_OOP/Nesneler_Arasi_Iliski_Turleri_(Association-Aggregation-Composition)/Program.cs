
//Nesneler Arası İlişki Türleri (Association-Aggregation-Composition)


//is -a ilişkisi (inheritance) : miras alma
//is - a ilişkisi tamamıyla kalıtımla alakalıdır. C# programlama dilinde, iki sınıf
//arasında : operatorü ile gerçekleştirilen kalıtım işlemi ile is - a ilişkisi kurulur.
//Opel is a Araba
class Araba
{

}
class Opel : Araba
{

}

//has - a ilişkisi (composition) : bir nesne başka bir nesneyi içerir
//Bir sınıfın başka bir sınıfın nesnesine dair sahiplik ifadesinde bulunan ilişkidir. Bir yandan kompoziyon/composition ilişkisi de denmektedir.

//Misal Opel has a Motor
//Volvo bir arabadır. (is - a ilişkisi)
//Volvo'ın bir Motor'u vardır. (has - a ilişkisi)

class Arac
{

}
class Volvo : Arac
{
    Motor motor;
}
class Motor
{

}

//Sekreter bir personeldir. (is - a ilişkisi)
//Sekreter'in bir bilgisayarı vardır. (has - a ilişkisi)


class Personel
{

}
class Sekreter : Personel
{
    Bilgisayar bilgisayar;
}
class Bilgisayar
{

}

//Kadın bir insan'dır. (is - a ilişkisi)
//Kadın'ın bir saç rengi vardır. (has - a ilişkisi)

class Insan
{

}
class Kadin : Insan
{
    SacRengi sacRengi;
}
class SacRengi
{

}


//can - do ilişkisi (aggregation)
//Sonraki derslerimizde göreceğimiz interface yapılanmasının getirisi olan bir ilişki türüdür.
//Tabi ki de can -do ilişkisini anlayabilmek interface yapılanmasını anlamak gerekir.

//Interface'ler içlerindeki memberların imzalarını class'lara uygulattırdığından dolayı o interface'ler ilgili nesnelerin yapabilecekleri kabiliyetlerini göstermektedir.
//Yani can - do ilişkisi, bir nesnenin yapabileceklerini gösteren bir ilişki türüdür.
//Bu davranış/ kabiliyetlerin nesneler tarafından uygulanması ise interface'lerin görevidir.

interface IAraba
{
    void Gazla();
    void Frenle();
}
class BMW : IAraba
{
    public void Gazla()
    {
        Console.WriteLine("BMW Gazlandı");
    }
    public void Frenle()
    {
        Console.WriteLine("BMW Frenlendi");
    }
}




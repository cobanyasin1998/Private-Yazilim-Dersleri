

#region this Keyword'ü
//Bir sınıfın uygulamanın herhangi bir noktasında üretilmiş olan instance'larını/object'lerini/nesnelerini sınıf içerisinde temsil,
//içerisinde temsil etmemizi sağlayan bir keyword'dür.
//this keyword'ü bir sınıf içerisinde bulunan birden fazla constructor overload'ı arasında birbirlerini çağırmak için kullanılır.

MyClass myClass = new MyClass(5, "Merhaba");

#endregion

#region base Keyword'ü
//base keyword'ü bir sınıfın miras aldığı sınıfın constructor'larını çağırmak için kullanılır.

#endregion

#region readonly Keyword'ü

//readonly keyword'ü bir değişkenin ya tanımlanırken ya da  constructor içerisinde değer ataması yapılmasını sağlayan bir keyword'dür.
//const yapılanmalar, readonly yapılanmaların aksine tanımlanırken değer ataması yapılmalıdır.
#endregion

class MyClass
{
    public int MyProperty { get; set; }
    public MyClass()
    {
        Console.WriteLine("MyClass() constructor çalıştı.");
    }
    public MyClass(int a) : this()
    {
        Console.WriteLine("MyClass(a) constructor çalıştı.");
    }
    public MyClass(string b) : this()
    {
        Console.WriteLine("MyClass(b) constructor çalıştı.");
    }
    public MyClass(int a, string b) : this(a)
    {
        this.MyProperty = a;
        Console.WriteLine("MyClass(a,b) constructor çalıştı.");
    }
}

class MyClass2 : MyClass
{
    public MyClass2() : base()
    {
        base.MyProperty = 5;

    }
}
class MyClass3
{
    public readonly int MyProperty = 2;
    public MyClass3()
    {
        MyProperty = 5;
    }
    public void Method1()
    {
        //MyProperty = 5; -- HATA VERİR.
    }

}
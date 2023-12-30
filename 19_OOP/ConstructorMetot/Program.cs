


//Constructor (Yapıcı Metotlar)

MyClass myClass = new MyClass(); //Default Constructor metot çalışır
MyClass myClass2 = new MyClass(5); //Parametreli Constructor metot çalışır

//MyClass2 myClass3 = new MyClass2(); //Hata verir. Çünkü MyClass2 sınıfının Constructor metodu private olarak tanımlanmıştır.


new thisKeywordIleConstructorGecisler();
new thisKeywordIleConstructorGecisler(2);

class MyClass
{
    public MyClass()
    {
        //Default Constructor metot
    }
    public MyClass(int a)
    {
        //Parametreli Constructor metot
    }

}

public class MyClass2
{
    private MyClass2()
    {
        //Private Constructor metot
    }
    public void X()
    {
        new MyClass2(); //Bu şekilde çağırılabilir.
    }
}


class thisKeywordIleConstructorGecisler
{
    public thisKeywordIleConstructorGecisler()
    {
        Console.WriteLine("1. Constructor");


    }
    public thisKeywordIleConstructorGecisler(int a) : this()
    {
        Console.WriteLine("2. Constructor");

    }
    public thisKeywordIleConstructorGecisler(int a,int b) : this(a)
    {
        Console.WriteLine("3. Constructor");

    }
}
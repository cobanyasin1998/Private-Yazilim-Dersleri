

//Static Constructor


MyClass obj = new MyClass();
MyClass obj1 = new MyClass();


public class MyClass
{
    static MyClass()
    {
        //Static Constructor
       

        //Bu sınıftan nesne üretilirken ilk tetiklenecek olan constructor
        //Static Constructor sadece bir kere çalışır


        /*Önemli Not
         
         Static construct'ın tetiklenebilmesi için illa ilk nesne üretimi yapılmasına gerek yoktur. İlgili sınıf içerisinde herhangi bir static yapılanmanında tetiklenmesi static constructor'ın tetiklenmesi için yeterlidir.
         
         */
       
        Console.WriteLine("Static Constructor");
    }
    public MyClass()
    {
        //Instance Constructor
        //Bu sınıftan nesne üretilirken ilk tetiklenecek olan constructor
        Console.WriteLine("Instance Constructor");

    }
}
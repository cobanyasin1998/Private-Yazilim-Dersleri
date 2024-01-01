


D d = new D();

MyClass2 myClass = new MyClass2();


class BuyukBaba
{

}
class Baba : BuyukBaba
{

}
class Anne : Baba
{

}
class Cocuk :  Anne
{

}








class A
{
    public A()
    {
        Console.WriteLine("A");
    }
   
}
class B : A
{
    public B()
    {
        Console.WriteLine("B");
    }

}
class C : B
{
    public C()
    {
        Console.WriteLine("C");
    }
}
class D : C
{
    public D()
    {
        Console.WriteLine("D");
    }
}




class MyClass
{
    public MyClass(int a)
    {
        Console.WriteLine("MyClass");
    }
}
class MyClass2 : MyClass
{
    public MyClass2():base(5)
    {
        Console.WriteLine("MyClass2");
    }
}

class AClass
{
    int a;
    public int b;
    public int MyProperty { get; set; }
}
class BClass : AClass
{

    int c;
    public void X()
    {
        MyProperty = 123;
        this.b = 123;
    }
}
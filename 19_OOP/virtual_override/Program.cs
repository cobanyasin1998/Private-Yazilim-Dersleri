


//Sanal Yapılar
//Virtual - Override


MyDerivedClass myDerivedClass = new MyDerivedClass();
myDerivedClass.MyMethod();

MyDerivedClass2 myDerivedClass2 = new MyDerivedClass2();
myDerivedClass2.MyMethod();

MyDerivedClass3 myDerivedClass3 = new MyDerivedClass3();
myDerivedClass3.MyMethod();



Memeli memeli = new Memeli();
memeli.Konus();
Maymun maymun = new Maymun();
maymun.Konus();
Inek inek = new Inek();
inek.Konus();




Ucgen u = new Ucgen(10, 20);
u.AlanHesapla();
Dortgen dortgen = new Dortgen(10, 20);
dortgen.AlanHesapla();
Dikdortgen dikdortgen = new Dikdortgen(10, 20);
dikdortgen.AlanHesapla();



class MyClass
{
    public virtual void MyMethod()
    {
        Console.WriteLine("MyClass.MyMethod");
    }
}

class MyDerivedClass : MyClass
{
    public override void MyMethod()
    {
        Console.WriteLine("MyDerivedClass.MyMethod");
    }
}
class MyDerivedClass2 : MyClass
{

}
class MyDerivedClass3 : MyClass
{
    public override void MyMethod()
    {
        Console.WriteLine("MyDerivedClass3.MyMethod");
        base.MyMethod();
    }
}








class Memeli
{
    public virtual void Konus()
    {
        Console.WriteLine("Ben Konuşmuyorum...");
    }
}
class Maymun : Memeli
{
    override public void Konus()
    {
        Console.WriteLine("Maymun Konuşuyor...");
    }
}
class Inek : Memeli
{
    public override void Konus()
    {
        Console.WriteLine("İnek Konuşuyor...");
    }
}






class Sekil
{
    protected int _boy;
    protected int _en;
    public Sekil(int boy, int en)
    {
        _boy = boy;
        _en = en;
    }
    public virtual int AlanHesapla()
    {
        return _boy * _en;
    }
}

class Ucgen : Sekil
{
    public Ucgen(int boy, int en) : base(boy, en)
    {
    }
    public override int AlanHesapla()
    {
        return _boy * _en / 2;
    }
}
class Dortgen : Sekil
{
    public Dortgen(int boy, int en) : base(boy, en)
    {
    }
}
class Dikdortgen : Sekil
{
    public Dikdortgen(int boy, int en) : base(boy, en)
    {
    }
}
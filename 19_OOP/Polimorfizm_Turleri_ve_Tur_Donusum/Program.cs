//Static Polimorfizm - Aşırı Yükleme (Method Overloading)
Matematik matematik = new Matematik();
matematik.Topla(2, 3);

//Dynamic Polimorfizm - Aşırı Yükleme (Method Overide)
Arac arac = new Arac();
arac.HareketEt();

A a = new C();
C C = (C)a;

D d = (D)a;//Runtime Error
D d2 = a as D;//Null

if (a is D)
{
    D d3 = (D)a;
}


Object o = 123;
int i = (int)o;













class Matematik
{
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public int Topla(int sayi1, int sayi2, int sayi3)
    {
        return sayi1 + sayi2 + sayi3;
    }
    public int Topla(int sayi1, int sayi2, int sayi3, int sayi4)
    {
        return sayi1 + sayi2 + sayi3 + sayi4;
    }
}

class Arac
{
    public virtual void HareketEt()
    {
        Console.WriteLine("Arac Hareket Etti");
    }
}
class Taksi : Arac
{
    public override void HareketEt()
    {
        Console.WriteLine("Taksi Hareket Etti");
    }
}



//Tür Dönüşümü

class A
{

}
class B : A
{

}
class C : B
{

}
class D : C
{

}
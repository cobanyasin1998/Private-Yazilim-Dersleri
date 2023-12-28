

#region Class Members

#region Field
//Nesne içerisinde değer tutmamızı sağlayan alanlardır.
MyClass m1 = new MyClass();
MyClass m2 = new MyClass();
m1.a = 10;
m2.a = 20;


#endregion

#region Property
MyClass myClass3 = new MyClass();

myClass3.Maas = 1000;
Console.WriteLine(myClass3.Maas);




#endregion

#endregion


#region My Example
Kettle kettle = new Kettle();
Console.WriteLine(kettle.Sicaklık);
kettle.SuyuKaynat();
Console.WriteLine(kettle.Sicaklık);
#endregion

public class MyClass
{
    public int a; //Field
    public string b; //Field

    int maas;

    #region Full Property
    //Property hangi türden bir field'i temsil ediyorsa o türden bir değişken tutar.
    //Propertyler temsil ettikleri field'ların isimlerinin başharfi büyük olacak şekilde tanımlanır.
    public int Maas
    {
        get
        {
            //Property üzerinden değer okunmak istendiğinde çalışacak kodlar
            return maas;
        }
        set
        {
            //Property üzerinden değer atanmak istendiğinde çalışacak kodlar
            maas = value;
        }
    }

    #endregion

    #region Prop Property
    public DateTime DogumTarihi { get; set; }
    #endregion

    #region Auto Property C# 6.0
    public string Ad { get; set; } = "Yasin";
    #endregion

    #region Ref Readonly Property
    string coban = "Çoban";
    public ref readonly string Coban => ref coban;
    #endregion

    #region Computed Property

    int s1 = 5;
    int s2 = 10;
    public int Toplam => s1 + s2; // Expression Bodied Property

    #endregion

    #region Init-Only Properties C# 9.0

    public int NowYear { get; init; } = DateTime.Now.Year;

    #endregion

    #region Method
    public DateTime MyDogumTarihi { get; set; }
    public int Method1()
    {
        return DateTime.Now.Year - MyDogumTarihi.Year;
    }
    #endregion

    #region Indexeer
    public int this[int index]
    {
        get
        {
            return a;
        }
        set
        {
            a = value;
        }
    }
    #endregion
}



public class Kettle
{
    int sicaklik = 0;
    public int Sicaklık
    {
        get
        {
            return sicaklik;
        }
    }

    public void SuyuKaynat()
    {
        sicaklik = 100;
    }
}
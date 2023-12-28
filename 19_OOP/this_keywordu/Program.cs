

// this keywordu

#region 1.Sınıfın Nesnesini Temsil Eder


#endregion

#region 2.Aynı İsimde Field ile Metot Parametrelerini Ayırt Etmek İçin Kullanılır


#endregion

#region 3.Bir Constructor'dan Başka bir Constructor'ı Çağırmak İçin Kullanılır


#endregion


class MyClass
{
    int a;
    public void X()
    {
        this.Y(a);
    }
    public void Y(int a)
    {
        this.a = 5;
    }
}
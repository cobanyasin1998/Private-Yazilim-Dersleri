


#region Class İçerisindeki Tanımlanan Class Sınıf Elemanı mıdır?

MyClass myClass = new MyClass();
MyClass.MyClass2 myClass2 = new MyClass.MyClass2();



class MyClass
{
    int a; //Field
    public int MyProperty { get; set; } //Property
    public void MyMethod() //Method
    {

    }

    public class MyClass2 //Class //Sınıf elemanı değildir.
    {

    }

}



#endregion



#region Class Elemanlarına Açıklama Satırı Nasıl Eklenir?



Product product = new Product();
product.Description = 10;

/// <summary>
/// Ürün sınıfı
/// </summary>
public class Product
{
    /// <summary>
    ///     Açıklama satırı
    /// </summary>
    public int Description { get; set; }

    /// <summary>
    /// Döviz çeviri işlemlerini yapar.
    /// </summary>
    /// <param name="fiyat">Ürün Fiyatı</param>
    /// <returns>decimal döner</returns>
    public decimal MyMethod(decimal fiyat) { return fiyat * 30; }

}



#endregion

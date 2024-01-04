

//Bir sınıfın miras  vermesini yahut bir başka deyişle başka bir sınıf tarafından
//miras alınmasını engellemek için kullanılır.
//Sadece sınıflarda ve sadece 'override' edilebilen metotlarda kullanılabilir.
sealed class Sinif
{
    public void Metot()
    {
        Console.WriteLine("Metot");
    }
}
class Sinif2 //: Sinif
{
    //Hata verir.
}




//Metot üzerinde sealed keyword kullanımı
//Kalıtımsal durumlarda, atalardan gelen ve birinci dereceden  alt sınıf tarafından 'override' edilmiş 
//olan 'virtual' member'ların hiyerarşideki sonraki sınıflar tarafından 'override' edilmesini engellemek için kullanılır.
class Sinif3
{
    public virtual void Metot()
    {
        Console.WriteLine("Metot");
    }
}
class Sinif4 : Sinif3
{
    public sealed override void Metot()
    {
        Console.WriteLine("Metot");
    }
}
class Sinif5 : Sinif4
{
    //Hata verir.
    //public override void Metot()
    //{
    //    Console.WriteLine("Metot");
    //}
}
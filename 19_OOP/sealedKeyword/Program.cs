

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
class Sinif2 : Sinif
{
    //Hata verir.
}
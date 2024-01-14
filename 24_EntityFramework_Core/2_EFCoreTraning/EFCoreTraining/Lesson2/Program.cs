

class Program
{
    static void Main(string[] args)
    {

        #region Basit Düzeyde Entity Tanımlama Kuralları
        //EF Core, her tablonun default olarak Id isimli bir kolona sahip olmasını bekler.
        //Haliyle, bu kolonu temsil eden bir property tanımlamadığımız taktirde hata verecektir. 
        #endregion


        #region OnConfiguring İle Konfigürasyon Ayarlarını Gerçekleştirmek
        //ETicaretContext.cs
        //Ef Core tool'unu yapılandırmak için kullanılır.
        //Context nesnesinde override edilerek kullanılmaktadır.
        #endregion

        #region Tablo Adını Belirleme
        //belirtilmediği taktirde, EF Core, tablo adını modelin adıyla aynı olarak varsayacaktır.
        #endregion

    }
}


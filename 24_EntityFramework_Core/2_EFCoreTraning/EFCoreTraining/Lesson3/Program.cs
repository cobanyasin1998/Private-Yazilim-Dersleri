using Lesson2;
using Lesson2.Models;

class Program
{
    static async Task Main(string[] args)
    {
        ETicaretDbContext context = new ETicaretDbContext();


        #region Veri Nasıl Eklenir ? 
        {
            Urun urun = new Urun()
            {
                Adi = "Kalem",
                Fiyati = 10,
                StokAdedi = 100
            };
            #region context.AddAsync Fonksiyonu
            {
                await context.AddAsync(urun);
            }
            #endregion
            #region context.DbSet.AddAsync Fonksiyonu
            {
                await context.Urunler.AddAsync(urun);
            }
            #endregion
        }


        #endregion

        #region SaveChanges Nedir?
        {
            await context.SaveChangesAsync();
            //SaveChangesAsync insert, update, delete sorgularını oluşturup bir transaction içerisinde eşliğinde veritabanına gönderip execute eden fonksiyondur.
            //Eğer ki oluşturulan sorgulardan herhangi biri başarısız olursa tüm işlemleri geri alır(Rollback)
        }
        #endregion

        #region EF Core Açısından bir verinin eklenmesi gerektiği nasıl anlaşılıyor?

        {
            Urun urun = new Urun()
            {
                Adi = "Masa",
                Fiyati = 10,
                StokAdedi = 100
            };
            Console.WriteLine(context.Entry(urun).State);
            await context.Urunler.AddAsync(urun);
            Console.WriteLine(context.Entry(urun).State);
            await context.SaveChangesAsync();
            Console.WriteLine(context.Entry(urun).State);


        }
        #endregion

        #region Birden fazla veri eklerken nelere dikkat edilmelidir ?
        {
            Urun urun1 = new Urun()
            {
                Adi = "Masa",
                Fiyati = 10,
                StokAdedi = 100
            };
            Urun urun2 = new Urun()
            {
                Adi = "Tablo",
                Fiyati = 10,
                StokAdedi = 100
            };
            Urun urun3 = new Urun()
            {
                Adi = "Klavye",
                Fiyati = 10,
                StokAdedi = 100
            };
            { //Maliyetli
                await context.Urunler.AddAsync(urun1);
                await context.SaveChangesAsync();

                await context.Urunler.AddAsync(urun2);
                await context.SaveChangesAsync();

                await context.Urunler.AddAsync(urun3);
                await context.SaveChangesAsync();
            }
            {
                //Daha az maliyetli
                await context.Urunler.AddRangeAsync(urun1, urun2, urun3);
                await context.SaveChangesAsync();
            }


        }

        #endregion

    }
}



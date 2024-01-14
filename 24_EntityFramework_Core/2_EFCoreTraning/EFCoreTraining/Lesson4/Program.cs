using Lesson2;
using Lesson2.Models;
using Microsoft.EntityFrameworkCore;
class Program
{
    static async Task Main(string[] args)
    {
        ETicaretDbContext context = new ETicaretDbContext();
        #region Veri Nasıl Güncellenir
        {
            Urun urun = await context.Urunler.FirstOrDefaultAsync(u => u.Id == 1);
            urun.Adi = "Kalem";
            await context.SaveChangesAsync();
        }
        #endregion
        #region ChangeTracker Nedir? Kısaca!
        {
            //ChangeTracker, context üzerinden gelen verilerin durumlarını takip eden bir yapıdır.
            //Bu takip mekanizması sayesinde context üzerinden gelen verilerle ilgili işlemler neticesinde
            //update yahut delete sorgularının oluşturulacağı anlaşılır.
        }
        #endregion
        #region Takip Edilmeyen Nesneler Nasıl Güncellenir?
        {
            Urun urun = new Urun()
            {
                Id = 3,
                Adi = "Sigara",
                Fiyati = 10,
                StokAdedi = 100
            };
            #region Update Fonksiyonu
            {
                //ChangeTracker mekanizması tarafından takip edilmeyen nesnelerin güncellenmesi için kullanılır.
                //Update fonksiyonunu kullanabilmek için kesinlikle ilgili nesnede ID  değeri verilmelidir!
                //Bu değer güncellenecek(update sorgusu oluşturulacak) nesnenin primary key değeridir.
                context.Urunler.Update(urun);
                await context.SaveChangesAsync();
            }
            #endregion
        }
        #endregion
        #region EntityState Nedir?
        {
            //Bir entity instance'ının durumunu ifade eden bir referans tipidir.
            Urun urun = new Urun()
            {
                Id = 3,
                Adi = "Sigara",
                Fiyati = 10,
                StokAdedi = 100
            };
            Console.WriteLine(context.Entry(urun).State);

        }
        #endregion
        #region Birden Fazla Veri Güncellenirken Nelere Dikkat Edilmelidir ?
        {
            var urunler = await context.Urunler.ToListAsync();
            foreach (Urun urun in urunler)
            {
                urun.Fiyati = urun.Fiyati * 2;
                //await context.SaveChangesAsync(); //Bu şekilde yaparsak her bir ürün için ayrı ayrı update sorgusu oluşturulur.
            }
            await context.SaveChangesAsync(); //Bu şekilde yaparsak tek bir update sorgusu oluşturulur.
        }
        #endregion
    }
}



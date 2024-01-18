using Lesson2;
using Lesson2.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

class Program
{
    static async Task Main(string[] args)
    {
        ETicaretDbContext context = new ETicaretDbContext();

        #region En Temel Basit Bir Sorgulama Fonksiyonları
        {
            #region Method Syntax
            {
                var data = await context.Urunler.ToListAsync();
            }
            #endregion
            #region QuerySytax
            {
                var data = (from urun in context.Urunler
                            select urun)
                           .ToListAsync();
            }
            #endregion
        }
        #endregion

        #region IQueryable ve IEnumerable Nedir? Basit Olarak!


        #region IQueryable
        {
            //Sorguya karşılık gelir.
            //EfCore Üzerinden yapılmış olan sorgunun execute edilmemiş halini ifade eder.
        }
        #endregion
        #region IEnumerable
        {
            //Sorgunun çalıştırılıp/execute edilip verilerin in memory'e yüklenmiş halini ifade eder.
        }
        #endregion
        #endregion

        #region Sorguyu Execute Etmek İçin Ne Yapmamız Gerekmektedir?

        #region ToListAsync
        {
            #region Method Syntax
            {
                var data = await context.Urunler.ToListAsync();
            }
            #endregion
            #region Query Syntax
            {
                var data = (from urun in context.Urunler
                            select urun).ToListAsync();
            }

            #endregion
        }
        #endregion
        #region Foreach
        {
            int urunId = 5;
            var data = (from urun in context.Urunler
                        where urun.Id > urunId
                        select urun);
            urunId = 6;
            #region Deferred Execution(Ertelenmiş Çalışma)
            {
                //IQueryable çalışmalarında ilgili kod yazıldığı noktada tetiklenmez/ çalıştırılmaz yani ilgili kod yazıldığı noktada sorgu çalışmaz. Nerede eder ? Çalıştırıldığı/Execute edildiği noktada çalışır.
                foreach (var item in data)
                {
                    Console.WriteLine(item.Adi);
                }
            }
            #endregion

        }
        #endregion

        #endregion

        #region Çoğul Veri Getiren Sorgulama Fonksiyonları

        #region ToListAsync
        {
            //Üretilen sorguyu execute ettirmemizi sağlayan fonksiyondur.
            #region Method Syntax
            {
                var data = await context.Urunler.ToListAsync();
            }
            #endregion
            #region Query Syntax
            {
                var data = (from urun in context.Urunler
                            select urun).ToListAsync();
            }
            #endregion
        }
        #endregion
        #region Where
        {
            //Veri seti üzerinde filtreleme yapmamızı sağlayan fonksiyondur.
            #region Method Syntax
            {
                var data = await context.Urunler
                    .Where(x => x.Id > 5)
                    .ToListAsync();
            }
            #endregion
            #region Query Syntax
            {
                var data = (from urun in context.Urunler
                            where urun.Id > 5
                            select urun)
                            .ToListAsync();
            }
            #endregion
        }


        #endregion
        #region Order By (Ascending)
        //Veri seti üzerinde sıralama yapmamızı sağlayan fonksiyondur.
        #region Method Syntax
        {
            var data = await context.Urunler
                .Where(x => x.Id > 5)
                .OrderBy(x => x.Fiyati)
                .ToListAsync();
        }
        #endregion
        #region Query Syntax
        {
            var data = (from urun in context.Urunler
                        where urun.Id > 5
                        orderby urun.Fiyati
                        select urun)
                        .ToListAsync();
        }
        #endregion
        #endregion
        #region Then By
        //Veri seti üzerinde  sıralama yapmamızı sağlayan fonksiyondur. Order By fonksiyonundan sonra kullanılır.
        #region Method Syntax
        {
            var data = await context.Urunler
                .Where(x => x.Id > 5)
                .OrderBy(x => x.Fiyati)
                .ThenBy(x => x.Adi)
                .ToListAsync();
        }
        #endregion
        #region Query Syntax
        {
            var data = (from urun in context.Urunler
                        where urun.Id > 5
                        orderby urun.Fiyati descending, urun.Adi ascending
                        select urun)
                        .ToListAsync();
        }
        #endregion




        #endregion
        #region Order By Descending
        //Veri seti üzerinde sıralama yapmamızı sağlayan fonksiyondur. Sıralama işlemini azalan şekilde yapar.
        #region Method Syntax
        {
            var data = await context.Urunler
                .Where(x => x.Id > 5)
                .OrderByDescending(x => x.Fiyati)
                .ToListAsync();
        }
        #endregion
        #region Query Syntax
        {
            var data = (from urun in context.Urunler
                        where urun.Id > 5
                        orderby urun.Fiyati descending
                        select urun)
                        .ToListAsync();
        }
        #endregion




        #endregion
        #region Then By
        //Veri seti üzerinde  sıralama yapmamızı sağlayan fonksiyondur. Order By fonksiyonundan sonra kullanılır.
        #region Method Syntax
        {
            var data = await context.Urunler
                .Where(x => x.Id > 5)
                .OrderBy(x => x.Fiyati)
                .ThenByDescending(x => x.Adi)
                .ToListAsync();
        }
        #endregion
        #region Query Syntax
        {
            var data = (from urun in context.Urunler
                        where urun.Id > 5
                        orderby urun.Fiyati descending, urun.Adi descending
                        select urun)
                        .ToListAsync();
        }
        #endregion

        #endregion

        #endregion

        #region Tekil Veri Getiren Sorgulama Fonksiyonları
        //Yapılan sorguda sade ve sadece tek bir kayıt gelmesi amaçlanıyorsa Single ya da SingleOrDefault fonksiyonları kullanılmalıdır.
        #region SingleAsync
        {
            //Eğer ki, sorgu sonucunda tek bir kayıt gelmezse hata fırlatır.
            #region Tek Kayıt Geldiğinde
            {
                var urun = await context.Urunler
                    .Where(x => x.Id == 55)
                    .SingleAsync(); //Çalışır
            }
            #endregion
            #region Hiç Kayıt Gelmediğinde
            {
                var urun = await context.Urunler
                   .Where(x => x.Id == 0)
                   .SingleAsync(); //Hata Fırlatır
            }
            #endregion
            #region Çok Kayıt Geldiğinde
            {
                var urun = await context.Urunler
                    .Where(x => x.Id > 0)
                    .SingleAsync(); //Hata Fırlatır
            }
            #endregion
        }
        #endregion

        #region SingleOrDefaultAsync
        {
            //Eğer ki, sorgu sonucunda çok kayıt gelirse hata fırlatır. Null değer döndürebilir.
            #region Tek Kayıt Geldiğinde
            {
                var urun = await context.Urunler
                    .Where(x => x.Id == 55)
                    .SingleOrDefaultAsync(); //Çalışır
            }
            #endregion
            #region Hiç Kayıt Gelmediğinde
            {
                var urun = await context.Urunler
                   .Where(x => x.Id == 0)
                   .SingleOrDefaultAsync(); //Çalışır
            }
            #endregion
            #region Çok Kayıt Geldiğinde
            {
                var urun = await context.Urunler
                    .Where(x => x.Id > 0)
                    .SingleOrDefaultAsync(); //Hata Fırlatır
            }
            #endregion
        }
        #endregion

        #region FirstAsync
        {
            #region Tek Kayıt Geldiğinde
            {
                var urun = await context.Urunler
                    .Where(x => x.Id == 55)
                    .FirstAsync(); //Çalışır
            }
            #endregion
            #region Hiç Kayıt Gelmediğinde
            {
                var urun = await context.Urunler
                   .Where(x => x.Id == 0)
                   .FirstAsync(); //Hata Fırlatır
            }
            #endregion
            #region Çok Kayıt Geldiğinde
            {
                var urun = await context.Urunler
                    .Where(x => x.Id > 0)
                    .FirstAsync();  //Çalışır
            }
            #endregion
        }
        #endregion

        #region FirstOrDefaultAsync
        {
            #region Tek Kayıt Geldiğinde
            {
                var urun = await context.Urunler
                    .Where(x => x.Id == 55)
                    .FirstOrDefaultAsync(); //Çalışır
            }
            #endregion
            #region Hiç Kayıt Gelmediğinde
            {
                var urun = await context.Urunler
                   .Where(x => x.Id == 0)
                   .FirstOrDefaultAsync(); //Çalışır
            }
            #endregion
            #region Çok Kayıt Geldiğinde
            {
                var urun = await context.Urunler
                    .Where(x => x.Id > 0)
                    .FirstOrDefaultAsync();  //Çalışır
            }
            #endregion
        }
        #endregion

        #region FindAsync
        {
            //FindAsync fonksiyonu sadece primary key alanı üzerinden çalışır.

            var urun = await context.Urunler
                .FindAsync(55);

            #region Composite Primary Key Durumu
            {
                var urunParca = await context
                    .UrunParcalar
                    .FindAsync(55, 66);
            }
            #endregion

        }

        #endregion

        #region FindAsync ile SingleAsync, SingleOrDefaultAsync, FirstAsync, FirstOrDefaultAsync Fonksiyonlarının Karşılaştırılması

        #endregion

        #region LastAsync
        {
            //LastAsync fonksiyonu sadece sıralama yapılmış veri setleri üzerinde çalışır.
            //OrderBy-OrderByDescending fonksiyonu ile birlikte kullanılmalıdır.

            var urun = await context.Urunler
                .OrderBy(x => x.Id)
                .LastAsync(x => x.Id > 1);
        }
        #endregion

        #region LastOrDefaultAsync
        {
            //LastOrDefaultAsync fonksiyonu sadece sıralama yapılmış veri setleri üzerinde çalışır.
            //OrderBy-OrderByDescending fonksiyonu ile birlikte kullanılmalıdır.
            //Null değer döndürebilir.

            var urun = await context.Urunler
                .OrderBy(x => x.Id)
                .LastOrDefaultAsync(x => x.Id > 1);
        }
        #endregion

        #endregion

        #region Diğer Sorgulama Fonksiyonları

        #region CountAsync
        {
            //Oluşturulan sorgunun execute edilmesi neticesinde kaç adet satırın elde edileceğini sayısal olarak(int) bizlere bildiren fonksiyondur.
            var urunler = await context.Urunler.CountAsync();
        }
        #endregion

        #region LongCountAsync
        {
            //Oluşturulan sorgunun execute edilmesi neticesinde kaç adet satırın elde edileceğini sayısal olarak(long) bizlere bildiren fonksiyondur.
            var urunler = await context.Urunler.LongCountAsync(u => u.Fiyati > 5000);
        }
        #endregion

        #region AnyAsync
        {
            //Sorgu neticesinde verinin gelip gelmediğini bool türünde dönen fonksiyondur. 
            //var urunler = await context.Urunler.Where(u => u.UrunAdi.Contains("1")).AnyAsync();
            //var urunler = await context.Urunler.AnyAsync(u => u.UrunAdi.Contains("1"));
        }
        #endregion

        #region MaxAsync
        {
            //Verilen kolondaki max değeri getirir.
            //var fiyat = await context.Urunler.MaxAsync(u => u.Fiyat);
        }
        #endregion

        #region MinAsync
        {
            //Verilen kolondaki min değeri getirir.
            //var fiyat = await context.Urunler.MinAsync(u => u.Fiyat);
        }
        #endregion

        #region Distinct
        {
            //Sorguda mükerrer kayıtlar varsa bunları tekilleştiren bir işleve sahip fonksiyondur.
            //var urunler = await context.Urunler.Distinct().ToListAsync();
        }
        #endregion

        #region AllAsync
        {
            //Bir sorgu neticesinde gelen verilerin, verilen şarta uyup uymadığını kontrol etmektedir. Eğer ki tüm veriler şarta uyuyorsa true, uymuyorsa false döndürecektir.
            var m = await context.Urunler.AllAsync(u => u.Fiyati < 15000);
            var m1 = await context.Urunler.AllAsync(u => u.Adi.Contains("a"));

        }
        #endregion

        #region SumAsync
        {
            //Vermiş olduğumuz sayısal proeprtynin toplamını alır.
            var fiyatToplam = await context.Urunler.SumAsync(u => u.Fiyati);
        }
        #endregion

        #region AverageAsync
        {
            //Vermiş olduğumuz sayısal proeprtynin aritmatik ortalamasını alır.
            var aritmatikOrtalama = await context.Urunler.AverageAsync(u => u.Fiyati);
        }
        #endregion

        #region Contains
        {
            //Like '%...%' sorgusu oluşturmamızı sağlar.
            var urunler = await context.Urunler.Where(u => u.Adi.Contains("7")).ToListAsync();
        }
        #endregion

        #region StartsWith
        {
            //Like '...%' sorgusu oluşturmamızı sağlar.
            var urunler = await context.Urunler.Where(u => u.Adi.StartsWith("7")).ToListAsync();
        }
        #endregion

        #region EndsWith
        {
            //Like '%...' sorgusu oluşturmamızı sağlar.
            var urunler = await context.Urunler.Where(u => u.Adi.EndsWith("7")).ToListAsync();
        }
        #endregion


        #endregion

        #region Sorgu Sonucu Dönüşüm Fonksiyonları




        #region ToDictionaryAsync
        {
            //Sorgu neticesinde gelecek olan veriyi bir dictioanry olarak elde etmek/tutmak/karşılamak istiyorsak eğer kullanılır!
            var urunler = await context.Urunler.ToDictionaryAsync(u => u.Adi, u => u.Fiyati);

            //ToList ile aynı amaca hizmet etmektedir. Yani, oluşturulan sorguyu execute edip neticesini alırlar.
            //ToList : Gelen sorgu neticesini entity türünde bir koleksiyona(List<TEntity>) dönüştürmekteyken,
            //ToDictionary ise : Gelen sorgu neticesini Dictionary türünden bir koleksiyona dönüştürecektir.
        }
        #endregion
        #region ToArrayAsync
        {
            //Oluşturulan sorguyu dizi olarak elde eder.
            //ToList ile muadil amaca hizmet eder. Yani sorguyu execute eder lakin gelen sonucu entity dizisi  olarak elde eder.
            var urunler = await context.Urunler.ToArrayAsync();
        }
        #endregion
        #region Select
        {
            //Select fonksiyonunun işlevsel olarak birden fazla davranışı söz konusudur,
            //1. Select fonksiyonu, generate edilecek sorgunun çekilecek kolonlarını ayarlamamızı sağlamaktadır. 

            var urunler = await context.Urunler.Select(u => new Urun
            {
                Id = u.Id,
                Fiyati = u.Fiyati
            }).ToListAsync();

            //2. Select fonksiyonu, gelen verileri farklı türlerde karşılamamızı sağlar. T, anonim

            var urunler2 = await context.Urunler.Select(u => new
            {
                Id = u.Id,
                Fiyati = u.Fiyati
            }).ToListAsync();

        }
        #endregion
        #region SelectMany
        {
            //Select ile aynı amaca hizmet eder. Lakin, ilişkisel tablolar neticesinde gelen koleksiyonel verileri de tekilleştirip projeksiyon etmemizi sağlar.

            var urunler = await context.Urunler.Include(u => u.Parcalar).SelectMany(u => u.Parcalar, (u, p) => new
            {
                u.Id,
                u.Fiyati,
                p.ParcaAdi
            }).ToListAsync();
        }
        #endregion




        #endregion


        #region GroupBy
        {
            #region QuerySytnax
            {
                var datas1 = context.Urunler
                    .GroupBy(x => x.Fiyati)
                    .Select(group => new
                    {
                        Fiyat = group.Key,
                        Count = group.Count()
                    })
                    .ToList();

            }
            #endregion
            #region MethodSytnax
            {
                var datas2 = await (from urun in context.Urunler
                                   group urun by urun.Fiyati
                                   into @group
                                   select new
                                   {
                                       Fiyat = @group.Key,
                                       Count = @group.Count()
                                   }).ToListAsync();
            }
            #endregion
        }
        #endregion

        #region Foreach Fonksiyonu
        //Bir sorgulama fonksiyonu felan değildir!
        //Sorgulama neticesinde elde edilen koleksiyonel veriler üzerinde iterasyonel olarak dönmemizi ve teker teker verileri elde edip işlemler yapabilmemizi sağlayan bir fonksiyondur. foreach döngüsünün metot halidir!
        var datas = await context.Urunler.ToListAsync();
        foreach (var item in datas)
        {

        }
        datas.ForEach(x =>
        {

        });
        #endregion
    }
}


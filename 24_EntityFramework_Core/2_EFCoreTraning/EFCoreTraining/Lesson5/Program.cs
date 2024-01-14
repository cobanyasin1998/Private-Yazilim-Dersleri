using Lesson2;
using Microsoft.EntityFrameworkCore;

class Program
{
    static async Task Main(string[] args)
    {
        ETicaretDbContext context = new ETicaretDbContext();

        #region Veri Nasıl Silinir?
        {
            var urun = await context.Urunler.FirstOrDefaultAsync(x => x.Id == 1);
            context.Urunler.Remove(urun);
            await context.SaveChangesAsync();
        }   
        #endregion
    }
}



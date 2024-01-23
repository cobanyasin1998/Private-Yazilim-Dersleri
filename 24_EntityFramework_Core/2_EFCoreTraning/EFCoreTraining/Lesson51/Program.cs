
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Reflection.Emit;

ApplicationDbContext context = new();

#region EF Core Select Sorgularını Güçlendirme Teknikleri

#region IQueryable - IEnumerable Farkı

//IQueryable, bu arayüz üzerinde yapılan işlemler direkt generate edilecek olan sorguya yansıtılacaktır.
//IEnumerable, bu arayüz üzerinde yapılan işlemler temel sorgu neticesinde gelen ve in-memorye yüklenen instance'lar üzerinde gerçekleştirilir. Yani sorguya yansıtılmaz.

//IQueryable ile yapılan sorgulama çalışmalarında sql sorguyu hedef verileri elde edecek şekilde generate edilecekken, IEnumerable ile yapılan sorgulama çalışmalarında sql daha geniş verileri getirebilecek şekilde execute edilerek hedef veriler in-memory'de ayıklanır.

//IQueryable hedef verileri getirirken, hedef verilerden daha fazlasını getirip in-memory'de ayıklar.

#region IQueryable
//var persons = await context.Persons.Where(p => p.Name.Contains("a"))
//                             .Take(3)
//                             .ToListAsync();


//var persons = await context.Persons.Where(p => p.Name.Contains("a"))
//                             .Where(p => p.PersonId > 3)
//                             .Take(3)
//                             .Skip(3)
//                             .ToListAsync();

#endregion
#region IEnumerable
//var persons = context.Persons.Where(p => p.Name.Contains("a"))
//                             .AsEnumerable()
//                             .Take(3)
//                             .ToList();
#endregion

#region AsQueryable

#endregion
#region AsEnumerable

#endregion
#endregion

#region Yalnızca İhtiyaç Olan Kolonları Listeleyin - Select
//var persons = await context.Persons.Select(p => new
//{
//    p.Name
//}).ToListAsync();
#endregion

#region Result'ı Limitleyin - Take
//await context.Persons.Take(50).ToListAsync();
#endregion

#region Join Sorgularında Eager Loading Sürecinde Verileri Filtreleyin
//var persons = await context.Persons.Include(p => p.Orders
//                                                  .Where(o => o.OrderId % 2 == 0)
//                                                  .OrderByDescending(o => o.OrderId)
//                                                  .Take(4))
//    .ToListAsync();

//foreach (var person in persons)
//{
//    var orders = person.Orders.Where(o => o.CreatedDate.Year == 2022);
//}

#endregion

#region Şartlara Bağlı Join Yapılacaksa Eğer Explicit Loading Kullanın
//var person = await context.Persons.Include(p => p.Orders).FirstOrDefaultAsync(p => p.PersonId == 1);
//var person = await context.Persons.FirstOrDefaultAsync(p => p.PersonId == 1);

//if (person.Name == "Ayşe")
//{
//    //Order'larını getir...
//    await context.Entry(person).Collection(p => p.Orders).LoadAsync();
//}
#endregion

#region Lazy Loading Kullanırken Dikkatli Olun!
#region Riskli Durum
//var persons = await context.Persons.ToListAsync();

//foreach (var person in persons)
//{
//    foreach (var order in person.Orders)
//    {
//        Console.WriteLine($"{person.Name} - {order.OrderId}");
//    }
//    Console.WriteLine("***********");
//}
#endregion
#region İdeal Durum
//var persons = await context.Persons.Select(p => new { p.Name, p.Orders }).ToListAsync();

//foreach (var person in persons)
//{
//    foreach (var order in person.Orders)
//    {
//        Console.WriteLine($"{person.Name} - {order.OrderId}");
//    }
//    Console.WriteLine("***********");
//}
#endregion
#endregion

#region İhtiyaç Noktalarında Ham SQL Kullanın - FromSql

#endregion

#region Asenkron Fonksiyonları Tercih Edin

#endregion

#endregion

public class Person
{
    public int PersonId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}
public class Order
{
    public int OrderId { get; set; }
    public int PersonId { get; set; }
    public string Description { get; set; }

    public virtual Person Person { get; set; }
}
class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Order> Orders { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<Person>()
            .HasMany(p => p.Orders)
            .WithOne(o => o.Person)
            .HasForeignKey(o => o.PersonId);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=localhost, 1433;Database=ApplicationDB;User ID=SA;Password=1q2w3e4r+!;TrustServerCertificate=True")
            .UseLazyLoadingProxies();
    }
}
public class PersonData : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasData(new Person[]
        {
              new(){ PersonId  = 1, Name = "Ayşe" },
              new(){ PersonId  = 2, Name = "Hilmi" },
              new(){ PersonId  = 3, Name = "Raziye" },
              new(){ PersonId  = 4, Name = "Süleyman" },
              new(){ PersonId  = 5, Name = "Fadime" },
              new(){ PersonId  = 6, Name = "Şuayip" },
              new(){ PersonId  = 7, Name = "Lale" },
              new(){ PersonId  = 8, Name = "Jale" },
              new(){ PersonId  = 9, Name = "Rıfkı" },
              new(){ PersonId  = 10, Name = "Muaviye" },
        });
    }
}
public class OrderData : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasData(new Order[]
        {
              new(){ OrderId = 1, PersonId = 1, Description = "..."},
              new(){ OrderId = 2, PersonId = 2, Description = "..."},
              new(){ OrderId = 3, PersonId = 4, Description = "..."},
              new(){ OrderId = 4, PersonId = 5, Description = "..."},
              new(){ OrderId = 5, PersonId = 1, Description = "..."},
              new(){ OrderId = 6, PersonId = 6, Description = "..."},
              new(){ OrderId = 7, PersonId = 7, Description = "..."},
              new(){ OrderId = 8, PersonId = 1, Description = "..."},
              new(){ OrderId = 9, PersonId = 8, Description = "..."},
              new(){ OrderId = 10, PersonId = 9, Description = "..."},
              new(){ OrderId = 11, PersonId = 1, Description = "..."},
              new(){ OrderId = 12, PersonId = 2, Description = "..."},
              new(){ OrderId = 13, PersonId = 2, Description = "..."},
              new(){ OrderId = 14, PersonId = 3, Description = "..."},
              new(){ OrderId = 15, PersonId = 1, Description = "..."},
              new(){ OrderId = 16, PersonId = 4, Description = "..."},
              new(){ OrderId = 17, PersonId = 1, Description = "..."},
              new(){ OrderId = 18, PersonId = 1, Description = "..."},
              new(){ OrderId = 19, PersonId = 5, Description = "..."},
              new(){ OrderId = 20, PersonId = 6, Description = "..."},
              new(){ OrderId = 21, PersonId = 1, Description = "..."},
              new(){ OrderId = 22, PersonId = 7, Description = "..."},
              new(){ OrderId = 23, PersonId = 7, Description = "..."},
              new(){ OrderId = 24, PersonId = 8, Description = "..."},
              new(){ OrderId = 25, PersonId = 1, Description = "..."},
              new(){ OrderId = 26, PersonId = 1, Description = "..."},
              new(){ OrderId = 27, PersonId = 9, Description = "..."},
              new(){ OrderId = 28, PersonId = 9, Description = "..."},
              new(){ OrderId = 29, PersonId = 9, Description = "..."},
              new(){ OrderId = 30, PersonId = 2, Description = "..."},
              new(){ OrderId = 31, PersonId = 3, Description = "..."},
              new(){ OrderId = 32, PersonId = 1, Description = "..."},
              new(){ OrderId = 33, PersonId = 1, Description = "..."},
              new(){ OrderId = 34, PersonId = 1, Description = "..."},
              new(){ OrderId = 35, PersonId = 5, Description = "..."},
              new(){ OrderId = 36, PersonId = 1, Description = "..."},
              new(){ OrderId = 37, PersonId = 5, Description = "..."},
              new(){ OrderId = 38, PersonId = 1, Description = "..."},
              new(){ OrderId = 39, PersonId = 1, Description = "..."},
              new(){ OrderId = 40, PersonId = 1, Description = "..."},
        });
    }
}
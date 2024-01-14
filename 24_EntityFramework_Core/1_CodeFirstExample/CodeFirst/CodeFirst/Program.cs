


using Microsoft.EntityFrameworkCore;


class Program
{
    static void Main(string[] args)
    {
        // Your code here
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class ECommerceDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5455;Database=ECommerce;Username=postgres;Password=postgres");
            base.OnConfiguring(optionsBuilder);
        }
    }



}
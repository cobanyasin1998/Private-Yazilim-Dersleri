

var samsung = new Product("Samsung S23", 2000);

var yasinObserver = new YasinObserver("Yasin Observer");

var amazon = new Amazon();

amazon.Register(yasinObserver, samsung);


amazon.NotifyForProductName("Samsung S23");





class Amazon
{
    private Dictionary<IObserver, Product> _observer = new Dictionary<IObserver, Product>();
    public void Register(IObserver observer, Product product)
    {
        _observer.TryAdd(observer, product);
    }
    public void UnRegister(IObserver observer)
    {
        _observer.Remove(observer);

    }
    public void NotifyAll()
    {
        foreach (var item in _observer)
        {
            item.Key.StockUpdate(item.Value);
        }
    }
    public void NotifyForProductName(string productName)
    {
        foreach (var item in _observer)
        {
            if (item.Value.Name == productName)
            {
                item.Key.StockUpdate(item.Value);
            }
        }
    }
}
class YasinObserver : IObserver
{
    public string FullName { get; set; }
    public YasinObserver(string fullName)
    {
        FullName = fullName;
    }
    public void StockUpdate(Product product)
    {

        Console.WriteLine($"{FullName}, Product {product.Name} in stock now!");
    }
}
interface IObserver
{
    void StockUpdate(Product product);
}
class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

}
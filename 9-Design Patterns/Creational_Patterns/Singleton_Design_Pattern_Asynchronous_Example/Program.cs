
List<Task> tasks = new List<Task>();


for (int i = 0; i < 100; i++)
{
    tasks.Add(Task.Run(() =>
    {
        Console.WriteLine($"{i} numaralı Task");
        Example.Instance();

    }));

}

await Task.WhenAll(tasks);


class Example
{
    private Example()
    {
        Console.WriteLine($"{nameof(Example)} nesnesi oluşturuldu.");
    }
    static Example _instance;
    static object _obj = new object();
    public static Example Instance()
    {
        lock (_obj) // Buna gerek kalmadan static ctor da da oluşturabilir
        {
            if (_instance == null)
                _instance = new Example();
           
        }
        return _instance;
    }
}

using System.Collections.Concurrent;

ObjectPool<X> pools = ObjectPool<X>.GetInstance;

var t1 = Task.Run(() =>
{

    while (true)
    {
        var x = pools.Get(() => new X());
        if (x != null)
        {
            x.Count++;
            x.Write();
            pools.Return(x);
        }

    }
});
var t2 = Task.Run(() =>
{

    while (true)
    {
        var x = pools.Get(() => new X());
        if (x != null)
        {
            x.Count++;
            x.Write();
            pools.Return(x);
        }

    }
});
await Task.WhenAll(t1, t2);


//ConcurrentBag
/*
 Asenkron süreçlerde kullanılan Thread Safe bir koleksiyondur
Tüm threadler için bu koleksiyon nesnesinden bir model oluşturulmakta ve her bir iş 
parçacığı kendisine ait model üzerinden çalışmaktadır.Böylece çakışma söz konusu
olmamaktadır.
Her bir thread için, eklenen en sonuncu eleman elde edilir. Dolayısıyla herhangi bir thread'da eleman eklenmediği takdirde
en sonuncu eleman istenildiği takdirde diğer thread'lar tarafından son eleman olarak eklenenlerden biri rastgele alınacak ve geri gönderilecektir.
 */

class ObjectPool<T> where T : class
{
    //Pool
    readonly ConcurrentBag<T> _instances;
    readonly List<string> _types = new List<string>();
    private ObjectPool()
    {
        _instances = new ConcurrentBag<T>();
    }

    static ObjectPool<T> _objectPool;
    static ObjectPool()
        => _objectPool = new ObjectPool<T>();

    public static ObjectPool<T> GetInstance { get => _objectPool; }
    public ConcurrentBag<T> Instances { get => _instances; }
    static object _o = new object();
    public T Get(Func<T>? objectGenerator = null)
    {
        lock (_o)
        {
            var state = _instances.TryTake(out T instance);
            if (!state && !_types.Any(t => t == nameof(T)))
            {
                T generatedInstance = objectGenerator();
                _types.Add(nameof(T));
                return generatedInstance;
            }
            return instance;

        }

    }
    public void Return(T instance)
    {
        _instances.Add(instance);
    }

}

class X
{
    public int Count { get; set; }
    public void Write() => Console.WriteLine(Count);
    public X() => Console.WriteLine("X üretim maliyeti...");
    ~X() => Console.WriteLine("X imha maliyeti...");
}
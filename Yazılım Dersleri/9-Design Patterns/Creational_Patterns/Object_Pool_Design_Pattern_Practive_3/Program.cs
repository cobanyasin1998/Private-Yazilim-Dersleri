﻿
using System.Collections.Concurrent;

ObjectPool<X> pools = ObjectPool<X>.GetInstance;
var x1 = pools.Get(() => new X());
x1.Count++;
pools.Return(x1);

var x2 = pools.Get(() => new X());
pools.Return(x2);
class ObjectPool<T> where T : class
{
    //Pool
    readonly ConcurrentBag<T> _instances;
    private ObjectPool()
    {
        _instances = new ConcurrentBag<T>();
    }

    static ObjectPool<T> _objectPool;
    static ObjectPool()
        => _objectPool = new ObjectPool<T>();

    public static ObjectPool<T> GetInstance { get => _objectPool; }
    public ConcurrentBag<T> Instances { get => _instances; }
    public T Get(Func<T>? objectGenerator = null)
    {
        //Havuzdan generic parametrede bildirilen türdeki nesneyi geri döndürmek.


        return _instances.TryTake(out T instance) ? instance : objectGenerator();
    }
    public void Return(T instance)
    {
        //Havuzdan ödünç alınan nesneyi geri iade etmek.


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
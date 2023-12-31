

// Destructor Metot

X();
GC.Collect();
GC.WaitForPendingFinalizers();
Console.ReadLine(); 

static void X()
{
    MyClass myClass = new MyClass();
}

class MyClass
{

    public MyClass()
    {
        // Constructor Metot
        Console.WriteLine("Constructor Metot");
    }

    ~MyClass()
    {
        // Destructor Metot
        Console.WriteLine("Destructor Metot");
    }
}



abstract class MyAbstractClass
{
    int a;
    public void X()
    {
        System.Console.WriteLine("X");
    }
    public int MyProperty { get; set; }


    public abstract void Z();
    public abstract void Y(string a, int b);
    public abstract int MyProperty1 { get; set; }
}

class MyClass : MyAbstractClass
{
    public override int MyProperty1 { get; set; }

    public override void Y(string a, int b)
    {
        throw new NotImplementedException();
    }

    public override void Z()
    {
        throw new NotImplementedException();
    }
}
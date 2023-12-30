


MyClass myClass = null;
myClass.MyProperty = 1;//NullReferenceException

new MyClass().Topla(1, 2);//Garbage Collector

new MyClass()
{
    MyProperty = 1,
    MyProperty1 = 2,
    MyProperty2 = 3,
    MyProperty3 = 4

};

class MyClass
{
    public int MyProperty { get; set; }
    public int MyProperty1 { get; set; }
    public int MyProperty2 { get; set; }
    public int MyProperty3 { get; set; }

    public int Topla(int a, int b)
    {
        return a + b;
    }
}





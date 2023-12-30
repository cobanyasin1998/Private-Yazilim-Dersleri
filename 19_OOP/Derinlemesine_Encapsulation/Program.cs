

MyClass myClass = new MyClass();
myClass.ASet(5);
Console.WriteLine(myClass.AGet());//Eski Yöntem




class MyClass()
{
    int a;

    public int AGet()
    {
        return this.a;
    }
    public void ASet(int val)
    {
        this.a = val;
    }
}
class MyClass2()
{
    //propfull
    private int yas;

    public int Yas
    {
        get { return yas; }
        set { yas = value; }
    }

}
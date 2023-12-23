

static ITekCift TekCift(int n)
{
    if (n % 2 == 0)
        return ITekCift.Cift;
    return ITekCift.Tek;
       
}
Console.WriteLine(TekCift(5));
Console.ReadLine();

public enum ITekCift
{
    Tek = 1,
    Cift = 2
}
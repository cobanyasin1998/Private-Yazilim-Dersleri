Cember cember = new(5);
Console.WriteLine($"Çevresi => {cember.Cevresi()}");
Console.WriteLine($"Alan => {cember.Alan()}");
Console.WriteLine($"Alan Bir Dilimi => {cember.Alan(180)}");

Console.ReadLine();

class Cember
{
    public const double Pi = 3.14;

    private double YariCap;
    public double yaricap
    {
        get
        {
            return YariCap;
        }
        set
        {
            YariCap = value;
        }
    }

    public Cember(double yaricap)
    {
        this.yaricap = yaricap;
    }

    public double Cevresi()
    {
        return 2 * Pi * YariCap;
    }
    public double Alan()
    {
        return Pi * (Math.Pow(YariCap, 2));
    }
    public double Alan(int derece)//cemberin bir dilimini bulmak için
    {

        return Pi * YariCap * YariCap * derece / 360;

    }
}

AsalCarpan asalCarpan = new AsalCarpan();

Console.WriteLine(asalCarpan.ToString());
Console.ReadLine();




class AsalCarpan
{
  
    public HashSet<int> AsalCarpanlariBul(int sayi)
    {
        HashSet<int> result = new HashSet<int>();
        int i = 2;
        while (sayi > 1)
        {
            if (sayi % i == 0)
            {
                sayi = sayi / i;
                result.Add(sayi);
            }
            else { i++; }
        }

        return result;
    }
    public override string ToString()
    {
        var hashSet = this.AsalCarpanlariBul(45861);
        string output = string.Join(", ", hashSet);
        Console.WriteLine(output);
        return base.ToString();
    }
}
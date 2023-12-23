static bool AsalSayi(int n)
{
    if (n <= 1)
    {
        return false;
    }
    bool kontrol = true;

    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            kontrol = false;
            break;
        }
    }
    return kontrol;
}


Console.WriteLine(AsalSayi(47) ? "Asal Sayı" : "Asal Sayı Değil");
Console.ReadLine();
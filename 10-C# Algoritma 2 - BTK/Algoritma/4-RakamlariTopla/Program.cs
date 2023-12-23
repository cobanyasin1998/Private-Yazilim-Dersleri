
static int RakamlarToplami(int sayi)
{
    int toplam = 0, rakam = 0;

    while (sayi > 0)
    {
        rakam = sayi % 10;
        toplam = rakam;
        sayi = sayi / 10;
    }
    return toplam;

}


Console.WriteLine(RakamlarToplami(45847));
Console.ReadLine();
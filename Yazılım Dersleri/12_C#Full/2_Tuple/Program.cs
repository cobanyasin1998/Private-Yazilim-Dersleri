




static (int, string) GeriyeIntStringDondurur()
{
    int sayi = 42;
    string metin = "Merhaba, dünya!";

    return (sayi, metin);
}



(int, string) degerim = GeriyeIntStringDondurur();


Console.WriteLine((degerim.Item1, degerim.Item2));



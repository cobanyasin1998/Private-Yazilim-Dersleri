
var sonucOkek = OkekObeb.OKEK(15, 20);
Console.WriteLine(sonucOkek);


var sonucObeb = OkekObeb.OBEB(5, 10);
Console.WriteLine(sonucObeb);

public class OkekObeb
{


    public static int OKEK(int sayi1, int sayi2)
    {
        int s = 1;
        while (sayi1 != 1 && sayi2 != 1)
        {
            int bol = 2;
            for (int i = 1; i < (sayi1 > sayi2 ? sayi1 : sayi2); i++)
            {
                if (sayi1 % bol == 0 || sayi2 % bol == 0)
                {
                    s *= bol;
                    if (sayi1 % bol == 0)
                    {
                        sayi1 = sayi1 / bol;
                    }
                    if (sayi2 % bol == 0)
                    {
                        sayi2 = sayi2 / bol;
                    }
                }
                else
                {
                    bol++;
                }
            }
        }

        return s;
    }

    public static int OBEB(int sayi1, int sayi2)
    {
        int s = 1;
        int bolen = 2;

        while (sayi1 != 1 || sayi2 != 1)
        {
            for (int i = 2; i < (sayi1 > sayi2 ? sayi1 : sayi2); i++)
            {
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                    {
                        s *= bolen;
                    }
                    if (sayi1 % bolen == 0)
                    {
                        sayi1 /= bolen;
                    }
                    if (sayi2 % bolen == 0)
                    {
                        sayi2 /= bolen;
                    }
                }
                else { bolen++; }

            }
        }
        return s;
    }



}
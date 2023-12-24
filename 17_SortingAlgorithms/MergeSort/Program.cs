//Sıralama Algoritmaları - Merge Sort (Birleştirerek Sıralama)


int[] dizi = { 12, 4, 5, 6, 7, 3, 1, 15 };

Console.WriteLine("Sıralanmamış dizi: ");
DiziYazdir(dizi);

MergeSortAlgoritma(dizi, 0, dizi.Length - 1);

Console.WriteLine("\nSıralanmış dizi: ");
DiziYazdir(dizi);


static void MergeSortAlgoritma(int[] dizi, int baslangic, int bitis)
{
    if (baslangic < bitis)
    {
        int orta = (baslangic + bitis) / 2;

        MergeSortAlgoritma(dizi, baslangic, orta);
        MergeSortAlgoritma(dizi, orta + 1, bitis);

        Birlestir(dizi, baslangic, orta, bitis);
    }
}

static void Birlestir(int[] dizi, int baslangic, int orta, int bitis)
{
    int n1 = orta - baslangic + 1;
    int n2 = bitis - orta;

    int[] solDizi = new int[n1];
    int[] sagDizi = new int[n2];

    for (int i = 0; i < n1; ++i)
        solDizi[i] = dizi[baslangic + i];

    for (int j = 0; j < n2; ++j)
        sagDizi[j] = dizi[orta + 1 + j];

    int x = 0, y = 0;
    int k = baslangic;

    while (x < n1 && y < n2)
    {
        if (solDizi[x] <= sagDizi[y])
        {
            dizi[k] = solDizi[x];
            x++;
        }
        else
        {
            dizi[k] = sagDizi[y];
            y++;
        }
        k++;
    }

    while (x < n1)
    {
        dizi[k] = solDizi[x];
        x++;
        k++;
    }

    while (y < n2)
    {
        dizi[k] = sagDizi[y];
        y++;
        k++;
    }
}

static void DiziYazdir(int[] dizi)
{
    foreach (var eleman in dizi)
    {
        Console.Write(eleman + " ");
    }
    Console.WriteLine();
}
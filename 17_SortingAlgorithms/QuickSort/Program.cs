

int[] dizi = { 12, 4, 5, 6, 7, 3, 1, 15 };

Console.WriteLine("Sıralanmamış dizi: ");
DiziYazdir(dizi);

QuickSortAlgoritma(dizi, 0, dizi.Length - 1);

Console.WriteLine("\nSıralanmış dizi: ");
DiziYazdir(dizi);



static void QuickSortAlgoritma(int[] dizi, int baslangic, int bitis)
{
    if (baslangic < bitis)
    {
        int partitionIndex = Partition(dizi, baslangic, bitis);

        QuickSortAlgoritma(dizi, baslangic, partitionIndex - 1);
        QuickSortAlgoritma(dizi, partitionIndex + 1, bitis);
    }
}

static int Partition(int[] dizi, int baslangic, int bitis)
{
    int pivot = dizi[bitis];
    int i = baslangic - 1;

    for (int j = baslangic; j < bitis; j++)
    {
        if (dizi[j] < pivot)
        {
            i++;
            Swap(dizi, i, j);
        }
    }

    Swap(dizi, i + 1, bitis);
    return i + 1;
}

static void Swap(int[] dizi, int i, int j)
{
    int gecici = dizi[i];
    dizi[i] = dizi[j];
    dizi[j] = gecici;
}

static void DiziYazdir(int[] dizi)
{
    foreach (var eleman in dizi)
    {
        Console.Write(eleman + " ");
    }
    Console.WriteLine();
}
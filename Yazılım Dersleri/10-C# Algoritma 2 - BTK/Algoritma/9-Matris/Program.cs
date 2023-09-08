

 Matris.Yazdir(Matris.Olustur());
Console.ReadLine();

public class Matris
{
    public static int[,] Olustur(int satir = 3, int sutun = 3, int min = 1, int max = 9)
    {

        int[,] X = new int[satir, sutun];

        for (int i = 0; i < satir; i++)
        {
            for (int j = 0; j < satir; j++)
            {
                X[i, j] = new Random().Next(min, max);
            }
        }
        return X;

    }

    public static void Yazdir(int[,] X)
    {
        for (int i = 0; i < X.GetLength(0); i++)
        {
            for (int j = 0; j < X.GetLength(0); j++)
                Console.Write("{0,3}", X[i,j]);
            Console.WriteLine();
        }
    }
}



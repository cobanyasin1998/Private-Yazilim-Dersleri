using System;

namespace _8_Aritmetik_Operatorler_Kritik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (int) * (double) = ?

            //İki farklı türde sayısal değer üzerinde yapılan aritmetik işlem neticesinde sonuç olan türde dönecektir.

            int s1 = 10;
            double s2 = 5.1;

            double res =  s1+s2; // Aritmetik operatörler küöük olan tür büyük olan türe bilinçsiz bir şekilde dönüştürülerek

            //o şekilde hesap yapılır. O yüzden sonuç büyük olan türde elde edilecektir.

            #endregion

            #region (byte) * (byte) = ? (İstisna - Mülakat !!!)
            //Normalde iki aynı türdeki sayısal değer üzerinde yapılan aritmetik işlem neticesinde sonuç aynı türde dönecektir.
            //Ama byte olunca ikiside int döner

            byte by1 = 10;
            byte by2 = 5;

            int result = by1+ by2;

            #endregion



            int a = int.MaxValue; int b = int.MaxValue;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int ab = a + b;
            Console.WriteLine(ab);


            /*
             
             Elbette, bu durum tam sayı taşmaları veya "integer overflow" ile ilgili bir özelliktir. C#'da, int türünde bir değişkenin sınırlarını aştığında, değer sıfırdan başlayarak baştan alınır (wrap around).

int.MaxValue değeri 2147483647'dir. Bu değeri bir kez daha eklediğinizde, toplam 4294967294 olur. Ancak bu değer int türünün maksimum değerini aşar ve bir taşma olur. C#'daki taşma durumu, en küçük değere geri döner ve bu da -2147483648'dir. Yani, int.MaxValue + int.MaxValue işleminin sonucu -2 olur.

Aşağıdaki adımları takip edebilirsiniz:

int.MaxValue + int.MaxValue önce 4294967294 değerini hesaplar.
Bu değer int türünün maksimum değerini aşar, bu nedenle taşma meydana gelir.
Taşma durumunda, değer en küçük değere (yani, int.MinValue) geri döner.
Sonuç olarak, int.MinValue değeri olan -2147483648 elde edilir.
Bu nedenle, Console.WriteLine(ab) ifadesi -2'yi yazdırır.
             
             */
        }
    }
}

using System;

namespace _7_TypeConversion_Kritik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 3000;
            short s = (byte)a;


            //sağda bilinçli tür dönüşümü, soldaki bilinçsiz tür dönüşümü

            Console.WriteLine(s);





            #region Checked - Unchecked

            checked //kullanılmazsa ve veri kaybı olursa program devam eder.
            {
                int aa = 500;
                byte b = (byte)aa;

                Console.WriteLine(b);
            }

            unchecked // hata fırlatmaz -- bu kod bloğu olmasa bile normal gibi çalışır
            {

            }




            #endregion





        }
    }
}

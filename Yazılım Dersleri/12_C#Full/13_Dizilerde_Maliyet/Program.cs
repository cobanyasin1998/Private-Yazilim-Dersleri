using Microsoft.Extensions.Primitives;
using System;
using System.Text;

namespace _13_Dizilerde_Maliyet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ArraySegment
            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            #region  ArraySegment Türü İle Dizinin Belli Bir Alanını Referans Etmek



            ArraySegment<int> ints = new ArraySegment<int>(sayilar);
            ArraySegment<int> segment = new ArraySegment<int>(sayilar, 2, 5);

            segment[0] *= 10;


            #endregion


            #region ArraySegment Slicing(Dilimleme) Özelliği

            ArraySegment<int> segment2 = new ArraySegment<int>(sayilar);
            ArraySegment<int> parca1 = segment2.Slice(0, 2);
            ArraySegment<int> parca2 = segment2.Slice(4, 7);

            #endregion
            #endregion

            #region StringSegment
            string text = "Ölüme gidelim dedin de mazot yok mu dedik";
            
            StringSegment strSegment = new StringSegment(text,2,5);



            #endregion

            #region StringBuilder
            //StringSegment algoritmasını kullanır.
            string isim = "Yasin";
            string soyisim = "Çoban";

            StringBuilder builder = new StringBuilder();
            builder.Append(isim);
            builder.Append(" ");
            builder.Append(soyisim);
            Console.WriteLine(builder.ToString());



            #endregion

        }
    }
}

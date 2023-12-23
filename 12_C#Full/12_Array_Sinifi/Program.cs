using System;

namespace _12_Array_Sinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dizi olarak tanımlanan değişkenler  Array sınıfından türetilmektedir.
            //Dolayısıyla dizilerde Array sınıfından gelen belirli metotlar ve özellikler mevcuttur.

            int[] a = new int[5];
            //Dizi eğer ki kendi türünde referans ediliyorsa indexer operatoru kullanılabilir.
            //Bu şekilde çalıştığında ilgili diziye verisel müdahaleler operatif gerçekleştirilir.

            /*Genellikle bu format algoritmalarda tercih edilir. Çünkü indexer algoritmasında çok kullanılır*/

            Array a2 = new int[3];
            //Yok eğer Array türünde referans ediliyorsa indexer op. kullanılamaz.
            //Bu şekilde ise fonksiyonel çözümler getirilmektedir.

            /*Genellikle elimizdeki diziler üzeride işlem yaparken tercih edilen formattır. Dizi hakkında bilgilendirme de vs. kullanılır*/



            #region Array türünden dizilere değer atama - okuma


            #region 1.Yöntem
            int[] dizi = new int[3];
            dizi[0] = 1;
            dizi[1] = 2;
            dizi[2] = 3;
            Array dizi2 = dizi;
            #endregion

            #region 2.Yöntem

            Array mydizi = new int[] { 1, 2, 3 };

            #endregion

            #region 3.Yöntem - Kullanılır
            Array filmler = new int[3];
            filmler.SetValue(30, 0);
            filmler.GetValue(0);
            #endregion


            #endregion



            #region Metotlar

            #region Clear
            //Dizi içerisindeki tüm elemanları siliyor diye bilinir. YANLIŞTIR. dizi içerisindeki tüm elemanlara default değerleri atar

            Array filmler2 = new string[3];
            filmler2.SetValue("yüzüklerin-efendisi", 0);
            Array.Clear(filmler2, 0, filmler2.Length);
            Console.WriteLine(filmler2.GetValue(0));

            Array rakamlar = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Array.Clear(rakamlar, 0, rakamlar.Length);
            Console.WriteLine(rakamlar.GetValue(5));



            #endregion

            #region Copy
            //Elimizdeki bir dizinin verilerii bir başka diziye kopyalamamızı sağlayan bir fonksiyondur.

            Array isimler = new[] { "Hilmi", "Hüseyin", "Halil", "Rıfkı", "Hamdullah" };

            string[] isimler2 = new string[isimler.Length];

            Array.Copy(isimler, isimler2, 5);

            for (int i = 0; i < isimler2.Length; i++)
            {
                Console.WriteLine(isimler2[i]);
            }


            #endregion

            #region IndexOf
            //Dizi içerisinde bir elemanın var olup olmadığını sorgulayabildiğimiz fonksiyondur.

            int indexNo = Array.IndexOf(isimler, "Rıfkı");//varsa index no,yoksa -1 döner



            #endregion

            #region Reverse
            Console.WriteLine("TERSİNE ÇEVİRDİK");
            Array.Reverse(isimler);
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Sort
            Array.Sort(isimler); //Sıralama yapar
            #endregion

            #endregion


            #region Özellikler - Propertyler

            #region IsReadOnly
            //Bir dizinin sadece okunabilir olup olmadığını bool türde bildiren bir özelliktir.
          bool abc =  isimler.IsReadOnly;

            #endregion

            #region IsFixedSize

           var asdf = isimler.IsFixedSize;

            #endregion

            #endregion


            #region CreateInstance

            Array yaslar = Array.CreateInstance(typeof(int),3);
            Array cokluDizi = Array.CreateInstance(typeof(int),3,5,6,8);




            #endregion
        }
    }
}

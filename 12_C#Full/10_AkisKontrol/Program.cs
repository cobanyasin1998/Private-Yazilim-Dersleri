using System;

namespace _10_AkisKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch-case when
            int satisTutar = 1000;

            switch (satisTutar)
            {
                case 1000 when (true == true):
                    Console.WriteLine("");
                    break;
                default:
                    break;
            }

            #endregion

            #region goto
            int iGoto = 10;
            switch (iGoto)
            {

                case 5:
                    Console.WriteLine(iGoto * 10);
                    break;
                case 7:
                    goto case 5;

                case 8:
                case 9://Birden fazla goto kullanıldığı senaryo
                    goto case 5;
            }
            #endregion

            #region Switch Expression (C# 8.0)

            string mesaj = DayOfWeek.Friday switch
            {
                DayOfWeek.Sunday when DateTime.Now.Day == 1 => "Pazar ve haftanın ilk günü",
            };

            #endregion


            #region Relational Patterns - Logical Patterns (c# 9.0)

            string result = 10 switch
            {
                <50 or <40 => "50 den küçük",
                >50 => "50 den büyük",
                _ => "Hiçbiri"
            };

            #endregion
        }
    }
}

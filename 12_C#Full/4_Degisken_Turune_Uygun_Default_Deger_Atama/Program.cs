using System;

namespace _4_Degisken_Turune_Uygun_Default_Deger_Atama
{
    internal class Program
    {
        static void Main(string[] args)
        {



            bool x = default(bool);
            int y = default(int);
            string z = default(string);


            Console.WriteLine((x,y,z));


            #region Default Literals (c# 7.1)

            bool a = default;
            int b = default;
            string c = default;
            Console.WriteLine((a, b, c));
            #endregion


        }
    }
}

using System;

namespace _11_Hata_Yonetimi_Kritik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string x = "a";

            try
            {
                int s1 = 0, s2 = 10;
                int a = s2 / s1;

            }
            catch (DivideByZeroException ex) when (x == "a") 
            {

                throw;
            }
            catch (DivideByZeroException ex) when (x == "b")
            {

                throw;
            }
        }
    }
}

using System;

namespace _14_Span_ve_Memory_Turleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70 };

            Span<int> span = new Span<int>(sayilar);
            Span<int> span2 = sayilar;
            Span<int> span3 = new Span<int>(sayilar, 4, 2);

            Span<int> span4 = sayilar.AsSpan(2, 5);

            string text = "Sen kalbimde batan güneş, ben yollarda çilekeş";

            ReadOnlySpan<char> chars =text.AsSpan();


        }
    }
}

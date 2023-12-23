using System;

namespace _5_Deep_Shadow_Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DeepCopy
            //Derin Kopyalama
            //Eldeki verileri çoğaltılır, klonlanır

            int a = 5, b = a;
            //int b = a;
            a = a * 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            #endregion

            #region ShallowCopy

            var myClass1 = new MyClass();
            var myClass2 = new MyClass();
            myClass2 = myClass1;

            myClass1.Deger = 8;

            Console.WriteLine(myClass2.Deger);
            #endregion
        }
        public class MyClass
        {
            public int Deger { get; set; } = 5;
        }
    }
}

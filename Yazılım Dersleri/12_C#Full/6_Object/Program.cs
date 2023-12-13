using System;

namespace _6_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {


       
            //object türdeki bir değişkene herhangi bir türdeki değeri göndermek Boxing olarak nitelendirilmektedir.

            //Boxing
            //Unboxing
            //Cast


            int yas = 25;
            object _yas = 28;


         

          

            int dogumYili = 1998;
            object _dogumYili = dogumYili;

            int unBoxingDogumYili = (int)_dogumYili;

           



        }
    }
}

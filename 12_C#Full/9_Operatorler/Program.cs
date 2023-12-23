using System;

namespace _9_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ??= Operatörü (C# 8.0)

            string xyz = null;

            Console.WriteLine(xyz ??= "Merhaba");
            Console.WriteLine(xyz);

            #endregion



            #region sizeof

            Console.WriteLine($"int: {sizeof(int)}");

            #endregion

            #region typeof
            Type t = typeof(int);
            Console.WriteLine(t.IsPrimitive);
            Console.WriteLine(t.IsValueType);
            Console.WriteLine(t.IsClass);
            Console.WriteLine(t.Name);

            #endregion

            #region default

            Console.WriteLine(default(decimal));
            int aw = default;
            #endregion


            #region is Operatoru

            object x = true;
            Console.WriteLine(x is bool);
            Console.WriteLine(x is double);
            Console.WriteLine(x is decimal);
            if (x is Mydto)
            {
                Console.WriteLine("MYDTO True");
            }
            else
            {
                Console.WriteLine("MYDTO False");

            }
            #endregion


            #region is null

            if (x is null) // Referans türl, değişkenlerde olur
            {

            }
            if (x is not null)
            {

            }

            #endregion

            #region as operatoru

            object ahmet = "Ahmet";
            string ahmetStr = ahmet as string;
            Console.WriteLine(ahmetStr);

            #endregion

        }
    }
    public class Mydto
    {
        public int id;
    }
}

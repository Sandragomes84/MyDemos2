using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Demos.Utilities
{

    public class Math2
    {
        public static int Min(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            return y;

        }

        public static int Max(int x, int y)
        {
            if (x > y)
            {
                return x;
            }

            return y;

        }

        public static bool AreEqual(int x, int y)
        {
            return x == y;
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }



        //SWAP COM ref



        public static void Swap(ref int n1, ref int n2)
        {
            var aux = n2;
            n2 = n1;
            n1 = aux;

            Console.WriteLine("Valores correspondentes a n1 e n2: " + Math2.Swap(n1, n2));
        }

        // SWAP com out

        public static void Swap(out int n1, int n2)
        {
            int aux2;
            n1 = 100;
            n2 = 200;
            aux2 = n2;
            n2 = n1;
            n1 = aux2;

            Console.WriteLine("Valores correspondentes a n1 e n2: " + Math2.Swap(n1, n2));

        }



        //SWAP com tuplo 

        public static (int, int) Swap(int n1, int n2)
        {
            return (n1, n2);

        }


        // SWAP com out e tuplo

        public static (int, int) Swapp(out int n10, out int n20)
        {
            int aux2;
            n10 = 1000;
            n20 = 2000;
            aux2 = n20;
            n20 = n10;
            n10 = aux2;

            return (n10, n20);


        }



        //Min2 e Max2


        public static int Max2(int xx, int yy)
        {
            return (xx > yy) ? xx : yy; //ternario- se x > y = Verdadeiro retorna x....se não, retorna y
        }

        public static int Min2(int xx, int yy)
        {
            return (xx < yy) ? xx : yy;
        }


    }

}

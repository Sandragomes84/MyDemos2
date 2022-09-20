using System;


namespace Demos.Utilities
{
    public static class Clock

    {
        public static int TotalSegundos(int minutos, int segundos)
        {

            return minutos * 60 + segundos;

        }


        //tuplo

        public static (int Minutos, int Segundos) TotalMinutoseSegundos(int totalsegundos)
        {

            int minutos = totalsegundos / 60;
            int segundos = totalsegundos % 60;

            return (minutos, segundos);

        }



    }
}

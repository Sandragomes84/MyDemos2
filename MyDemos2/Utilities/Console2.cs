using System;
namespace Demos.Utilities;

public static class Console2
{

    public static int ReadInt(string mensagem)
    {
        Console.WriteLine(mensagem);

        string str = Console.ReadLine();

        int result;
        var isok = int.TryParse(str, out result);

        return result;
    }

    public static double ReadDouble(string message)
    {
        Console.WriteLine(message);

        string str = Console.ReadLine();

        double result;
        var isok = double.TryParse(str, out result);

        return result;
    }


    public static void PrintNumbersOrderBy(int a, int b, int c, bool isAsc)
    {
        int aux;

        if (a > b)
        {
            aux = a;
            a = b;
            b = aux;
        }

        if (b > c)
        {
            aux = c;
            c = b;
            b = aux;
        }

        if (a > b)
        {
            aux = a;
            a = b;
            b = aux;
        }

        if (isAsc)
        {
            Console.WriteLine($"{a}, {b},{c}");
        }

        else
        {
            Console.WriteLine($"{c}, {b},{a}");
        }

    }



    public static bool ReadInt(string mensagem, out int result)
    {

        Console.WriteLine(mensagem);
        return int.TryParse(Console.ReadLine(), out result);

    }

}
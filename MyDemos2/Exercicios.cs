using Demos.Utilities;
using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

public static class Exercicios
{
    // Representar um aumento de 20% sobre o salário

    public static void CalcularSalario()
    {
        double salario = Console2.ReadDouble("Qual o salário base?");
        double incrementoPercentual = 0.20;
        Console.WriteLine("O salário final é {0}", salario * (1 + incrementoPercentual));
    }




    // Dado um determinado preço de produto, aplicar um desconto e mostrar o preço final

    public static void AplicarDesconto()
    {
        double preco;
        int desconto;
        double precoFinal;

        preco = Console2.ReadDouble("Qual o preço?");

        desconto = Console2.ReadInt("Qual o desconto (1 0 10)?");

        precoFinal = preco - (preco * (desconto / 100.0));

        Console.WriteLine("{0}€ com desconto {1}% dá {2}€", preco, desconto, precoFinal);

    }


    //Identificar o Numero maior

    public static void IdentificarMaior()
    {
        int N1, N2;

        Console.WriteLine(" Digite N1");
        N1 = int.Parse(Console.ReadLine());

        Console.WriteLine(" Digite N2");
        N2 = int.Parse(Console.ReadLine());

        if (N1 == N2)
        {
            Console.WriteLine(" São iguais ");
        }

        else if (N1 > N2)
        {

            Console.WriteLine(" N1 é o maior ");
        }

        else
        {
            Console.WriteLine(" N2 é o maior ");
        }

    }


    // Dias da Semana - If, else, else if - While


    public static void PrintDiasSemana(int diaSemana)
    {
        if (diaSemana == 1)
        {
            Console.WriteLine("segunda-feira");
        }
        else if (diaSemana == 2)
        {
            Console.WriteLine("terça-feira");
        }
        else if (diaSemana == 3)
        {
            Console.WriteLine("quarta-feira");
        }
        else if (diaSemana == 4)
        {
            Console.WriteLine("quinta - feira");
        }
        else if (diaSemana == 5)
        {
            Console.WriteLine("sexta-feira");
        }
        else if (diaSemana == 6)
        {
            Console.WriteLine("sábado");
        }
        else if (diaSemana == 7)
        {
            Console.WriteLine("domingo");
        }

    }

    public static void DiasSemanaWithWhile()
    {
        int diaSemana = 5;


        while (diaSemana > 7 || diaSemana < 1)
        {
            Console.Clear();
            diaSemana = Console2.ReadInt("Insira um número para identificar o dia da semana [1,7]");

            Exercicios.PrintDiasSemana(diaSemana);

        }

        Console.WriteLine("Hasta la Vista");
    }





    public static void PrintWeekdaysWithSwitch(int diaSemana)
    {
        switch (diaSemana)
        {
            case 1:
                Console.WriteLine("2ª-feira");
                break;
            case 2:
                Console.WriteLine("3ª-feira");
                break;
            case 3:
                Console.WriteLine("4ª-feira");
                break;
            case 4:
                Console.WriteLine("5ª-feira");
                break;
            case 5:
                Console.WriteLine("6ª-feira");
                break;
            case 6:
                Console.WriteLine("Sábado");

                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Invalido");
                break;
        }

    }


    public static void diasSemanaWithDoWhile()
    {
        int diaSemana;

        do
        {
            Console.Clear();

            diaSemana = Console2.ReadInt("Insira um número para identificar o dia da semana [1,7]");

            PrintWeekdaysWithSwitch(diaSemana);

        }
        while (diaSemana > 7 || diaSemana < 1);
    }


}
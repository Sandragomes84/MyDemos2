// See https://aka.ms/new-console-template for more information
using System;
using Demos.Utilities;
using System;
using System.Diagnostics.Tracing;

int x = 10;
int y = 20;
int n1 = 100;
int n2 = 200;
int n10 = 1000;
int n20 = 2000;


int min = Math2.Min(x, y);
int max = Math2.Max(x, y);
bool equal = Math2.AreEqual(x, y);
int sum = Math2.Sum(x, y);

Console.WriteLine(" O valor inteiro mínimo é: " + min);
Console.WriteLine(" O valor inteiro máximo é: " + max);
Console.WriteLine(" Os valores são iguais ? " + equal);
Console.WriteLine(" O valor da soma é: " + sum);


Console.WriteLine("..............................");

//Max2 e Min 2 - Ternário


int xx = 20; int yy = 58;


int maximo = Math2.Max2(xx, yy);
int minimo = Math2.Min2(xx, yy);


Console.WriteLine(" O valor inteiro máximo é: " + maximo);
Console.WriteLine(" O valor inteiro mínimo é: " + minimo);

Console.WriteLine("..............................");


//SWAPS


Math2.Swap(ref n1, ref n2);
Math2.Swap(out n1, n2);
Console.WriteLine("Valores Correspondentes a N1 e N2: " + Math2.Swap(n1, n2));
Console.WriteLine("Valores Correspondentes a N1 e N2: " + Math2.Swapp(out n10, out n20));

Console.WriteLine("..............................");


//TUPLO



int minutos = 20;
int segundos = 10;


Console.WriteLine(" O total de segundos é : " + Clock.TotalSegundos(minutos, segundos));


var time = Clock.TotalMinutoseSegundos(1500);

Console.WriteLine("A resposta em minutos e segundos:" + time);

Console.WriteLine("..............................");

//Ordenar Numeros

int a = 20; int b = 30; int c = 10;


Console2.PrintNumbersOrderBy(a, b, c, true);
Console2.PrintNumbersOrderBy(a, c, b, true);
Console2.PrintNumbersOrderBy(b, a, c, true);
Console2.PrintNumbersOrderBy(b, c, a, true);


Console.WriteLine("..............................");

Console2.PrintNumbersOrderBy(a, b, c, false);

Console.WriteLine("..............................");


//ReadInt e ReadDouble - TRY PARSE      


var ano = Console2.ReadInt("Insira o ano atual");

Console.WriteLine("O Ano atual é: " + ano);


var altura = Console2.ReadDouble("Insira a sua altura em metro");

Console.WriteLine("A sua altura é de " + altura + " metros.");


Console.WriteLine("..............................");



// While

int diaSemana = Console2.ReadInt("Insira um número para identificar o dia da semana [1,7]");


while (diaSemana > 7 || diaSemana < 1)
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
    else
    {
        Console.WriteLine("Inválido");
    }

    Console.WriteLine("Hasta la Vista");

}

//do while - executa sempre , pelo menos, 1 vez

int diasSemana = Console2.ReadInt("Insira um número para identificar o dia da semana [1,7]");

do
{

    if (diasSemana == 1)
    {
        Console.WriteLine("segunda-feira");
    }
    else if (diasSemana == 2)
    {
        Console.WriteLine("terça-feira");
    }
    else if (diasSemana == 3)
    {
        Console.WriteLine("quarta-feira");
    }
    else if (diasSemana == 4)
    {
        Console.WriteLine("quinta - feira");
    }
    else if (diasSemana == 5)
    {
        Console.WriteLine("sexta-feira");
    }
    else if (diasSemana == 6)
    {
        Console.WriteLine("sábado");
    }
    else if (diasSemana == 7)
    {
        Console.WriteLine("domingo");
    }
    else
    {
        Console.WriteLine("Numero inválido");

    }

}
while (diasSemana > 7 || diasSemana < 1);


//ReadInt - Bool

var isok = Console2.ReadInt("Que dia é hoje?", out int dia);
var mensagem = isok ? dia.ToString() : "Nº inválido";
Console.WriteLine(mensagem);

Console.Read();



// podia fazer desta forma:
/*
int dia;
bool isok;

isok = Console2.ReadInt("Que dia í hoje?", out dia);

if (isok == true)
{
    Console.WriteLine(dia);
}

else
{
    Console.WriteLine("Numero Invalido");
}

*/

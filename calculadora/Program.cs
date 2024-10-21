




using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
namespace Calculadora2
{
class Program
{
static void Main(string [] args)
{
    Menu();

}

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("-------");
    Console.WriteLine("Escolha umas das opções");
    short res = short.Parse(Console.ReadLine());
    switch (res){
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5 : System.Environment.Exit(0); break;
        default: Menu(); break;
    }

}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor:");
    int valor1 = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    
    Console.WriteLine("Segundo valor:");
    int valor2 = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    int resultado = valor1 + valor2;
    Console.WriteLine($"o resultado da soma é {valor1 + valor2}");
    Console.ReadKey();

}


static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Valor inicial");
    int valor1 = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("Valor final");
    int valor2 = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    int resultado = valor1 - valor2;
    Console.WriteLine($"o valor da subtração é {valor1 - valor2}");
    Console.ReadKey();
}


static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Valor inicial");
    int valor1 = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("Valor final");
    int valor2 = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    int resultado = valor1 * valor2;
    Console.WriteLine($"O resultado da amultiplicação é {valor1 * valor2}");
    Console.ReadKey();
}


static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor");
    int valor1 = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("sEGUNDO VALOR");
    int valor2 = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    int resultado = valor1 / valor2;
    Console.WriteLine($"o valor da divisão é {valor1 / valor2}");
    Console.ReadKey();
}


}
}

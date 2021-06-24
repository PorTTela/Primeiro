using System;
using System.Globalization;

namespace Entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco();

           
            
            Console.Write("Entre com o numero da conta: ");
            b.NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da conta: ");
            b.Nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (S/N) ?");
            char depo = char.Parse(Console.ReadLine());
            b.DepositoInicial(depo);

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(b);
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double d = double.Parse(Console.ReadLine());
            b.Deposito(d);
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(b);

            Console.Write("Entre com um valor para Saque: ");
            d = double.Parse(Console.ReadLine());
            b.Saque(d);
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(b);


        }
    }
}

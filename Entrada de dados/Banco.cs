using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Entrada_de_dados
{
    class Banco
    {
        public int NumeroConta { get; set; }
        public string _nome;
        public double Saldo { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        public void DepositoInicial(char x)
        {
            if (x == 's' || x == 'S')
            {
                Console.Write("Entre com o valor do depósito Inicial: ");
                Saldo = double.Parse(Console.ReadLine());
            }

        }

        public void Deposito(double x)
        {
            Saldo += x;
        }

        public void Saque(double x)
        {
            Saldo -= 5 + x;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + _nome.ToString()
                + ", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}

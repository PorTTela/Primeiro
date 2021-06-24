using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Entrada_de_dados
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto, Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double a)
        {
            SalarioBruto = SalarioBruto +(SalarioBruto / 100 * a);

        }

        public override string ToString()
        {
            return Nome + ", "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankHerancaInterface.Funcionarios
{
    public class GerenteConta : Funcionario
    {
        public GerenteConta(double salario, string cpf) : base(salario, cpf)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

         public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        

    }
}

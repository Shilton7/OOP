using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankHerancaInterface.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(double salario, string cpf) : base(salario,cpf)
        {

        }

        public override double GetBonificacao()
        {
            //return Salario;
            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.15);
            //Salario *= 1.15;
        }

    }
}

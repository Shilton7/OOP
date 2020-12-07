using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankHerancaInterface.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf)
        {

        }

        public override double GetBonificacao()
        {
            //return Salario;
            return Salario + base.GetBonificacao();
        }

    }
}

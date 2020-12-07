using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankHerancaInterface.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            //return Salario;
            return Salario + base.GetBonificacao();
        }

    }
}

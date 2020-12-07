using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankHerancaInterface.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(string cpf)
        {
            CPF = cpf;
            TotalFuncionarios++;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public int GetTotalFuncionarios()
        {
            return TotalFuncionarios;
        }

    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankHerancaInterface.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
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

        public virtual void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.1);
            //Salario *= 1.1;
        }

    }
}


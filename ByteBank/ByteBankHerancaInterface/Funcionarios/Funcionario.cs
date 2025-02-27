﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankHerancaInterface.Funcionarios
{
    public abstract class Funcionario
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

        public int GetTotalFuncionarios()
        {
            return TotalFuncionarios;
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();

    }
}


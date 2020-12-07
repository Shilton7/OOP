using ByteBankHerancaInterface.Funcionarios;
using System;

namespace ByteBankHerancaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
     
            GerenciadorBonificacao bonificacao = new GerenciadorBonificacao();

            Funcionario funcionario = new Funcionario("123.784.154-70");

            funcionario.Nome = "Shilton";
            funcionario.Salario = 2000;
            var valorBonificacao = funcionario.GetBonificacao();
            bonificacao.Registrar(funcionario);

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.CPF);
            Console.WriteLine(valorBonificacao);
            Console.WriteLine(funcionario.GetTotalFuncionarios());

            Diretor diretor = new Diretor("544.877.154-19");

            diretor.Nome = "Chefe";
            diretor.Salario = 5000;
            bonificacao.Registrar(diretor);

            Console.WriteLine(diretor.Nome);
            Console.WriteLine(diretor.CPF);
            Console.WriteLine(diretor.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + bonificacao.GetTotalBonificacao());
            Console.WriteLine(funcionario.GetTotalFuncionarios());
            Console.ReadLine();

        }
    }
}

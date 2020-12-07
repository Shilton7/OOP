using ByteBankHerancaInterface.Funcionarios;
using System;

namespace ByteBankHerancaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
     
            GerenciadorBonificacao bonificacao = new GerenciadorBonificacao();

            Funcionario funcionario = new Funcionario();

            funcionario.Nome = "Shilton";
            funcionario.CPF = "1234567897-08";
            funcionario.Salario = 2000;
            var valorBonificacao = funcionario.GetBonificacao();
            bonificacao.Registrar(funcionario);

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(valorBonificacao);

            Diretor diretor = new Diretor();

            diretor.Nome = "Chefe";
            diretor.CPF = "1231331321";
            diretor.Salario = 5000;
            bonificacao.Registrar(diretor);

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(diretor.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + bonificacao.GetTotalBonificacao());
            Console.ReadLine();

        }
    }
}

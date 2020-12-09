using ByteBankHerancaInterface.Funcionarios;
using System;

namespace ByteBankHerancaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
     
            GerenciadorBonificacao bonificacao = new GerenciadorBonificacao();

            Funcionario funcionario = new Funcionario(2000, "123.784.154-70");

            funcionario.Nome = "Shilton";
            var valorBonificacao = funcionario.GetBonificacao();
            bonificacao.Registrar(funcionario);

            funcionario.AumentarSalario();
            Console.WriteLine("Novo salário: " + funcionario.Salario);


            Console.WriteLine("Nome do funcionário: " + funcionario.Nome);
            Console.WriteLine("CPF do funcionário: " + funcionario.CPF);
            Console.WriteLine("Valor da Bonificação do funcionário: " + valorBonificacao);
            Console.WriteLine("Total de funcionários: " + funcionario.GetTotalFuncionarios());
            Console.WriteLine("---------------------------------------------------------------");

            Diretor diretor = new Diretor(5000,"544.877.154-19");

            diretor.Nome = "Chefe";
            bonificacao.Registrar(diretor);

            diretor.AumentarSalario();
            Console.WriteLine("Novo salário: " + diretor.Salario);

            Console.WriteLine("Nome do diretor: " + diretor.Nome);
            Console.WriteLine("CPF do diretor: " + diretor.CPF);
            Console.WriteLine("Valor da Bonificação do diretor: " + diretor.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + bonificacao.GetTotalBonificacao());
            Console.WriteLine("Total de funcionários: " + funcionario.GetTotalFuncionarios());
            Console.ReadLine();

        }
    }
}

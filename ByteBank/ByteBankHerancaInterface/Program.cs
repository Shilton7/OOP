using ByteBankHerancaInterface.Funcionarios;
using System;

namespace ByteBankHerancaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Informar();
        }

        public static void Informar()
        {
            GerenciadorBonificacao bonificacao = new GerenciadorBonificacao();

            /* Gerente */
            GerenteConta gerente = new GerenteConta(2000, "123.784.154-70");

            gerente.Nome = "Shilton Gerente";
            var valorBonificacao = gerente.GetBonificacao();
            bonificacao.Registrar(gerente);

            gerente.AumentarSalario();
            Console.WriteLine("Novo salário: " + gerente.Salario);

            Console.WriteLine("Nome do gerente: " + gerente.Nome);
            Console.WriteLine("CPF do gerente: " + gerente.CPF);
            Console.WriteLine("Valor da Bonificação do gerente: " + valorBonificacao);
            Console.WriteLine("Total de funcionários: " + gerente.GetTotalFuncionarios());
            Console.WriteLine("---------------------------------------------------------------");

            /* Diretor */
            Diretor diretor = new Diretor(5000, "544.877.154-19");

            diretor.Nome = "Chefe Diretor";
            bonificacao.Registrar(diretor);

            diretor.AumentarSalario();
            Console.WriteLine("Novo salário: " + diretor.Salario);

            Console.WriteLine("Nome do diretor: " + diretor.Nome);
            Console.WriteLine("CPF do diretor: " + diretor.CPF);
            Console.WriteLine("Valor da Bonificação do diretor: " + diretor.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + bonificacao.GetTotalBonificacao());
            Console.WriteLine("Total de funcionários: " + gerente.GetTotalFuncionarios());
            Console.ReadLine();
        }
    }
}

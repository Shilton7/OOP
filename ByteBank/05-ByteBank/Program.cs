using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.nome = "Shilton";
            cliente.cpf = "123.456.789-09";
            cliente.profissao = "Dev";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = cliente;
            conta.agencia = 21234;
            conta.numero = 212;
            conta.saldo += 71;

            Console.WriteLine("Nome: " + conta.titular.nome);
            Console.WriteLine("Cpf: " + conta.titular.cpf);
            Console.WriteLine("Profissao: " + conta.titular.profissao);
            Console.WriteLine("Agencia: " + conta.agencia);
            Console.WriteLine("Numero: " + conta.numero);
            Console.WriteLine("Saldo: " + conta.saldo);
            Console.WriteLine("Idade: " + conta.titular.idade);

            Console.ReadLine();

        }
    }
}

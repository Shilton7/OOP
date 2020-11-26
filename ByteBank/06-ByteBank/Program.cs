using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Saldo = 71;
            Console.WriteLine(conta.Saldo);


            Cliente cliente = new Cliente();

            cliente.Nome = "Shilton";
            cliente.Idade = 70;
            conta.Titular = cliente;

            Console.WriteLine(cliente.Nome);
            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();
        }
    }
}

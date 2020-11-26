using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Shilton";

            Console.WriteLine("Titular: " + conta.titular);
            Console.WriteLine("Saldo em reais: R$ " + conta.saldo);
        }
    }
}

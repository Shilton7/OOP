using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaShilton = new ContaCorrente();

            Console.WriteLine("Saldo Anterior do Shilton " + contaShilton.saldo);

            bool resultado = contaShilton.Sacar(20);

            Console.WriteLine("Resultado do saque do Shilton: " + resultado);
            Console.WriteLine("Saldo Atual do Shilton: " + contaShilton.saldo);

            contaShilton.Depositar(71);
            Console.WriteLine("Saldo atualizado após depositar do Shilton: " + contaShilton.saldo);

            ContaCorrente contaFabio = new ContaCorrente();

            bool statusResultadoTransf = contaShilton.Transferir(11, contaFabio);
            Console.WriteLine("Status da transferência do Shilton: " + statusResultadoTransf);
            Console.WriteLine("Saldo Atual do Shilton: " + contaShilton.saldo);

            Console.WriteLine("Saldo Atual da conta do Fabio, após a transferência feita pelo Shilton: " + contaFabio.saldo);

            Console.ReadLine();
        }
    }
}

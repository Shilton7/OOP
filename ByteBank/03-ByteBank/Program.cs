using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoShilton = new ContaCorrente();

            contaDoShilton.titular = "Shilton";
            contaDoShilton.agencia = 881;
            contaDoShilton.numero = 121545;

            ContaCorrente contaDoShiltonLopes = new ContaCorrente();

            contaDoShiltonLopes.titular = "Shilton";
            contaDoShiltonLopes.agencia = 881;
            contaDoShiltonLopes.numero = 121545;

            //Tipo de refências diferentes
            Console.WriteLine(contaDoShilton == contaDoShiltonLopes);

            //Tipo de valor iguais
            Console.WriteLine(contaDoShilton.agencia == contaDoShiltonLopes.agencia);

            //Tipo de refências iguais
            contaDoShilton = contaDoShiltonLopes;
            Console.WriteLine(contaDoShilton == contaDoShiltonLopes);

            //Tipo de refêrencia sendo compartilhados no mesmo objeto na memoria
            contaDoShilton.saldo = 300;
            Console.WriteLine(contaDoShiltonLopes.saldo); //300
            Console.WriteLine(contaDoShilton.saldo); //300

            Console.ReadLine();

        }
    }
}

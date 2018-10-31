using System;

namespace sistemacomparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 1;
            do
            {

                Comparacao comparacao = new Comparacao();

                Console.WriteLine("Informe o Primeiro Numero: ");
                comparacao.numero1Tela = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Informe o Segundo Numero: ");
                comparacao.numero2Tela = Int32.Parse(Console.ReadLine());

                Console.WriteLine(comparacao.comparar());

                Console.WriteLine("\n\nDeseja continuar: \n1 - Sim\n2 - Nao");
                test = Int32.Parse(Console.ReadLine());

            } while (test == 1);
        }
    }
}

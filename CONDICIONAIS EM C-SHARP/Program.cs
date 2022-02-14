using System;

namespace CONDICIONAIS_EM_C_SHARP
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("DESCUBRA SE O NUMERO E PAR OU IMPAR\n");
            Console.WriteLine("Entre com um numero inteiro");
            int x = int.Parse(Console.ReadLine());

            if ( x % 2 == 0) // essa condição if so para executar coisas verdadeiras 
            {
                Console.WriteLine("Par!");
            }
            else// else executa condiões falsas 
            {
                Console.WriteLine("impar");
            }

           


        }
    }
}

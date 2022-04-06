using System;

namespace Aula_6_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // declarando a variavel 
            int f, c, n;

            //perguntando ao usuario qual tabuada ele quer saber
            Console.WriteLine("Digite o numero da tabuada que deseja saber \n" );
            //convertendo string em int
            n = Int32.Parse(Console.ReadLine());


    
            
            for (c =0; c <= 10; ++c)
            {
                f = n * c;
                Console.WriteLine ($" {n} x {c}  = {n*c}\n");

            }

            Console.WriteLine("Muito obrigado por usar nosso cálculo de tabuada!");
            Console.ReadKey();
        }
    }
}
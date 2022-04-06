using System;

namespace Aula_6_loops
{
    class Program
    {
        static void Main(string[] args)
        {   
            //WriteLine printa e pula uma linha
            Console.WriteLine("Tabuada! \n");

            //uso o x++ pq estou multiplicando de 1 em 1 numero
            for(int x = 1; x <= 10; x++)
            {
                for(int y = 1; y <= 10; y++)
                {
                    //Console.WriteLine(x + " x " + y + " = " + x * y);
                    Console.WriteLine($"{x} x {y} = {x*y}");
                    //codigo de cima (linha 18) esta interpolando, porem o da linha 17 tbm funciona

                    // utilizando o break abaixo, eu paro a calculadora no x5
                    if (y ==5){
                        break;
                    }
                }

            }

        }
    }
}

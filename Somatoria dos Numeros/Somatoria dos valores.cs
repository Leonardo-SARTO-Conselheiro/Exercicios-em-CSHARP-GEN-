using System;

namespace Aula6VS__Loops_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            for (int i = 1; i <= 20; i++) //i++ para ir de numero em numero.
                // uso o i = 1 para a contagem começar do 1, se fosse i = 0, começaria do 0
                // <= 20 pra considerar os numeros somente iguais ou menores que 20, 
                // como usei i = 1 ela começa do 1 e não do 0
            {
                Console.WriteLine($"Posição {i} Digite o valor que deseja somar {valor}: ");
                //uso esse "valor" para mostrar o valor das somas já realizadas
                valor += int.Parse(Console.ReadLine());
                //valor = valor + int.Parse(Console.ReadLine()); 
                //posso fazer desse jeito ou somente colocar o + antes do = na linha 15

            }

            Console.WriteLine($"Somatoria dos valore inseridos: {valor}");
            //O $ está fazendo referencia a valor  
            //Console.WriteLine("Somatoria dos valores inseridos: " + valor);
            //usaria da forma acima se eu não tivesse interpolando com o $
            //O $ esta interpolando, se eu não usasse ele teria que usar o + 


        }
    }
}

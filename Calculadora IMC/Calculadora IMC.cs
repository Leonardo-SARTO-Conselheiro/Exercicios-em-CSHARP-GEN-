using System;

namespace Calculadora_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float peso;
            float imc;
            int idade;

            //ReadLine é para a entrada de dados, como o da altura, peso
            Console.WriteLine("Qual se nome? ");
            string none = Console.ReadLine();

            //Parse é semelhante ao Convert
            Console.WriteLine("Qual sua altura? ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua idade? ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu peso? ");
            peso = float.Parse(Console.ReadLine());

            //WriteLine para printar a tela (saida de dados)
            imc = peso / (altura * altura);
            Console.WriteLine("Seu IMC é: " + imc);

            if(imc < 18.5){
                Console.WriteLine("Você está abaixa do do peso");
            }
            
            else if(imc < 25){
                Console.WriteLine("Você está com o peso normal");
            }

             else if(imc < 30){
                Console.WriteLine("Você está com sobrepeso");
            }

            else{
                Console.WriteLine("Voce está acima do peso");
            }




        }
    }
}

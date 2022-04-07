using System;

namespace Calculadora
{
      class Program
    {
        static void Main(string[] args)
        {
            string desligar = "0";
            

            Console.WriteLine("\nCalculadora\n");
            Console.WriteLine("Digite a tecla 1 para ligar a calculadora");
            string ligar = Console.ReadLine();
            if (ligar == "1")
            {

            while (desligar != "1")
            {
        
            Console.Write("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o operador: ");
            string operador = Console.ReadLine();

            Console.Write("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (operador)
            {
                case "+":
                Console.WriteLine ($"Resultado: {Somar (num1, num2)}");
                break;
                case "-":
                Console.WriteLine ($"Resultado: {Subtrair (num1, num2)}");
                break;
                case "*":
                Console.WriteLine ($"Resultado: {Multiplicar (num1, num2)}");
                break;
                case "/":
                Console.WriteLine ($"Resultado: {Dividir (num1, num2)}");
                break;
                default:
                Console.WriteLine("Oprador Invalido");
                break;
            }

            Console.WriteLine("\nDeseja continuar usando a calculadora?\nDigite sim para reiniciar ou '1' para desligar");
            desligar = Console.ReadLine();
            
            

         }
       
        }
        

        else{
            Console.WriteLine("\nVocê não digitou a tecla correta para ligar :(\nDigite 1 se deseja ligar a calculadora");
        }

            Console.WriteLine("Obrigado por utilizar nossos serviços\nVolte sempre!");
        }


        //uso o static para dar o parametro do Somar, para chamar ele direto
        // string é para definir que vai retornar uma string.
        // Somar é o nome do metodo 
        // o entre () são os parametros desse metodo
      public static string Somar(int num1, int num2) 
        {  
            return (num1 + num2).ToString();
        }

        public static string Subtrair(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }

        public static string Multiplicar(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }

        //Método
        public static string Dividir(int num1, int num2)
        {
            if(valorDividendoMenorOuIgualQueZero(num2))
            {
                return "Não é possivel dividir por zero ou menor que zero";
            }
            return (num1 / num2).ToString();

    

            //definindo uma função
            bool valorDividendoMenorOuIgualQueZero(int num2)
            {
                if (num2 <=0)
                {    
                    return true;
                }
                    return false;
            }
        }
    }
}


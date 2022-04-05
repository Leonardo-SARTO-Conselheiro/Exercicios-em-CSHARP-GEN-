using System;

namespace VisualStudioCode
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Entre com o valor mensal das suas vendas:");
            //double.parse converte a string para numeros INTeiros
            double valorVendido = double.Parse(Console.ReadLine()); 

            //se ela vender menos de 10000 a comissão dela vai ser de 0.01 
            if(valorVendido <= 10000){
                Console.WriteLine("O valor a receber é: R$ " + (valorVendido * 0.01));
            }

            else if (valorVendido <= 20000){
                Console.WriteLine("O valor a receber é: R$ " + (valorVendido * 0.02));
            }

            else if (valorVendido <= 30000){
                Console.WriteLine("O valor a receber é: R$ " + (valorVendido * 0.03));
            }

            else{
                Console.WriteLine("O valor a receber é: R$ " + (valorVendido * 0.1));
            }

        }
    }
}

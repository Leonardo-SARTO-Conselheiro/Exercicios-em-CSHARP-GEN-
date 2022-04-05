using System;

namespace Aula05VS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int valor = 9;

            //if (valor == 5) 
            //{
            //Console.WriteLine("O Valor é 5");
            //}

            //else
            //{
            //Console.WriteLine("Não é o valor 5");
            //}

            //if e else simples

            //===========================================

            //bool condicaoCursoConcluido = true;
            //int condicaoQuantidadeCursoConcluido = 26;
            //bool condicaoQuitacao = true;
            //bool condicaoDevolverLivro = true;

            //if (condicaoCursoConcluido == true && 
            // condicaoQuantidadeCursoConcluido >= 25 &&
            //condicaoQuitacao == true &&
            //condicaoDevolverLivro == true)
            //{
            //Console.WriteLine("Você foi aprovado");
            //}
            //else
            //{
            //Console.WriteLine("Você foi Reprovado");
            //}

            //nesse caso todas as condições foram true, então ele foi aprovado, 
            //se eu tivesse colocado alguma com true, ele seria repovado

            //==================================================================================

            Console.WriteLine("Você concluiu o curso? (sim ou não): ");
            string condicaoCursoConcluido = Console.ReadLine();

            Console.WriteLine("Quantos cursos você concluiu? : ");
            int condicaoQuantidadeCursoConcluido = Convert.ToInt32(Console.ReadLine() );

            Console.WriteLine("Você pagou todas as mensalidas? (sim ou não)");
            string condicaoQuitacao = Console.ReadLine();

            Console.WriteLine("Você devolveou todos os livros? (sim ou não)");
            string condicaoDevolverLivro = Console.ReadLine();



            if (condicaoCursoConcluido == "sim"  &&
                condicaoQuantidadeCursoConcluido >= 25 &&
                condicaoQuitacao == "sim" &&
                condicaoDevolverLivro == "sim")
            {
                Console.WriteLine("Você foi aprovado");
            }
            else
            {
                Console.WriteLine("Você foi Reprovado");
            }
            
            //Respondendo o usuario, conforme as informações inseridas por ele

            }
        }
    }


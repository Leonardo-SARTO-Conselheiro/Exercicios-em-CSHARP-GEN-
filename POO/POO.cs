using testepoo;
using System;

namespace testepoo.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sessãozinha\n");
            Essencia Ziggy = new Essencia("Ziggy", "Melância", 8, 5);
            Essencia Zomo = new Essencia("Zomo", "Menta", 5, 7);
            Essencia NAY = new Essencia("NAY", "Cereja", 10, 10 );
            Essencia Pimp = new Essencia("Pimp", "Uva", 7, 15);

            Console.WriteLine($"Essência 1 é da {Ziggy.Nome} de sabor {Ziggy.Sabor} e a quantidade por pack é de {Ziggy.Quantidade} unidades e cada unidade custa {Ziggy.Preço} reais");
            Console.WriteLine($"Essência 2 é da {Zomo.Nome} de sabor {Zomo.Sabor} e a quantidade por pack é de {Zomo.Quantidade} unidades e cada unidade custa {Zomo.Preço} reais");
            Console.WriteLine($"Essência 3 é da {NAY.Nome} de sabor {NAY.Sabor} e a quantidade por pack é de {NAY.Quantidade} unidades e cada unidade custa {NAY.Preço} reais");
            Console.WriteLine($"Essência 4 é da {Pimp.Nome} de sabor {Pimp.Sabor} e a quantidade por pack é de {Pimp.Quantidade} unidades e cada unidade custa {Pimp.Preço} reais");

            //fazendo um passo a passo básico de como acender um nargas
            //Fixando POO com essas instruções 
            //Ficou um pouco confuso "ziggy estou acendendo um rosh" mas eu entendi o conceito de POO

            Ziggy.acendendo("o rosh");
            Pimp.fumando("um nargas");
            Zomo.fumar();
            string retorno = NAY.passando();
            Console.WriteLine(retorno);
        }
    }
}
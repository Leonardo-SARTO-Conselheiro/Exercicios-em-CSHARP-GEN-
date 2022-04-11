using System;
using System.Collections.Generic;
using Zoologico.src;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológico!");

            List<Animal> animais = new List<Animal>(
                new Animal[]{
                    new Gato("Gato Lucky", "Cinza", "Felino"),
                    new Cachorro("Cachorro Dory", "Preto", "Canídio"),
                    new Macaco("Macaco Tom", "Colorido", "Primata"),
                    new Cachorro("Cachorro Sunny", "Marrom", "Canídio"),
                    new Gato("Gato Zoe", "Branca", "Felino"),
                    new Macaco("Macaco Brad", "Amarelo", "Primata")
                }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "Canídio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Au au!");
                }
                else if (animal.Classificacao == "Felino")
                {
                     Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Miau!");
                }

                else if(animal.Classificacao == "Primata")
                {
                     Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("UAAA!");
                }
            }

        }
    }
}

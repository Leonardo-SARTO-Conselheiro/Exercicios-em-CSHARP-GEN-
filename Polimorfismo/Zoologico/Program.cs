using System;
using System.Collections.Generic;
using Zoologico.src;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>(
                new Animal[]{
                    new Elefante("Dumbo", "Azul", "Proboscidea", "Médio","Herbívora"),
                    new Girafa("Melman", "Amarela", "Giraffidae", "Médio","Herbívora"),
                    new Jacaré("Totodile", "Azul", "Crocodylia", "Baixo", "Carnivora"),
                    new Leão("Simba", "Castanho", "Felino", "Grande", "Carnivora"),
                    new Zebra("Alex", "Preto e Branco", "Equus", "Baixo", "Herbívora")
                }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "Proboscidea")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor}, é um {animal.Classificacao}, o seu risco de extinção é {animal.Extinção} e sua halimentação é {animal.Alimentação}");
                    animal.Comunicar("Huuuuuuuu");
                    animal.Vontade("Beber água");
                } 
                else if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor}, é um {animal.Classificacao}, o seu risco de extinção é {animal.Extinção} e sua halimentação é {animal.Alimentação}");
                    animal.Comunicar("AAAAAAAAU!");
                    animal.Vontade("Caçar");
                }
                else if (animal.Classificacao == "Giraffidae")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor}, é um {animal.Classificacao}, o seu risco de extinção é {animal.Extinção} e sua halimentação é {animal.Alimentação}");
                    animal.Comunicar("Haaaaaa");
                    animal.Vontade("Pegar a folha mais alta da arvore");
                }
                else if (animal.Classificacao == "Equus")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor}, é um {animal.Classificacao}, o seu risco de extinção é {animal.Extinção} e sua halimentação é {animal.Alimentação}");
                    animal.Comunicar("Huhuhuh");
                    animal.Vontade("Viver feliz, sem fugir dos leões");
                }
                else if (animal.Classificacao == "Crocodylia")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor}, é um {animal.Classificacao}, o seu risco de extinção é {animal.Extinção} e sua halimentação é {animal.Alimentação}");
                    animal.Comunicar("HROOOOO!");
                    animal.Vontade("Passarinho pousar em min");
                }
            
            }

            

        }
    }
}
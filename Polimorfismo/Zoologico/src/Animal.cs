using System;

namespace Zoologico.src
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Classificacao { get; set; }
        public string Extinção {get; set; }
        public string Alimentação {get; set;}

        public Animal(){ }

        public Animal(string nome, string cor, string classificacao, string extinção, string alimentação)
        {
            Nome = nome;
            Cor = cor;
            Classificacao = classificacao;
            Extinção = extinção;
            Alimentação = alimentação;

        }

        public virtual void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} está falando: {comunicacao}");
        }
        public virtual void  Vontade(string vontade)
        {
            Console.WriteLine($"{Nome} está com vontade de: {vontade}");
        }
    }
}
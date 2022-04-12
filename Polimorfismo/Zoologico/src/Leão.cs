using System;

namespace Zoologico.src
{
    public class Leão : Animal
    {
        public Leão() { }

        public Leão(string nome, string cor, string classificacao, string extinção, string alimentação): 
        base(nome, cor, classificacao, extinção, alimentação) { }

        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} está falando: {comunicacao}");
        }
          public override void Vontade(string vontade)
        {
            Console.WriteLine($"{Nome} está com vontade de: {vontade}");
        }
    }
}
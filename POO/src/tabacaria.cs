using System;

namespace testepoo.src
{
    internal class Essencia
    {
        public string Nome { get; set; }
        public string Sabor { get; set; }
        public int Preço { get; set; }
        public int Quantidade { get; set; }

        public Essencia()
        {

        }

        public Essencia(string _nome, string _sabor, int _quantidade, int _preço)
        {
            Nome = _nome;
            Sabor = _sabor;
            Quantidade = _quantidade;
            Preço = _preço;
        }

        public void fumar()
        {
            Console.WriteLine("\nEstou fazendo bolinhas");
        }

        public void fumando(string fumando)
        {
            Console.WriteLine($"\nestou fumando {fumando}");
        }

        public string passando()
        {
            return "\nEstou Passando a mangueira\n";
        }

        public void acendendo(string acendendo)
        {
            Console.WriteLine($"\nEstou acendendo {acendendo}");
        }

  
    }
}
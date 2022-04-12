using System;
using Calculadora.src;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("\nPara saber a área do quadrado, basta multiplicar sua base pelo seu lado (b*h)");
            Console.WriteLine("Para saber a área do retangulo, basta multiplicar sua base pelo seu lado (b*h)");
            Console.WriteLine("Para saber a área do triangulo, basta multiplicar sua base pelo seu lado e dividir por dois (b*h=/2)\n");

            Console.WriteLine("Escreva o tamanho dos lados do quadrado");
            double ladoQuadrado = double.Parse(Console.ReadLine());
            Quadrado quadrado = new Quadrado("quadrado", ladoQuadrado, ladoQuadrado);
            Console.WriteLine($"A base do {quadrado.Nome} é {quadrado.Base} e a altura é {quadrado.Altura}\nA area é (b*h) = {quadrado.CalcularArea()}\n");

            Console.WriteLine("Escreva o tamanho da base do retangulo");
            double baseRetangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o tamanho da altura do retangulo");
            double alturaRetangulo = double.Parse(Console.ReadLine());
            Retangulo retangulo = new Retangulo("retangulo", baseRetangulo, alturaRetangulo);
            Console.WriteLine($"A base do {retangulo.Nome} é {retangulo.Base} e a altura é {retangulo.Altura}\nA area é (b*h) = {retangulo.CalcularArea()}\n");

            Console.WriteLine("Escreva o tamanho da base do triangulo");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o tamanho da altura do triangulo");
            double alturaTriangulo = double.Parse(Console.ReadLine());
            Triangulo triangulo = new Triangulo("triangulo", baseTriangulo, alturaTriangulo);
            Console.WriteLine($"A base do {triangulo.Nome} é {triangulo.Base} e a altura é {triangulo.Altura}\nA area é (b*h/2) = {triangulo.CalcularArea()}\n");
        }
    }
}
using System;
using System.Globalization;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("Primeira nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Terceira nota:");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Quarta nota:");
            nota4 = double.Parse(Console.ReadLine());
            
            media = (nota1 + nota2 + nota3 + nota4)/4;
            Console.Write("As Média das notas foram: "+media);
            if (media < 7)
            {
                Console.WriteLine(" Recuperção!");
            }
            else
            {
                Console.WriteLine(" Reprovado!");
            }
            
           

        }
    }
}

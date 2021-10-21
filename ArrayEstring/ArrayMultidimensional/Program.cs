using System;

namespace ArrayMultidimensional
{
    class Program
    {
        static void Main(string[] args)
        { //verificar a idade de uma lista de pessoas
            string[] Pessoas = new string[4] { "Mauricio", "Monike", "Enzo", "Xuca" };


            var ListaPessoas = new string[4,2]
            {
                { "Mauricio","30"},
                { "Monike","29"},
                {"Enzo","15"},
                {"Xuca","17" }

            };
            Console.WriteLine("PEssoas array normal: "+Pessoas[1]);
            Console.WriteLine("Pessoas array multidimensional: "+ListaPessoas[1, 1]);//posição 1= Monike, 'coluna 1'=29



        }
    }
}

using System;

namespace _01Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Futsal = new string[5] { "Manoel Tobias", "Shumacher", "Falcão", "Lenisio", "Jorginho" };
            int[] Futsal2 = { 10, 11, 15, 7, 10 }; //quantidade implícita

            Futsal[0] = "Mauricio Vieira"; //substitui um array na posição 0

            for( int i = 0; i < Futsal.Length; i++ ){
                Console.WriteLine(Futsal[i]);
            }

            Console.WriteLine("Acesso direto no array: "+Futsal[1]);
            foreach(string futsal in Futsal) //Lista todo mundo de dentro do array
            {
                Console.WriteLine("Acesso no array pelo forach: "+futsal);
            }
        }
    }
}

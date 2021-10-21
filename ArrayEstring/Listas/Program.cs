using System;
using System.Collections.Generic;


namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> NomeFuncionario = new List<string>();
            NomeFuncionario.Add("Mauricio Vieira");
            NomeFuncionario.Add("João");
            NomeFuncionario.Add("Maria");
            NomeFuncionario.Add("Carlos");

            Console.WriteLine();

            //percorre todos os nomes da lista
            foreach (string nomeFuncionario in NomeFuncionario)
            {
                Console.WriteLine(nomeFuncionario);
            }
            Console.WriteLine("Acesso a posições específicas da lista: "+NomeFuncionario[0]);

            NomeFuncionario.RemoveAt(0);
            Console.WriteLine("Remoção de item específico da lista:"+NomeFuncionario[0]);
        }
    }
}

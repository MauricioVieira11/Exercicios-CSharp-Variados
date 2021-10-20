using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 10)
                {
                    Console.WriteLine("Acrescente mais i!");
                }
            }
        }
    }
}

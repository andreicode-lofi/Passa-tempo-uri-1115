using System;

namespace Uri1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while(x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                if(x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                if(x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

            }
        }
    }
}

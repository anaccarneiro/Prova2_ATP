using System;
using System.Data.SqlTypes;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Leia um vetor de 10 posições. Contar e escrever quantos valores pares e impares ele possui.

            int[] vetor = new int[10];
            Random num = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = num.Next(10);
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();

            int contPares = 0, contImpares = 0;
            bool[] jaApareceu = new bool[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    contPares++;
                    if (!jaApareceu[vetor[i]])
                    {
                        Console.Write(vetor[i] + " ");
                        jaApareceu[vetor[i]] = true;
                    }
                }
                else
                {
                    contImpares++;
                }
            }
            Console.WriteLine($"Pares {contPares}, Impares {contImpares}");
        }
    }
}

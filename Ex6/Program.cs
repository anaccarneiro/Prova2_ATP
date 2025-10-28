using System;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6. Faça um programa que receba do usuário um vetor com 10 posições. Em seguida
            deverá ser impresso o maior e o menor elemento do vetor.*/

            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Informe o {i + 1}º número:");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int maiorPosicao = vetor[0];
            int menorPosicao = vetor[0];

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maiorPosicao)
                {
                    maiorPosicao = vetor[i];
                }
                else if (vetor[i] < menorPosicao)
                {
                    menorPosicao = vetor[i];
                }
            }
            Console.WriteLine(maiorPosicao + " " + menorPosicao);
        }
    }
}

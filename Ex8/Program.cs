using System;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*8. Crie um programa que lê 6 valores inteiros e, em seguida, mostre na tela os valores lidos na
            ordem inversa.*/

            int[] vetor = new int[6];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Informe o {i + 1}º número:");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = vetor.Length - 1; i >= 0 ; i--)
            {
                Console.Write(vetor[i]);
            }
        }
    }
}

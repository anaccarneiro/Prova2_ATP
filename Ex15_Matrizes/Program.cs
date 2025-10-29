using System;
using System.Runtime.Serialization;

namespace Ex15_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia uma matriz 5 x 5 que se refere respostas de 5 questoes de múltipla escolha,
            referentes a 5 alunos. Leia tambem um vetor de 5 posições contendo o gabarito de
            respostas que podem ser a, b, c, d ou e. Seu programa devera comparar as respostas 
            de cada candidato com o gabarito e emitir um vetor denominado resultado, contendo a
            pontuação correspondente a cada aluno. */

            int[] resultado = new int[5];
            char[] gabarito = {'a', 'b', 'c', 'd', 'e'};
            char[,] respostas = new char[5,5];
            
            for (int linha = 0; linha < respostas.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < respostas.GetLength(1); coluna++)
                {
                    Console.WriteLine($"Respostas aluno {linha + 1}:");
                    respostas[linha, coluna] = char.Parse(Console.ReadLine());
                }
            }

            for (int linha = 0; linha < respostas.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < respostas.GetLength(1); coluna++)
                {
                    Console.Write(respostas[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            for (int linha = 0; linha < respostas.GetLength(0); linha++)
            {
                int soma = 0;

                for (int coluna = 0; coluna < respostas.GetLength(1); coluna++)
                {
                    if (respostas[linha, coluna] == gabarito[coluna])
                    {
                        soma++;
                        resultado[linha] = soma;
                    }
                }
            }

            for (int linha = 0; linha < resultado.Length; linha++)
            {
                Console.Write(resultado[linha] + "\t");
            }
        }
    }
}

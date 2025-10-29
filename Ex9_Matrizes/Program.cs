using System;

namespace Ex9_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Leia uma matriz de 3 x 3 elementos. Calcule a soma dos elementos que estao abaixo da ˜
            diagonal principal.*/

            int[,] matriz = new int[3, 3];
            Random num = new Random();
            int soma = 0;

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = num.Next(10);
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                for (int linha = matriz.GetLength(0) - 1; linha > coluna; linha--)
                {
                    soma += matriz[linha, coluna];
                }
            }
            Console.WriteLine(soma);
        }
    }
}

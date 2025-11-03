using System;
using System.Data.Common;

namespace DiagonalSecundaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            Random num = new Random();

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    matriz[linha, col] = num.Next(10);
                    Console.Write(matriz[linha, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int coluna = matriz.GetLength(1) - 1, linha = 0; linha < matriz.GetLength(0); coluna--, linha++)
            {
                Console.Write(matriz[linha, coluna] + "\t");
            }

            Console.WriteLine("\n");

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    if (linha + col > matriz.GetLength(0) - 1)
                    {
                        Console.Write(matriz[linha, col] + "\t");
                    }
                }
            }

            Console.WriteLine("\n");


            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    // Se estiver acima da diagonal secundária
                    if (linha + col < matriz.GetLength(1) - 1)
                    {
                        matriz[linha, col] = 0;
                    }

                    Console.Write(matriz[linha, col] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}

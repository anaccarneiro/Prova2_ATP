using System;

namespace Ex10_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia uma matriz de 3 x 3 elementos. Calcule a soma dos elementos que estao na diagonal principal.*/
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
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (linha == coluna)
                    {
                        soma += matriz[linha, coluna];
                    }
                }
            }
            Console.WriteLine(soma);
        }
    }
}

using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Ex11_Modularizacao
{
    internal class Program
    {
        static void LerMatriz(out int[,] matriz)
        {
            matriz = new int[3, 3];
            Random num = new Random();

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = num.Next(10);
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int Soma(int[,] percorrendo)
        {
            int somando = 0;

            for (int linha = 0; linha < percorrendo.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < linha; coluna++)
                {
                    somando += percorrendo[linha, coluna];
                }
            }
            return somando;
        }
            static void Main(string[] args)
        {
            /*11. Faça um método que receba uma matriz de 3 x 3 elementos. Calcule e retorne a soma dos elementos que estão abaixo da diagonal principal (Lista 4 Edwaldo).*/

            int[,] matriz;
          
            LerMatriz(out matriz);

            int resultado = Soma(matriz);
            Console.WriteLine(resultado);
        }
    }
}

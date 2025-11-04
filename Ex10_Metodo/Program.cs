using System;

namespace Ex10_Metodo
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
                    matriz[linha, coluna] = num.Next(20);
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int Valores(int[,] matriz)
        {
            int cont = 0;
           
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (matriz[linha,coluna] > 10)
                    {
                        cont++;
                    }
                }
            }
            if (cont == 0)
            {
                Console.WriteLine("Nao ha valores maiores que dez");
            }

            return cont;
        }
        static void Main(string[] args)
        {
            /*10. Faça um método que receba uma matriz 4 x 4 e retorne quantos valores maiores do que 10 ela possui.*/
            int[,] leitura;
            LerMatriz(out leitura);

            int resultado = Valores(leitura);
            Console.WriteLine(resultado);
        }
    }
}

using System;


namespace Ex10_Modularizacao
{
    internal class Program
    {
        static void LerMatriculas (out int[] matriculaATP, out int[] matriculaDIW)
        {
            matriculaATP = new int[10];
            matriculaDIW = new int[10];

            Console.WriteLine("Matrículas ATP:");
            for (int i = 0; i < matriculaATP.Length; i++)
            {
                matriculaATP[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Matrículas DIW:");
            for (int j = 0; j < matriculaDIW.Length; j++)
            {
                matriculaDIW[j] = int.Parse(Console.ReadLine());
            }
        }

        static int[] Intersecao(int [] matricula1, int [] matricula2)
        {
            int[] iguais = new int[10];
            int cont = 0;

            for (int i = 0; i < matricula1.Length; i++)
            {
                for (int j = 0; j < matricula1.Length; j++)
                {
                    if (matricula1[i] == matricula2[j])
                    {

                        iguais[cont] += matricula1[i];
                        cont++;
                    }
                }
            }
            if (cont == 0)
            {
                Console.WriteLine("Não há alunos simultaneos");
            }
            return iguais;
        }
        static void Main(string[] args)
        {
            /*10. Faça um programa que leia dois vetores de inteiros de tamanho 10 representando o número de matrícula
                de alunos matriculados em Algoritmos e Técnicas de Programação e DIW. O programa deverá imprimir o
                número de matrícula dos alunos que estão matriculados simultaneamente nestas duas disciplinas (ou seja,
                calcular a interseção dos dois vetores). Se não existirem alunos matriculados simultaneamente nas duas
                disciplinas informar com uma mensagem na tela. A leitura dos valores dos vetores deve ser feita através de
                um método. A interseção também deverá ser feita através de um método que irá receber os vetores das
                matrículas das duas disciplinas, e deverá retornar um vetor com a interseção desses vetores. */

            int[] matricula1;
            int[] matricula2;
            LerMatriculas(out matricula1, out matricula2);

            int[] intersecao = Intersecao(matricula1, matricula2);
            for (int i = 0; i < intersecao.Length; i++)
            {
                Console.Write(intersecao[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}

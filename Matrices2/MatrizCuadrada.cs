using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices2
{
    class MatrizCuadrada : Matriz
    {
        private int[,] matrizCuadrada;

        public MatrizCuadrada(int n)
        {
            matrizCuadrada = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        matrizCuadrada[i, j] = 1;
                    }
                    else
                    {
                        matrizCuadrada[i, j] = 0;
                    }
                }
            }
        }

        public override void CalcularCeros()
        {
        }

        public override void MostrarMatriz()
        {
            Console.WriteLine("Matriz cuadrada dada:");
            for (int i = 0; i < matrizCuadrada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizCuadrada.GetLength(1); j++)
                {
                    Console.Write(matrizCuadrada[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override void MostrarMatrizModificada()
        {
            Console.WriteLine("Matriz cuadrada:");
            for (int i = 0; i < matrizCuadrada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizCuadrada.GetLength(1); j++)
                {
                    if (matrizCuadrada[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write(matrizCuadrada[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


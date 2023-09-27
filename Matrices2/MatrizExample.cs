using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices2
{
    class MatrizEjemplo : Matriz
    {
        private int[,] matriz = {
            {0, 2, 5, 7, 6},
            {0, 0, 0, 3, 8},
            {2, 9, 6, 3, 4},
            {1, 5, 6, 1, 4},
            {0, 9, 2, 5, 0}
        };

        public override void CalcularCeros()
        {
            int totalCeros = 0;
            Console.WriteLine("Ceros en la matriz de ejemplo:");
            for (int i = 0; i < 5; i++)
            {
                int cerosEnRenglon = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        cerosEnRenglon++;
                        totalCeros++;
                    }
                }

                Console.Write($"Renglón {i + 1}: ");
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.Write($"{cerosEnRenglon} ceros");
                Console.ForegroundColor = ConsoleColor.White; 
                Console.WriteLine();
            }
            Console.WriteLine($"Total de ceros en la matriz: {totalCeros}");
        }


        public override void MostrarMatriz()
        {
            Console.WriteLine("Matriz de ejemplo:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

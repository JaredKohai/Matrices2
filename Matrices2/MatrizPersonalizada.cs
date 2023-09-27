using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices2
{
    class MatrizPersonalizada : Matriz
    {
        private int[,] matrizPersonalizada = new int[5, 5];

        public override void CalcularCeros()
        {
            int totalCeros = 0;
            Console.WriteLine("Ceros en la matriz personalizada:");
            for (int i = 0; i < 5; i++)
            {
                int cerosEnRenglon = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (matrizPersonalizada[i, j] == 0)
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
            Console.WriteLine("Matriz personalizada:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrizPersonalizada[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override void PedirValores()
        {
            Console.WriteLine("Ingresa los valores de la matriz personalizada (5x5):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bool valorValido = false;
                    while (!valorValido)
                    {
                        Console.Write($"Valor en posición ({i + 1}, {j + 1}): ");
                        if (int.TryParse(Console.ReadLine(), out int valor))
                        {
                            matrizPersonalizada[i, j] = valor;
                            valorValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Valor no válido. Introduce un número válido.");
                        }
                    }
                }
            }
        }
    }
}

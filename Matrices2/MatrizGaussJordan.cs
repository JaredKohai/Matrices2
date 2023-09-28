using System;

namespace Matrices2
{
    class MatrizGaussJordan : Matriz
    {
        private double[,] matriz;
        private int dimension;

        public MatrizGaussJordan(int dimension)
        {
            this.dimension = dimension;
            matriz = new double[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    matriz[i, j] = 0.0;
                }
            }
        }

        public MatrizGaussJordan(MatrizGaussJordan otraMatriz)
        {
            this.dimension = otraMatriz.dimension;
            matriz = new double[dimension, dimension];
            Array.Copy(otraMatriz.matriz, this.matriz, dimension * dimension);
        }

        public override void CalcularCeros()
        {
        }

        public override void MostrarMatriz()
        {
            Console.WriteLine("Matriz Gauss-Jordan:");
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override void PedirValores()
        {
            Console.WriteLine($"Ingresa los valores de la matriz ({dimension}x{dimension}):");
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    bool valorValido = false;
                    while (!valorValido)
                    {
                        Console.Write($"Valor en posición ({i + 1}, {j + 1}): ");
                        if (double.TryParse(Console.ReadLine(), out double valor))
                        {
                            matriz[i, j] = valor;
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

        public void ResolverGaussJordan()
        {
            for (int k = 0; k < dimension; k++)
            {
                if (Math.Abs(matriz[k, k]) < double.Epsilon)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Matriz insoluble.");
                    return;
                }

                double pivot = matriz[k, k];
                for (int j = 0; j < dimension; j++)
                {
                    matriz[k, j] /= pivot;
                }
                
                for (int i = 0; i < dimension; i++)
                {
                    if (i != k)
                    {
                        double factor = matriz[i, k];
                        for (int j = 0; j < dimension; j++)
                        {
                            matriz[i, j] -= factor * matriz[k, j];
                        }
                    }
                }
                Console.WriteLine($"Paso {k + 1}:");
                MostrarMatriz();
                Console.WriteLine();
            }


        }
    }
}

using System;

namespace Matrices2
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Matriz matriz = null;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Calcular ceros en una matriz 5x5.");
                Console.WriteLine("2. Llenar matriz cuadrada diagonal 1 y 0.");
                Console.WriteLine("3. Salir.");
                Console.Write("> ");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Elige:");
                            Console.WriteLine("1. Usar matriz de ejemplo.");
                            Console.WriteLine("2. Ingresar matriz personalizada.");
                            Console.Write("Opción: ");
                            int subOpcion;
                            if (int.TryParse(Console.ReadLine(), out subOpcion))
                            {
                                if (subOpcion == 1)
                                {
                                    matriz = new MatrizEjemplo();
                                }
                                else if (subOpcion == 2)
                                {
                                    matriz = new MatrizPersonalizada();
                                    matriz.PedirValores();
                                }
                                else
                                {
                                    Console.WriteLine("Opción no válida. Presiona cualquier tecla para regresar.");
                                    Console.ReadKey();
                                    continue;
                                }

                                matriz.MostrarMatriz();
                                matriz.CalcularCeros();

                                Console.WriteLine("Presiona cualquier tecla dos veces para continuar.");
                                Console.ReadKey();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida. Presiona cualquier tecla para regresar.");
                                Console.ReadKey();

                            }
                            break;

                        case 2:
                            Console.Clear();
                            Console.Write("Tamaño matriz cuadrada: ");
                            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                            {
                                matriz = new MatrizCuadrada(n);
                                matriz.MostrarMatrizModificada();

                                Console.WriteLine("Presiona cualquier tecla para continuar.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Tamaño de matriz con caracteres inválidos. Presiona cualquier tecla para regresar.");
                                Console.ReadKey();
                            }
                            break;

                        case 3:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Presiona cualquier tecla para continuar.");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
            }
        }
    }
}




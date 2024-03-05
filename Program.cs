using System;
using System.Diagnostics;

public class Practica1
{
    public static void Main(string[] args)
    {
        int n = 0, n2 = 0;

        do
        {
            Console.Write("Ingrese el numero de elementos (mayor a 1000): ");
            n = Convert.ToInt32(Console.ReadLine());

        } while (n < 1000);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start(); // Iniciar el cronómetro

        int[] nums = new int[n];
        LlenarArreglo(n, nums);
        ImprimirArreglo(n, nums);

        stopwatch.Stop(); // Detener el cronómetro
        Console.WriteLine($"Tiempo de llenado e impresión del arreglo: {stopwatch.ElapsedMilliseconds} milisegundos");
        Console.WriteLine("Pulse una tecla para continuar . . .");
        Console.ReadKey();
        Console.Clear();

        stopwatch.Reset(); // Reiniciar el cronómetro

        while (true)
        {
            Console.WriteLine("Menú de Opciones:");
            Console.WriteLine("1. Buscar número (secuencial)");
            Console.WriteLine("2. Ordenar y mostrar arreglo");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Ingrese el número a buscar: ");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    stopwatch.Start(); // Iniciar el cronómetro
                    BusquedaSecuencial(n2, nums);
                    stopwatch.Stop(); // Detener el cronómetro
                    Console.WriteLine($"Tiempo de búsqueda secuencial: {stopwatch.ElapsedMilliseconds} milisegundos");
                    Console.WriteLine("Pulse una tecla para continuar . . .");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    stopwatch.Start(); // Iniciar el cronómetro
                    Array.Sort(nums);
                    ImprimirArreglo(n, nums);
                    stopwatch.Stop(); // Detener el cronómetro
                    Console.WriteLine($"Tiempo de ordenamiento y mostrar arreglo: {stopwatch.ElapsedMilliseconds} milisegundos");
                    Console.WriteLine("Pulse una tecla para continuar . . .");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione nuevamente.");
                    break;
            }
        }
    }

    static int[] LlenarArreglo(int n, int[] nums)
    {
        Random numsAle = new Random();

        for (int i = 0; i < n; i++)
        {
            nums[i] = numsAle.Next(1, n + 1);
        }

        return nums;
    }

    static void ImprimirArreglo(int n, int[] nums)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("pos {0}: {1}", i + 1, nums[i]);
        }
    }

    static int BusquedaSecuencial(int numb, int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == numb)
            {
                Console.WriteLine("Se encontro el {0} en la posición: {1}", numb, i);
                return 1;
            }
        }
        Console.WriteLine("No se encontro el numero :(");
        return -1;
    }
}

using System;

class MatrizValores
{
    static void Main()
    {
        Console.Write("Ingrese el número de filas: ");
        int filas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el número de columnas: ");
        int columnas = Convert.ToInt32(Console.ReadLine());

        int[,] matriz = new int[filas, columnas];

        // Ingreso de datos
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write("Ingrese el valor para la posición [" + i + "," + j + "]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Mostrar matriz
        Console.WriteLine("\nMatriz ingresada:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Inicializar mayor y menor
        int mayor = matriz[0, 0];
        int menor = matriz[0, 0];
        int filaMayor = 0, colMayor = 0;
        int filaMenor = 0, colMenor = 0;

        // Recorrer matriz para encontrar mayor y menor
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] > mayor)
                {
                    mayor = matriz[i, j];
                    filaMayor = i;
                    colMayor = j;
                }

                if (matriz[i, j] < menor)
                {
                    menor = matriz[i, j];
                    filaMenor = i;
                    colMenor = j;
                }
            }
        }

        // Mostrar resultados
        Console.WriteLine("\nValor mayor: " + mayor);
        Console.WriteLine("Posición: Fila " + filaMayor + ", Columna " + colMayor);

        Console.WriteLine("\nValor menor: " + menor);
        Console.WriteLine("Posición: Fila " + filaMenor + ", Columna " + colMenor);
    }
}

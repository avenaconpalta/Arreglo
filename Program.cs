using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño del arreglo: ");
        int n = int.Parse(Console.ReadLine());

        List<int> valores = new List<int>();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el valor en la posición {i}: ");
            valores.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine("Arreglo inicial:");
        MostrarArreglo(valores);

        Console.Write("Ingrese la posición a eliminar: ");
        int posicion = int.Parse(Console.ReadLine());

      
        if (posicion >= 0 && posicion < valores.Count)
        {
            
            valores.RemoveAt(posicion);

            
            Console.WriteLine("Arreglo después de eliminar:");
            MostrarArreglo(valores);
        }
        else
        {
            Console.WriteLine("Posición inválida.");
        }
    }

    static void MostrarArreglo(List<int> arreglo)
    {
        foreach (int valor in arreglo)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
    }
}

using System;

class Program
{
    static int BusquedaBinaria(int[] arr, int x)
    {
        int inicio = 0, fin = arr.Length - 1;
        while (inicio <= fin)
        {
            int medio = (inicio + fin) / 2;
            if (arr[medio] == x) return medio;
            else if (arr[medio] < x) inicio = medio + 1;
            else fin = medio - 1;
        }
        return -1; // no encontrado
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9 };
        int busqueda = 5;

        int indice = BusquedaBinaria(arr, busqueda);
        if (indice != -1)
            Console.WriteLine($"{busqueda} encontrado en la posición {indice}");
        else
            Console.WriteLine($"{busqueda} no se encontró");
    }
}

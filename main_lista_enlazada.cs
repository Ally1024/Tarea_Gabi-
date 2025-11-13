using System;

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.InsertarFinal(5);
        lista.InsertarFinal(2);
        lista.InsertarFinal(8);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        // Aquí podrías llamar a Ordenar, EliminarX, etc.
    }
}

using System;

class Nodo
{
    public int dato;
    public Nodo siguiente;

    public Nodo(int dato)
    {
        this.dato = dato;
        this.siguiente = null;
    }
}

class ListaEnlazada
{
    public Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    public void InsertarFinal(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo temp = cabeza;
            while (temp.siguiente != null)
                temp = temp.siguiente;
            temp.siguiente = nuevo;
        }
    }

    public void Mostrar()
    {
        Nodo temp = cabeza;
        while (temp != null)
        {
            Console.Write(temp.dato + " -> ");
            temp = temp.siguiente;
        }
        Console.WriteLine("null");
    }
}

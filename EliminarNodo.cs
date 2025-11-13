using System;

class Nodo
{
    public int dato;
    public Nodo siguiente;
    public Nodo(int dato)
    {
        this.dato = dato;
        siguiente = null;
    }
}

class ListaEnlazada
{
    public Nodo cabeza;

    public void InsertarFinal(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (cabeza == null) cabeza = nuevo;
        else
        {
            Nodo temp = cabeza;
            while (temp.siguiente != null) temp = temp.siguiente;
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

    public void EliminarX(int x)
    {
        if (cabeza == null) return;
        if (cabeza.dato == x) { cabeza = cabeza.siguiente; return; }

        Nodo temp = cabeza;
        while (temp.siguiente != null && temp.siguiente.dato != x)
            temp = temp.siguiente;
        if (temp.siguiente != null)
            temp.siguiente = temp.siguiente.siguiente;
    }

    public void EliminarDespues(int x)
    {
        Nodo temp = cabeza;
        while (temp != null && temp.dato != x)
            temp = temp.siguiente;
        if (temp != null && temp.siguiente != null)
            temp.siguiente = temp.siguiente.siguiente;
    }

    public void EliminarAntes(int x)
    {
        if (cabeza == null || cabeza.dato == x) return;
        if (cabeza.siguiente != null && cabeza.siguiente.dato == x)
        {
            cabeza = cabeza.siguiente;
            return;
        }

        Nodo prev = cabeza;
        Nodo curr = cabeza.siguiente;
        while (curr.siguiente != null && curr.siguiente.dato != x)
        {
            prev = curr;
            curr = curr.siguiente;
        }

        if (curr.siguiente != null)
            prev.siguiente = curr.siguiente;
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.InsertarFinal(1);
        lista.InsertarFinal(2);
        lista.InsertarFinal(3);
        lista.InsertarFinal(4);
        lista.InsertarFinal(5);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        lista.EliminarX(3);
        Console.WriteLine("Después de eliminar 3:");
        lista.Mostrar();

        lista.EliminarDespues(2);
        Console.WriteLine("Después de eliminar después de 2:");
        lista.Mostrar();

        lista.EliminarAntes(5);
        Console.WriteLine("Después de eliminar antes de 5:");
        lista.Mostrar();
    }
}

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

    public void Ordenar()
    {
        cabeza = MergeSort(cabeza);
    }

    private Nodo MergeSort(Nodo head)
    {
        if (head == null || head.siguiente == null) return head;
        Nodo medio = ObtenerMedio(head);
        Nodo siguienteMedio = medio.siguiente;
        medio.siguiente = null;

        Nodo izquierda = MergeSort(head);
        Nodo derecha = MergeSort(siguienteMedio);

        return Mezclar(izquierda, derecha);
    }

    private Nodo ObtenerMedio(Nodo head)
    {
        Nodo lento = head, rapido = head;
        while (rapido.siguiente != null && rapido.siguiente.siguiente != null)
        {
            lento = lento.siguiente;
            rapido = rapido.siguiente.siguiente;
        }
        return lento;
    }

    private Nodo Mezclar(Nodo a, Nodo b)
    {
        if (a == null) return b;
        if (b == null) return a;
        Nodo resultado;
        if (a.dato <= b.dato)
        {
            resultado = a;
            resultado.siguiente = Mezclar(a.siguiente, b);
        }
        else
        {
            resultado = b;
            resultado.siguiente = Mezclar(a, b.siguiente);
        }
        return resultado;
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.InsertarFinal(5);
        lista.InsertarFinal(2);
        lista.InsertarFinal(8);
        lista.InsertarFinal(1);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        lista.Ordenar();
        Console.WriteLine("Lista ordenada:");
        lista.Mostrar();
    }
}

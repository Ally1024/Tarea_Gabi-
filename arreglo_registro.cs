using System;

struct Registro
{
    public int id;
    public string nombre;

    public Registro(int id, string nombre)
    {
        this.id = id;
        this.nombre = nombre;
    }
}

class Program
{
    static void Main()
    {
        Registro[] registros = new Registro[3];
        registros[0] = new Registro(1, "Juan");
        registros[1] = new Registro(2, "Ana");
        registros[2] = new Registro(3, "Luis");

        Console.WriteLine("Registros:");
        foreach (var r in registros)
            Console.WriteLine($"ID: {r.id}, Nombre: {r.nombre}");
    }
}

using System;
using System.Collections.Generic;

class Torre
{
    public Stack<int> discos = new Stack<int>();
    public string nombre;

    public Torre(string nombre)
    {
        this.nombre = nombre;
    }

    public void MoverDiscoA(Torre destino)
    {
        int disco = discos.Pop();
        destino.discos.Push(disco);
        Console.WriteLine($"Mover disco {disco} de {nombre} a {destino.nombre}");
    }
}

class TorresDeHanoi
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese el número de discos: ");
        string? entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int numDiscos) && numDiscos > 0)
        {
            Torre origen = new Torre("Origen");
            Torre auxiliar = new Torre("Auxiliar");
            Torre destino = new Torre("Destino");

            for (int i = numDiscos; i >= 1; i--)
                origen.discos.Push(i);

            ResolverHanoi(numDiscos, origen, auxiliar, destino);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Debe ingresar un número entero mayor que cero.");
        }
    }

    static void ResolverHanoi(int n, Torre origen, Torre auxiliar, Torre destino)
    {
        if (n == 1)
        {
            origen.MoverDiscoA(destino);
        }
        else
        {
            ResolverHanoi(n - 1, origen, destino, auxiliar);
            origen.MoverDiscoA(destino);
            ResolverHanoi(n - 1, auxiliar, origen, destino);
        }
    }
}

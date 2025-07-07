using System;
using System.Collections.Generic;

class Lista
{
    private List<int> elementos;

    public Lista()
    {
        elementos = new List<int>();
    }

    public void Agregar(int valor)
    {
        elementos.Add(valor);
    }

    public int Buscar(int dato)
    {
        int contador = 0;
        foreach (int elemento in elementos)
        {
            if (elemento == dato)
            {
                contador++;
            }
        }
        return contador;
    }

    public int ContarElementos()
    {
        return elementos.Count;
    }

    public void Mostrar()
    {
        Console.WriteLine("Elementos de la lista: " + string.Join(", ", elementos));
    }
}

// Renombramos la clase para evitar conflicto con otra clase Program
class MiPrograma
{
    static void Main(string[] args)
    {
        Lista miLista = new Lista();

        miLista.Agregar(5);
        miLista.Agregar(10);
        miLista.Agregar(5);
        miLista.Agregar(20);
        miLista.Agregar(5);

        miLista.Mostrar();

        // Ejercicio 1: Contar elementos
        int cantidad = miLista.ContarElementos();
        Console.WriteLine("Número total de elementos: " + cantidad);

        // Ejercicio 3: Buscar ocurrencias
        int datoBuscar = 5;
        int veces = miLista.Buscar(datoBuscar);
        Console.WriteLine($"El número {datoBuscar} se encuentra {veces} veces en la lista.");
    }
}

using System;
using System.Collections.Generic;

namespace AtraccionCola
{
    // Clase Persona
    public class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }

    // Clase Atracción
    public class Atraccion
    {
        private Queue<Persona> cola;
        private const int capacidadMaxima = 30;

        public Atraccion()
        {
            cola = new Queue<Persona>();
        }

        public bool RegistrarPersona(string nombre)
        {
            if (cola.Count < capacidadMaxima)
            {
                Persona persona = new Persona(nombre);
                cola.Enqueue(persona);
                Console.WriteLine($"Registrado: {nombre}");
                return true;
            }
            else
            {
                Console.WriteLine("La atracción está llena. No se pueden registrar más personas.");
                return false;
            }
        }

        public void MostrarCola()
        {
            Console.WriteLine("\n--- Lista de Personas en la Cola ---");
            int numero = 1;
            foreach (Persona p in cola)
            {
                Console.WriteLine($"{numero}. {p.Nombre}");
                numero++;
            }
        }

        public int TotalRegistrados()
        {
            return cola.Count;
        }
    }

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            Atraccion atraccion = new Atraccion();
            string? opcion;

            do
            {
                Console.WriteLine("\n--- MENÚ ATRACCIÓN ---");
                Console.WriteLine("1. Registrar persona");
                Console.WriteLine("2. Mostrar cola");
                Console.WriteLine("3. Mostrar total registrados");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre de la persona: ");
                        string? nombre = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nombre))
                        {
                            atraccion.RegistrarPersona(nombre);
                        }
                        else
                        {
                            Console.WriteLine("El nombre no puede estar vacío.");
                        }
                        break;

                    case "2":
                        atraccion.MostrarCola();
                        break;

                    case "3":
                        Console.WriteLine($"Total registrados: {atraccion.TotalRegistrados()}");
                        break;

                    case "4":
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != "4");
        }
    }
}

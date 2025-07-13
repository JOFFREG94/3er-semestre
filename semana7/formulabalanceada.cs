using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Menú de ejercicios:");
        Console.WriteLine("1. Verificar paréntesis balanceados");
        Console.WriteLine("2. Torres de Hanoi");
        Console.Write("Elige una opción (1 o 2): ");
        string? opcion = Console.ReadLine();

        if (opcion == "1")
        {
            EjecutarParentesis();
        }
        else if (opcion == "2")
        {
            TorresDeHanoi.Ejecutar();
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }

    static void EjecutarParentesis()
    {
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
        if (EstaBalanceado(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula desbalanceada.");
    }

    static bool EstaBalanceado(string expresion)
    {
        var pila = new Stack<char>();
        foreach (char c in expresion)
        {
            if (c == '(' || c == '[' || c == '{')
                pila.Push(c);
            else if (c == ')' || c == ']' || c == '}')
            {
                if (pila.Count == 0) return false;
                char tope = pila.Pop();
                if ((c == ')' && tope != '(') ||
                    (c == ']' && tope != '[') ||
                    (c == '}' && tope != '{'))
                    return false;
            }
        }
        return pila.Count == 0;
    }
}

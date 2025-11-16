// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static bool Validar_Contrasena(string contrasena)
    {
        // 1. Debe tener al menos 8 caracteres
        if (contrasena.Length < 8)
        {
            Console.WriteLine("Error: La contraseña debe tener al menos 8 caracteres.");
            return false;
        }

        // 2. Debe contener al menos un número
        if (!contrasena.Any(char.IsDigit))
        {
            Console.WriteLine("Error: La contraseña debe contener al menos un número.");
            return false;
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("\nValidador de Contraseñas");

        string pass;
        bool esValida = false;

        // 🔄 Bucle que repite hasta que la contraseña sea válida
        while (!esValida)
        {
            Console.Write("Ingrese una contraseña: ");
            pass = Console.ReadLine();

            esValida = Validar_Contrasena(pass); // si es false, el bucle continúa
        }

        Console.WriteLine("Resultado: Contraseña válida.");
    }
}


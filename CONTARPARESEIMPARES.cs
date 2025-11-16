// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // Función que utiliza un bucle para procesar el número
    static void Contar_Digitos(int numero)
    {
        int pares = 0;
        int impares = 0;
        int temp = Math.Abs(numero); // Usar valor absoluto para manejar negativos

        // El bucle se ejecuta mientras el número temporal sea mayor que 0
        while (temp > 0)
        {
            int digito = temp % 10; // Obtiene el último dígito

            // Estructura condicional para verificar si es par o impar
            if (digito % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }

            temp /= 10; // Elimina el último dígito (preparación para la siguiente iteración)
        }

        Console.WriteLine($"El número {numero} tiene:");
        Console.WriteLine($"- Dígitos pares: {pares}");
        Console.WriteLine($"- Dígitos impares: {impares}");
    }

    static void Main()
    {
        Console.WriteLine("\nContador de Dígitos Pares e Impares");
        Console.Write("Ingrese un número entero: ");
        int num = int.Parse(Console.ReadLine());

        // Llamada a la función
        Contar_Digitos(num);
    }
}
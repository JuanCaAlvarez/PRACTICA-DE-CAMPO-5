// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // Función que calcula el total con un descuento simple
    static double Calcular_Total_Compra(double monto, double descuento_porcentaje)
    {
        double descuento = monto * (descuento_porcentaje / 100.0);
        return monto - descuento;
    }

    static void Main()
    {
        Console.WriteLine("\nCalculadora de Descuento ");
        Console.Write("Ingrese el monto total de la compra: ");
        double monto_original = double.Parse(Console.ReadLine());

        double descuento_base = 10.0; // Descuento inicial del 10%

        // Estructura condicional para descuento extra
        if (monto_original > 200.0)
        {
            Console.WriteLine("¡Monto alto detectado! Aplicando 5% de descuento extra.");
            descuento_base += 5.0; // Total 15%
        }

        double total_a_pagar = Calcular_Total_Compra(monto_original, descuento_base);

        Console.WriteLine($"Descuento total aplicado: {descuento_base:F2}%");
        Console.WriteLine($"Monto final a pagar: {total_a_pagar:F2}");
    }
}

using System;

internal class Program
{
    //Suma de dos enteros
    private static int Sumar(int a, int b)
    {
        return a + b;
    }

    //Mayor o menor de edad
    private static string VerificarEdad(int edad)
    {
        if (edad >= 18)
            return "Es mayor de edad";
        else
            return "Es menor de edad";
    }

    //Área del círculo
    private static double AreaCirculo(double radio)
    {
        return Math.PI * radio * radio;
    }

    //Área del triángulo
    private static double AreaTriangulo(double baseT, double altura)
    {
        return (baseT * altura) / 2;
    }

    private static void Main(string[] args)
    {
        //Suma 
        Console.WriteLine("Ingrese el primer número entero:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número entero:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"La suma es: {Sumar(num1, num2)}\n");

        //Edad 
        Console.WriteLine("Ingrese su edad:");
        int edad = int.Parse(Console.ReadLine());
        Console.WriteLine(VerificarEdad(edad) + "\n");

        //Área círculo 
        Console.WriteLine("Ingrese el radio del círculo:");
        double radio = double.Parse(Console.ReadLine());
        Console.WriteLine($"El área del círculo es: {AreaCirculo(radio):F2}\n");

        //Área triángulo 
        Console.WriteLine("Ingrese la base del triángulo:");
        double baseT = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triángulo:");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine($"El área del triángulo es: {AreaTriangulo(baseT, altura):F2}\n");


        Console.WriteLine("Programa finalizado. Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
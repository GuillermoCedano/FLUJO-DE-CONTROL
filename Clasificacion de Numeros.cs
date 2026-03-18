internal class Program
{
    private static void Main(string[] args)
    {
        // Cuantos son pares.
        // Cuantos son impares.
        // Cuantos son mayores a 10.
        // Cuantos son positivos.
        // Cuantos son negativos.

        Console.WriteLine("Cual es la cantidad de numeros a ingresar? ");
        int n = int.Parse(Console.ReadLine ());

        int pares = 0;
        int impares = 0;
        int mayoresde10 = 0;
        int positivo = 0;
        int negativo = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Seleccione un numero: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                pares++;
            else 
                impares++;

            if (num > 10)
                mayoresde10++;

            if (num > 0)
                positivo++;
            else if (num < 0)
                negativo++;
        }

        Console.WriteLine("\nResultados:");
        Console.WriteLine("Cantidad de números pares: " + pares);
        Console.WriteLine("Cantidad de números impares: " + impares);
        Console.WriteLine("Cantidad de números mayores a 10: " + mayoresde10);
        Console.WriteLine("Cantidad de números positivos: " + positivo);
        Console.WriteLine("Cantidad de números negativos: " + negativo);
    }
}

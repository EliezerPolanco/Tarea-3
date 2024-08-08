using System;

class Calculadora
{
    static void Main()
    {
        Boolean continuar = true;

        while (continuar)
        {

            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - División");
            Console.WriteLine("5 - Elevar un número a la potencia");
            Console.WriteLine("6 - Salir");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion < 1 || opcion > 6)
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                continue;
            }
            if (opcion == 6)
            {
                continuar = false;
                break;
            }

            Console.Write("Ingrese el primer número: ");
            double numero1 = double.Parse(Console.ReadLine());

            double numero2 = 0;
            if (opcion != 5)
            {
                Console.Write("Ingrese el segundo número: ");
                numero2 = double.Parse(Console.ReadLine());
            }

            double resultado = 0;
            switch (opcion)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero no es valida.");
                    }
                    break;
                case 5:
                    Console.Write("Ingrese el exponente: ");
                    int exponente = int.Parse(Console.ReadLine());
                    resultado = Math.Pow(numero1, exponente);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
            }

            Console.WriteLine();
        }
    }
}

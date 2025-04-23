using System;

class Calculadora
{
    static void Main()
    {
        double num1, num2, resultado;
        char operacion;

        Console.WriteLine("=== CALCULADORA BÁSICA ===");

        Console.Write("Ingrese el primer número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el operador (+, -, *, /): ");
        operacion = Convert.ToChar(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operacion)
        {
            case '+':
                resultado = num1 + num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case '-':
                resultado = num1 - num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case '*':
                resultado = num1 * num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else
                {
                    Console.WriteLine("Error: División por cero.");
                }
                break;
            default:
                Console.WriteLine("Operador no válido.");
                break;
        }

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

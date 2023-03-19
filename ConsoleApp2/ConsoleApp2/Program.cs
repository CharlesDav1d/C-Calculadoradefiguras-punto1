using System;

namespace Calculadorafiguras
{
    public abstract class FiguraGeometrica
    {
        public abstract double CalcularArea();
    }

    public class Circulo : FiguraGeometrica
    {
        public double Radio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }

    public class Rectangulo : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Elija la figura que desea calcular su área:");
                Console.WriteLine("1. Circulo");
                Console.WriteLine("2. Rectangulo");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese el radio del círculo:");
                    double radio = double.Parse(Console.ReadLine());

                    Circulo circulo = new Circulo();
                    circulo.Radio = radio;

                    Console.WriteLine($"El área del círculo es: {circulo.CalcularArea()}");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese la base del rectángulo:");
                    double @base = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura del rectángulo:");
                    double altura = double.Parse(Console.ReadLine());

                    Rectangulo rectangulo = new Rectangulo();
                    rectangulo.Base = @base;
                    rectangulo.Altura = altura;

                    Console.WriteLine($"El área del rectángulo es: {rectangulo.CalcularArea()}");
                }
                else
                {
                    Console.WriteLine("Opción inválida");
                }
            }
        }
    }
}


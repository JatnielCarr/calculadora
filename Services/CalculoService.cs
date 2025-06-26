using System;

namespace AREASYVOLUMENES.Services
{
    public class CalculoService : ICalculoService
    {
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir por cero");
            return a / b;
        }

        public double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }

        public double CalculateSquareArea(double lado)
        {
            return lado * lado;
        }

        public double CalculateTriangleArea(double @base, double altura)
        {
            return (@base * altura) / 2;
        }

        public double CalcularPerimetroCuadrado(double lado)
        {
            return 4 * lado;
        }

        public double CalcularPerimetroRectangulo(double base_, double altura)
        {
            return 2 * (base_ + altura);
        }

        public double CalcularPerimetroCirculo(double radio)
        {
            return 2 * Math.PI * radio;
        }

        public void GuardarResultadoArea(string tipoFigura, double valor, string parametros)
        {
            // Implementación pendiente
        }

        public void GuardarResultadoVolumen(string tipoFigura, double valor, string parametros)
        {
            // Implementación pendiente
        }

        public void GuardarResultadoPerimetro(string tipoFigura, double valor, string parametros)
        {
            // Implementación pendiente
        }
    }
} 
using System;

namespace AREASYVOLUMENES.Services
{
    public interface ICalculoService
    {
        // Operaciones básicas
        double Sumar(double a, double b);
        double Restar(double a, double b);
        double Multiplicar(double a, double b);
        double Dividir(double a, double b);

        // Cálculos de área
        double CalculateCircleArea(double radius);
        double CalculateRectangleArea(double width, double height);
        double CalculateSquareArea(double lado);
        double CalculateTriangleArea(double @base, double altura);

        // Cálculos de perímetro
        double CalcularPerimetroCuadrado(double lado);
        double CalcularPerimetroRectangulo(double base_, double altura);
        double CalcularPerimetroCirculo(double radio);

        // Métodos para guardar resultados
        void GuardarResultadoArea(string tipoFigura, double valor, string parametros);
        void GuardarResultadoVolumen(string tipoFigura, double valor, string parametros);
        void GuardarResultadoPerimetro(string tipoFigura, double valor, string parametros);
    }
} 
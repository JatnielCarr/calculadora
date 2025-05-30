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
    }
} 
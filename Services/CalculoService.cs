using System;
using AREASYVOLUMENES;
using AREASYVOLUMENES.Models;

namespace AREASYVOLUMENES.Services
{
    public class CalculoService : ICalculoService
    {
        private readonly AppDbContext _context;
        public CalculoService(AppDbContext context)
        {
            _context = context;
        }

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
            switch (tipoFigura.ToLower())
            {
                case "cuadrado":
                    var cuadrado = new Cuadrado { Lado = double.Parse(parametros), Area = valor, Tipo = "Cuadrado", FechaCalculo = DateTime.UtcNow };
                    _context.Cuadrados.Add(cuadrado);
                    break;
                case "rectangulo":
                    var partes = parametros.Split(',');
                    var rectangulo = new Rectangulo { Base = double.Parse(partes[0]), Altura = double.Parse(partes[1]), Area = valor, Tipo = "Rectangulo", FechaCalculo = DateTime.UtcNow };
                    _context.Rectangulos.Add(rectangulo);
                    break;
                case "circulo":
                    var circulo = new Circulo { Radio = double.Parse(parametros), Area = valor, Tipo = "Circulo", FechaCalculo = DateTime.UtcNow };
                    _context.Circulos.Add(circulo);
                    break;
                case "cubo":
                    var cubo = new Cubo { Lado = double.Parse(parametros), Area = valor, Tipo = "Cubo", FechaCalculo = DateTime.UtcNow };
                    _context.Cubos.Add(cubo);
                    break;
                case "esfera":
                    var esfera = new Esfera { Radio = double.Parse(parametros), Area = valor, Tipo = "Esfera", FechaCalculo = DateTime.UtcNow };
                    _context.Esferas.Add(esfera);
                    break;
                case "cilindro":
                    var partesCil = parametros.Split(',');
                    var cilindro = new Cilindro { Radio = double.Parse(partesCil[0]), Altura = double.Parse(partesCil[1]), Area = valor, Tipo = "Cilindro", FechaCalculo = DateTime.UtcNow };
                    _context.Cilindros.Add(cilindro);
                    break;
            }
            _context.SaveChanges();
        }

        public void GuardarResultadoVolumen(string tipoFigura, double valor, string parametros)
        {
            switch (tipoFigura.ToLower())
            {
                case "cubo":
                    var cubo = new Cubo { Lado = double.Parse(parametros), Volumen = valor, Tipo = "Cubo", FechaCalculo = DateTime.UtcNow };
                    _context.Cubos.Add(cubo);
                    break;
                case "esfera":
                    var esfera = new Esfera { Radio = double.Parse(parametros), Volumen = valor, Tipo = "Esfera", FechaCalculo = DateTime.UtcNow };
                    _context.Esferas.Add(esfera);
                    break;
                case "cilindro":
                    var partes = parametros.Split(',');
                    var cilindro = new Cilindro { Radio = double.Parse(partes[0]), Altura = double.Parse(partes[1]), Volumen = valor, Tipo = "Cilindro", FechaCalculo = DateTime.UtcNow };
                    _context.Cilindros.Add(cilindro);
                    break;
                case "cuadrado":
                    var cuadrado = new Cuadrado { Lado = double.Parse(parametros), Volumen = valor, Tipo = "Cuadrado", FechaCalculo = DateTime.UtcNow };
                    _context.Cuadrados.Add(cuadrado);
                    break;
                case "rectangulo":
                    var partesR = parametros.Split(',');
                    var rectangulo = new Rectangulo { Base = double.Parse(partesR[0]), Altura = double.Parse(partesR[1]), Volumen = valor, Tipo = "Rectangulo", FechaCalculo = DateTime.UtcNow };
                    _context.Rectangulos.Add(rectangulo);
                    break;
                case "circulo":
                    var circulo = new Circulo { Radio = double.Parse(parametros), Volumen = valor, Tipo = "Circulo", FechaCalculo = DateTime.UtcNow };
                    _context.Circulos.Add(circulo);
                    break;
            }
            _context.SaveChanges();
        }

        public void GuardarResultadoPerimetro(string tipoFigura, double valor, string parametros)
        {
            switch (tipoFigura.ToLower())
            {
                case "cuadrado":
                    var cuadrado = new Cuadrado { Lado = double.Parse(parametros), Perimetro = valor, Tipo = "Cuadrado", FechaCalculo = DateTime.UtcNow };
                    _context.Cuadrados.Add(cuadrado);
                    break;
                case "rectangulo":
                    var partes = parametros.Split(',');
                    var rectangulo = new Rectangulo { Base = double.Parse(partes[0]), Altura = double.Parse(partes[1]), Perimetro = valor, Tipo = "Rectangulo", FechaCalculo = DateTime.UtcNow };
                    _context.Rectangulos.Add(rectangulo);
                    break;
                case "circulo":
                    var circulo = new Circulo { Radio = double.Parse(parametros), Perimetro = valor, Tipo = "Circulo", FechaCalculo = DateTime.UtcNow };
                    _context.Circulos.Add(circulo);
                    break;
                case "cubo":
                    var cubo = new Cubo { Lado = double.Parse(parametros), Perimetro = valor, Tipo = "Cubo", FechaCalculo = DateTime.UtcNow };
                    _context.Cubos.Add(cubo);
                    break;
                case "esfera":
                    var esfera = new Esfera { Radio = double.Parse(parametros), Perimetro = valor, Tipo = "Esfera", FechaCalculo = DateTime.UtcNow };
                    _context.Esferas.Add(esfera);
                    break;
                case "cilindro":
                    var partesCil = parametros.Split(',');
                    var cilindro = new Cilindro { Radio = double.Parse(partesCil[0]), Altura = double.Parse(partesCil[1]), Perimetro = valor, Tipo = "Cilindro", FechaCalculo = DateTime.UtcNow };
                    _context.Cilindros.Add(cilindro);
                    break;
            }
            _context.SaveChanges();
        }
    }
} 
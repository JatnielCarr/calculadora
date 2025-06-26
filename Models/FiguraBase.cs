using System;

namespace AREASYVOLUMENES.Models
{
    public abstract class FiguraBase
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public double Area { get; set; }
        public double Volumen { get; set; }
        public double Perimetro { get; set; }
        public DateTime FechaCalculo { get; set; } = DateTime.UtcNow;
    }
} 
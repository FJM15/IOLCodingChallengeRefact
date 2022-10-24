using System;

namespace CodingChallenge.Data.Models
{
    public class Circulo : IFormaGeometrica
    {
        protected readonly decimal Diametro;

        public Circulo(decimal diametro) =>
            Diametro = diametro;

        public decimal CalcularArea() =>
            (decimal)Math.PI * (Diametro / 2) * (Diametro / 2);

        public decimal CalcularPerimetro() =>
            (decimal)Math.PI * Diametro;
    }
}
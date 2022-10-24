using System;

namespace CodingChallenge.Data.Models
{
    public class Cuadrado : IFormaGeometrica
    {
        protected readonly decimal Lado;

        public Cuadrado(decimal lado) =>
            Lado = lado;

        public decimal CalcularArea() =>
            Lado * Lado;

        public decimal CalcularPerimetro() =>
            Lado * 4;
    }
}
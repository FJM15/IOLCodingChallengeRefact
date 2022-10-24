using System;

namespace CodingChallenge.Data.Models
{
    public abstract class Triangulo : IFormaGeometrica
    {
        protected readonly decimal BaseInferior;
        protected readonly decimal Altura;

        public Triangulo(decimal baseInferior, decimal altura)
        {
            BaseInferior = baseInferior;
            Altura = altura;
        }

        public virtual decimal CalcularArea() =>
            BaseInferior * Altura / 2;

        public abstract decimal CalcularPerimetro();
    }
}
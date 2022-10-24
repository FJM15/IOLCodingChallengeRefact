using System;

namespace CodingChallenge.Data.Models
{
    public abstract class Trapecio : IFormaGeometrica
    {
        protected readonly decimal BaseInferior;
        protected readonly decimal BaseSuperior;
        protected readonly decimal Altura;

        public Trapecio(decimal baseInferior, decimal baseSuperior, decimal altura)
        {
            BaseInferior = baseInferior;
            BaseSuperior = baseSuperior;
            Altura = altura;
        }

        public virtual decimal CalcularArea() =>
            (BaseInferior + BaseSuperior) * Altura / 2;

        public abstract decimal CalcularPerimetro();
    }
}
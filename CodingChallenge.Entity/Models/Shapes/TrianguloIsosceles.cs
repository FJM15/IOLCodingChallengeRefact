using System;

namespace CodingChallenge.Data.Models
{
    public class TrianguloIsosceles : Triangulo
    {
        public TrianguloIsosceles(decimal baseInferior, decimal altura) : base(baseInferior, altura) { }

        public override decimal CalcularPerimetro() =>
            BaseInferior + 2 * (decimal)(Math.Sqrt((double)((BaseInferior / 2) * (BaseInferior / 2) + Altura * Altura)));
    }
}
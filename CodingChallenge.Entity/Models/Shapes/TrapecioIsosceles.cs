using System;

namespace CodingChallenge.Data.Models
{
    public class TrapecioIsosceles : Trapecio
    {
        public TrapecioIsosceles(decimal baseInferior, decimal baseSuperior, decimal altura) : base(baseInferior, baseSuperior, altura) { }

        public override decimal CalcularPerimetro() =>
            BaseInferior + BaseSuperior + (decimal)Math.Sqrt(((double)(Math.Abs(BaseInferior - BaseSuperior) / 2) * (double)(Math.Abs(BaseInferior - BaseSuperior) / 2)) + (double)(Altura * Altura)) * 2;
    }
}
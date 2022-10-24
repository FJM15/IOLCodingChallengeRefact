using System;

namespace CodingChallenge.Data.Models
{
    public class TrapecioRectangulo : Trapecio
    {
        public TrapecioRectangulo(decimal baseInferior, decimal baseSuperior, decimal altura) : base(baseInferior, baseSuperior, altura) { }

        public override decimal CalcularPerimetro() =>
            BaseInferior + BaseSuperior + Altura + (decimal)(Math.Sqrt((double)((BaseInferior - BaseSuperior) * (BaseInferior - BaseSuperior) + (Altura * Altura))));
    }
}
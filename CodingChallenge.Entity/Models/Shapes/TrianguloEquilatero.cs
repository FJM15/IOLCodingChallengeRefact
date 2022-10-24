using System;

namespace CodingChallenge.Data.Models
{
    public class TrianguloEquilatero : Triangulo
    {
        public TrianguloEquilatero(decimal baseInferior) : base(baseInferior, 0) { }

        public override decimal CalcularArea() =>
            ((decimal)Math.Sqrt(3) / 4) * BaseInferior * BaseInferior;

        public override decimal CalcularPerimetro() =>
            BaseInferior * 3;
    }
}
using CodingChallenge.Data.Models;
using System;

namespace CodingChallenge.Data.Services.Shapes
{
    public static class FormaGeometricaContexto
    {
        public static IFormaGeometrica GenerarCirculo(decimal diametro = 0, decimal radio = 0) =>
            new Circulo(Math.Abs(diametro) > 0 ? Math.Abs(diametro) : Math.Abs(radio) * 2);

        public static IFormaGeometrica GenerarCuadrado(decimal lado) =>
            new Cuadrado(Math.Abs(lado));

        public static IFormaGeometrica GenerarTrapecioIsoceles(decimal baseInferior, decimal baseSuperior, decimal altura = 0, decimal lado = 0)
        {
            baseInferior = Math.Abs(baseInferior);
            baseSuperior = Math.Abs(baseSuperior);
            altura = Math.Abs(altura);
            lado = Math.Abs(lado);

            if (altura == 0 && lado != 0)
                altura = (decimal)(Math.Sqrt((double)Math.Abs(lado * lado - ((baseInferior - baseSuperior) / 2) * ((baseInferior - baseSuperior) / 2))));

            return new TrapecioIsosceles(baseInferior, baseSuperior, altura);
        }

        public static IFormaGeometrica GenerarTrapecioRectangulo(decimal baseInferior, decimal baseSuperior, decimal altura = 0, decimal lado = 0)
        {
            baseInferior = Math.Abs(baseInferior);
            baseSuperior = Math.Abs(baseSuperior);
            altura = Math.Abs(altura);
            lado = Math.Abs(lado);

            if (altura == 0 && lado != 0)
                altura = (decimal)(Math.Sqrt((double)Math.Abs(lado * lado - (baseInferior - baseSuperior) * (baseInferior - baseSuperior))));

            return new TrapecioRectangulo(baseInferior, baseSuperior, altura);
        }

        public static IFormaGeometrica GenerarTrianguloEquilatero(decimal lado) =>
            new TrianguloEquilatero(Math.Abs(lado));

        public static IFormaGeometrica GenerarTrianguloIsosceles(decimal baseInferior, decimal altura = 0, decimal lado = 0)
        {
            baseInferior = Math.Abs(baseInferior);
            altura = Math.Abs(altura);
            lado = Math.Abs(lado);

            if (altura == 0 && lado != 0)
                altura = (decimal)(Math.Sqrt((double)Math.Abs(lado * lado - (baseInferior / 2) * (baseInferior / 2))));

            return new TrianguloIsosceles(baseInferior, altura);
        }
    }
}
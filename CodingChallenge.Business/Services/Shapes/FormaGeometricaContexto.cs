using CodingChallenge.Data.Models;
using System;

namespace CodingChallenge.Data.Services.Shapes
{
    public static class FormaGeometricaContexto
    {
        public static IFormaGeometrica GenerarCirculo(decimal diametro = 0, decimal radio = 0) =>
            new Circulo(diametro > 0 ? diametro : radio * 2);

        public static IFormaGeometrica GenerarCuadrado(decimal lado) =>
            new Cuadrado(lado);

        public static IFormaGeometrica GenerarTrapecioIsoceles(decimal baseInferior, decimal baseSuperior, decimal altura = 0, decimal lado = 0) =>
            new TrapecioIsosceles(baseInferior, baseSuperior, altura > 0 ? altura : (decimal)(Math.Sqrt((double)(lado * lado - ((baseInferior - baseSuperior) / 2) * ((baseInferior - baseSuperior) / 2)))));

        public static IFormaGeometrica GenerarTrapecioRectangulo(decimal baseInferior, decimal baseSuperior, decimal altura = 0, decimal lado = 0) =>
            new TrapecioRectangulo(baseInferior, baseSuperior, altura > 0 ? altura : (decimal)(Math.Sqrt((double)(lado * lado - (baseInferior - baseSuperior) * (baseInferior - baseSuperior)))));

        public static IFormaGeometrica GenerarTrianguloEquilatero(decimal lado) =>
            new TrianguloEquilatero(lado);

        public static IFormaGeometrica GenerarTrianguloIsosceles(decimal baseInferior, decimal altura = 0, decimal lado = 0) =>
            new TrianguloIsosceles(baseInferior, altura > 0 ? altura : (decimal)(Math.Sqrt((double)(lado * lado - (baseInferior / 2) * (baseInferior / 2)))));
    }
}
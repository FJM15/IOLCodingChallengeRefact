using CodingChallenge.Data.Models;
using System;

namespace CodingChallenge.Data.Services.Shapes
{
    public static class FormaGeometricaContexto
    {
        public static IFormaGeometrica GenerarCirculo(decimal diametro = 0, decimal radio = 0) =>
            new Circulo(Math.Abs(diametro) > 0 ? Math.Abs(diametro) : Math.Abs(radio) > 0 ? Math.Abs(radio) * 2 : 1);

        public static IFormaGeometrica GenerarCuadrado(decimal lado) =>
            new Cuadrado(Math.Abs(lado) > 0 ? Math.Abs(lado) : 1);

        public static IFormaGeometrica GenerarTrapecioIsoceles(decimal baseInferior, decimal baseSuperior, decimal altura = 0, decimal lado = 0) =>
            new TrapecioIsosceles(Math.Abs(baseInferior) > 0 ? Math.Abs(baseInferior) : 1, Math.Abs(baseSuperior) > 0 ? Math.Abs(baseSuperior) : 1, Math.Abs(altura) > 0 ? Math.Abs(altura) : Math.Abs((decimal)(Math.Sqrt((double)Math.Abs(lado * lado - ((baseInferior - baseSuperior) / 2) * ((baseInferior - baseSuperior) / 2))))) > 0 ? Math.Abs(altura) > 0 ? Math.Abs(altura) : Math.Abs((decimal)(Math.Sqrt((double)Math.Abs(lado * lado - ((baseInferior - baseSuperior) / 2) * ((baseInferior - baseSuperior) / 2))))) : 1);

        public static IFormaGeometrica GenerarTrapecioRectangulo(decimal baseInferior, decimal baseSuperior, decimal altura = 0, decimal lado = 0) =>
            new TrapecioRectangulo(Math.Abs(baseInferior) > 0 ? Math.Abs(baseInferior) : 1, Math.Abs(baseSuperior) > 0 ? Math.Abs(baseSuperior) : 1, Math.Abs(altura) > 0 ? Math.Abs(altura) : Math.Abs((decimal)(Math.Sqrt((double)Math.Abs(lado * lado - (baseInferior - baseSuperior) * (baseInferior - baseSuperior))))) > 0 ? Math.Abs((decimal)(Math.Sqrt((double)Math.Abs(lado * lado - (baseInferior - baseSuperior) * (baseInferior - baseSuperior))))) : 1);

        public static IFormaGeometrica GenerarTrianguloEquilatero(decimal lado) =>
            new TrianguloEquilatero(Math.Abs(lado) > 0 ? Math.Abs(lado) : 1);

        public static IFormaGeometrica GenerarTrianguloIsosceles(decimal baseInferior, decimal altura = 0, decimal lado = 0) =>
            new TrianguloIsosceles(Math.Abs(baseInferior) > 0 ? Math.Abs(baseInferior) : 1, Math.Abs(altura) > 0 ? Math.Abs(altura) : Math.Abs((decimal)(Math.Sqrt((double)Math.Abs(lado * lado - (baseInferior / 2) * (baseInferior / 2))))) > 0 ? Math.Abs((decimal)(Math.Sqrt((double)Math.Abs(lado * lado - (baseInferior / 2) * (baseInferior / 2))))) : 1);
    }
}
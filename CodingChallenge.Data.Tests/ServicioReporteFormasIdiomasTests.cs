using System;
using System.Collections.Generic;
using CodingChallenge.Data.Models;
using CodingChallenge.Data.Models.Common;
using CodingChallenge.Data.Services.Shapes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    class ServicioReporteFormasIdiomasTests
    {
        #region Prueba de idiomas

        #region Prueba de idioma CASTELLANO

        #region Prueba de resumen de lista vacia

        [TestCase, Description("(Castellano) Resumen de lista vacia")]
        public void ResumenListaVaciaCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>();

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        #endregion

        #region Pruebas de calculo de area y perimetro en multiples figuras combinadas

        [TestCase, Description("(Castellano) Resumen de lista para multiples figuras, una de cada una de las existentes. Se testea calculo y texto en singular")]
        public void ResumenListaMultiplesFigurasUnaDeCadaUnaCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(5),
                FormaGeometricaContexto.GenerarCirculo(diametro: 3),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4),
                FormaGeometricaContexto.GenerarTrianguloIsosceles(3, lado: 4),
                FormaGeometricaContexto.GenerarTrapecioRectangulo(4, 3, altura: 1),
                FormaGeometricaContexto.GenerarTrapecioIsoceles(7, 5, altura: 1)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>1 Círculo | Área 7.07 | Perímetro 9.42 <br/>1 Triángulo equilátero | Área 6.93 | Perímetro 12 <br/>1 Triángulo isósceles | Área 5.56 | Perímetro 11 <br/>1 Trapecio rectángulo | Área 3.5 | Perímetro 9.41 <br/>1 Trapecio isósceles | Área 6 | Perímetro 14.83 <br/>TOTAL:<br/>6 Formas Perímetro 76.67 Área 54.06",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para multiples figuras. Es el test que ya estaba configurado en el Challenge.")]
        public void ResumenListaMultiplesFigurasCombinadasOriginalCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(5),
                FormaGeometricaContexto.GenerarCirculo(diametro: 3),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4),
                FormaGeometricaContexto.GenerarCuadrado(2),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(9),
                FormaGeometricaContexto.GenerarCirculo(diametro: 2.75m),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4.2m)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13.01 | Perímetro 18.06 <br/>3 Triángulos equiláteros | Área 49.64 | Perímetro 51.6 <br/>TOTAL:<br/>7 Formas Perímetro 97.66 Área 91.65",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para multiples figuras, mas de una de cada tipo de las existentes. Se testea calculo y texto en plural")]
        public void ResumenListaMultiplesFigurasCombinadasConTodasLasFormasCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(5),
                FormaGeometricaContexto.GenerarCirculo(diametro: 3),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4),
                FormaGeometricaContexto.GenerarTrianguloIsosceles(3, lado: 4),
                FormaGeometricaContexto.GenerarTrapecioRectangulo(4, 3, altura: 1),
                FormaGeometricaContexto.GenerarTrapecioRectangulo(4, 3, altura: 2),
                FormaGeometricaContexto.GenerarTrapecioIsoceles(7, 5, altura: 1),
                FormaGeometricaContexto.GenerarCuadrado(2),
                FormaGeometricaContexto.GenerarTrianguloIsosceles(3, lado: 4),
                FormaGeometricaContexto.GenerarCirculo(diametro: 2.75m),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4.2m),
                FormaGeometricaContexto.GenerarTrapecioIsoceles(3, 2, altura: 1)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13.01 | Perímetro 18.06 <br/>2 Triángulos equiláteros | Área 14.57 | Perímetro 24.6 <br/>2 Triángulos isósceles | Área 11.12 | Perímetro 22 <br/>2 Trapecios rectángulo | Área 10.5 | Perímetro 20.65 <br/>2 Trapecios isósceles | Área 8.5 | Perímetro 22.06 <br/>TOTAL:<br/>12 Formas Perímetro 135.38 Área 86.7",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        #endregion

        #endregion

        #region Prueba de idioma INGLES

        #region Prueba de resumen de lista vacia

        [TestCase, Description("(Ingles) Resumen de lista vacia en ingles")]
        public void ResumenListaVaciaEnTest()
        {
            var listaFormas = new List<IFormaGeometrica>();

            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Ingles));
        }

        #endregion

        #region Pruebas de calculo de area y perimetro en multiples figuras combinadas

        [TestCase, Description("(Ingles) Resumen de lista para multiples figuras, una de cada una de las existentes. Se testea calculo y texto en singular")]
        public void ResumenListaMultiplesFigurasUnaDeCadaUnaEnTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(5),
                FormaGeometricaContexto.GenerarCirculo(diametro: 3),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4),
                FormaGeometricaContexto.GenerarTrianguloIsosceles(3, lado: 4),
                FormaGeometricaContexto.GenerarTrapecioRectangulo(4, 3, altura: 1),
                FormaGeometricaContexto.GenerarTrapecioIsoceles(7, 5, altura: 1)
            };

            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>1 Circle | Area 7.07 | Perimeter 9.42 <br/>1 Equilateral triangle | Area 6.93 | Perimeter 12 <br/>1 Isosceles triangle | Area 5.56 | Perimeter 11 <br/>1 Rectangular trapezium | Area 3.5 | Perimeter 9.41 <br/>1 Isosceles trapezium | Area 6 | Perimeter 14.83 <br/>TOTAL:<br/>6 Shapes Perimeter 76.67 Area 54.06",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Ingles));
        }

        [TestCase, Description("(Ingles) Resumen de lista para multiples figuras. Es el test que ya estaba configurado en el Challenge.")]
        public void ResumenListaMultiplesFigurasCombinadasOriginalEnTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(5),
                FormaGeometricaContexto.GenerarCirculo(diametro: 3),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4),
                FormaGeometricaContexto.GenerarCuadrado(2),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(9),
                FormaGeometricaContexto.GenerarCirculo(diametro: 2.75m),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4.2m)
            };

            Assert.AreEqual("<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Equilateral triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 Shapes Perimeter 97.66 Area 91.65",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Ingles));
        }

        [TestCase, Description("(Ingles) Resumen de lista para multiples figuras, mas de una de cada tipo de las existentes. Se testea calculo y texto en plural")]
        public void ResumenListaMultiplesFigurasCombinadasConTodasLasFormasEnTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(5),
                FormaGeometricaContexto.GenerarCirculo(diametro: 3),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4),
                FormaGeometricaContexto.GenerarTrianguloIsosceles(3, lado: 4),
                FormaGeometricaContexto.GenerarTrapecioRectangulo(4, 3, altura: 1),
                FormaGeometricaContexto.GenerarTrapecioRectangulo(4, 3, altura: 2),
                FormaGeometricaContexto.GenerarTrapecioIsoceles(7, 5, altura: 1),
                FormaGeometricaContexto.GenerarCuadrado(2),
                FormaGeometricaContexto.GenerarTrianguloIsosceles(3, lado: 4),
                FormaGeometricaContexto.GenerarCirculo(diametro: 2.75m),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4.2m),
                FormaGeometricaContexto.GenerarTrapecioIsoceles(3, 2, altura: 1)
            };

            Assert.AreEqual("<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>2 Equilateral triangles | Area 14.57 | Perimeter 24.6 <br/>2 Isosceles triangles | Area 11.12 | Perimeter 22 <br/>2 Rectangular trapeziums | Area 10.5 | Perimeter 20.65 <br/>2 Isosceles trapeziums | Area 8.5 | Perimeter 22.06 <br/>TOTAL:<br/>12 Shapes Perimeter 135.38 Area 86.7",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Ingles));
        }

        #endregion

        #endregion

        #region Prueba de idioma FRANCES

        #region Prueba de resumen de lista vacia

        [TestCase, Description("(Frances) Resumen de lista vacia")]
        public void ResumenListaVaciaFrTest()
        {
            var listaFormas = new List<IFormaGeometrica>();

            var asdasd = ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Frances);

            Assert.AreEqual("<h1>Liste de formes vide !</h1>",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Frances));
        }

        #endregion

        #region Pruebas de calculo de area y perimetro en multiples figuras combinadas

        [TestCase, Description("(Frances) Resumen de lista para multiples figuras, una de cada una de las existentes. Se testea calculo y texto en singular")]
        public void ResumenListaMultiplesFigurasUnaDeCadaUnaFrTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(5),
                FormaGeometricaContexto.GenerarCirculo(diametro: 3),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4),
                FormaGeometricaContexto.GenerarTrianguloIsosceles(3, lado: 4),
                FormaGeometricaContexto.GenerarTrapecioRectangulo(4, 3, altura: 1),
                FormaGeometricaContexto.GenerarTrapecioIsoceles(7, 5, altura: 1)
            };

            Assert.AreEqual("<h1>Rapport de formes</h1>1 Carré | Région 25 | Périmètre 20 <br/>1 Cercle | Région 7.07 | Périmètre 9.42 <br/>1 Triangle équilatéral | Région 6.93 | Périmètre 12 <br/>1 Triangle isocèle | Région 5.56 | Périmètre 11 <br/>1 Trapèze rectangle | Région 3.5 | Périmètre 9.41 <br/>1 Trapèze isocèle | Région 6 | Périmètre 14.83 <br/>TOTAL:<br/>6 Formes Périmètre 76.67 Région 54.06",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Frances));
        }

        [TestCase, Description("(Frances) Resumen de lista para multiples figuras. Es el test que ya estaba configurado en el Challenge.")]
        public void ResumenListaMultiplesFigurasCombinadasOriginalFrTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(5),
                FormaGeometricaContexto.GenerarCirculo(diametro: 3),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4),
                FormaGeometricaContexto.GenerarCuadrado(2),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(9),
                FormaGeometricaContexto.GenerarCirculo(diametro: 2.75m),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4.2m)
            };

            Assert.AreEqual("<h1>Rapport de formes</h1>2 Carrés | Région 29 | Périmètre 28 <br/>2 Cercles | Région 13.01 | Périmètre 18.06 <br/>3 Triangles équilatéraux | Région 49.64 | Périmètre 51.6 <br/>TOTAL:<br/>7 Formes Périmètre 97.66 Région 91.65",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Frances));
        }

        [TestCase, Description("(Frances) Resumen de lista para multiples figuras, mas de una de cada tipo de las existentes. Se testea calculo y texto en plural")]
        public void ResumenListaMultiplesFigurasCombinadasConTodasLasFormasFrTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(5),
                FormaGeometricaContexto.GenerarCirculo(diametro: 3),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4),
                FormaGeometricaContexto.GenerarTrianguloIsosceles(3, lado: 4),
                FormaGeometricaContexto.GenerarTrapecioRectangulo(4, 3, altura: 1),
                FormaGeometricaContexto.GenerarTrapecioRectangulo(4, 3, altura: 2),
                FormaGeometricaContexto.GenerarTrapecioIsoceles(7, 5, altura: 1),
                FormaGeometricaContexto.GenerarCuadrado(2),
                FormaGeometricaContexto.GenerarTrianguloIsosceles(3, lado: 4),
                FormaGeometricaContexto.GenerarCirculo(diametro: 2.75m),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(4.2m),
                FormaGeometricaContexto.GenerarTrapecioIsoceles(3, 2, altura: 1)
            };

            Assert.AreEqual("<h1>Rapport de formes</h1>2 Carrés | Région 29 | Périmètre 28 <br/>2 Cercles | Région 13.01 | Périmètre 18.06 <br/>2 Triangles équilatéraux | Région 14.57 | Périmètre 24.6 <br/>2 Triangles isocèles | Région 11.12 | Périmètre 22 <br/>2 Trapèzes rectangles | Région 10.5 | Périmètre 20.65 <br/>2 Trapèzes isocèles | Région 8.5 | Périmètre 22.06 <br/>TOTAL:<br/>12 Formes Périmètre 135.38 Région 86.7",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Frances));
        }

        #endregion

        #endregion

        #endregion
    }
}
using System;
using System.Collections.Generic;
using CodingChallenge.Data.Models;
using CodingChallenge.Data.Models.Common;
using CodingChallenge.Data.Services.Shapes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    class ServicioReporteFormasCalculosTests
    {
        #region Prueba de calculos de figuras en idioma CASTELLANO

        #region Pruebas de calculo de area y perimetro en figuras geometricas simples

        // Pruebas de calculo de area y perimetro en figuras geometricas
        [TestCase, Description("(Castellano) Resumen de lista para un circulo por diametro. Se testea calculo y texto en singular")]
        public void ResumenListaUnCirculoPorDiametroCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCirculo(diametro: 6)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Círculo | Área 28.27 | Perímetro 18.85 <br/>TOTAL:<br/>1 Forma Perímetro 18.85 Área 28.27",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un circulo por radio. Se testea calculo y texto en singular")]
        public void ResumenListaUnCirculoPorRadioCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCirculo(radio: 3)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Círculo | Área 28.27 | Perímetro 18.85 <br/>TOTAL:<br/>1 Forma Perímetro 18.85 Área 28.27",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un cuadrado. Se testea calculo y texto en singular")]
        public void ResumenListaUnCuadradoCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(5)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 Forma Perímetro 20 Área 25",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un trapecio isosceles por altura. Se testea calculo y texto en singular")]
        public void ResumenListaUnTrapecioIsocelesPorAlturaCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrapecioIsoceles(15, 12, altura: 6)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio isósceles | Área 81 | Perímetro 39.37 <br/>TOTAL:<br/>1 Forma Perímetro 39.37 Área 81",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un trapecio isosceles por lado. Se testea calculo y texto en singular")]
        public void ResumenListaUnTrapecioIsocelesPorLadoCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrapecioIsoceles(15, 12, lado: 6.1846m)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio isósceles | Área 81.00 | Perímetro 39.37 <br/>TOTAL:<br/>1 Forma Perímetro 39.37 Área 81.00",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un trapecio rectangulo por altura. Se testea calculo y texto en singular")]
        public void ResumenListaUnTrapecioRectanguloPorAlturaCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrapecioRectangulo(5, 4, altura: 3)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio rectángulo | Área 13.5 | Perímetro 15.16 <br/>TOTAL:<br/>1 Forma Perímetro 15.16 Área 13.5",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un trapecio rectangulo por lado. Se testea calculo y texto en singular")]
        public void ResumenListaUnTrapecioRectanguloPorLadoCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrapecioRectangulo(5, 4, lado: 3.1622m)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio rectángulo | Área 13.50 | Perímetro 15.16 <br/>TOTAL:<br/>1 Forma Perímetro 15.16 Área 13.50",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un triangulo equilatero. Se testea calculo y texto en singular")]
        public void ResumenListaUnTrianguloEquilateroCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrianguloEquilatero(5)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triángulo equilátero | Área 10.83 | Perímetro 15 <br/>TOTAL:<br/>1 Forma Perímetro 15 Área 10.83",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un triangulo isosceles por altura. Se testea calculo y texto en singular")]
        public void ResumenListaUnTrianguloIsoscelesPorAlturaCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrianguloIsosceles(12, altura: 8)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triángulo isósceles | Área 48 | Perímetro 32 <br/>TOTAL:<br/>1 Forma Perímetro 32 Área 48",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un triangulo isosceles por lado. Se testea calculo y texto en singular")]
        public void ResumenListaUnTrianguloIsoscelesPorLadoCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrianguloIsosceles(12, lado: 10)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triángulo isósceles | Área 48 | Perímetro 32 <br/>TOTAL:<br/>1 Forma Perímetro 32 Área 48",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        #endregion

        #region Pruebas de calculo de area y perimetro en multiples figuras simples

        [TestCase, Description("(Castellano) Resumen de lista para multiples circulos. Se testea calculo y texto en plural")]
        public void ResumenListaDosCirculosCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCirculo(radio: 3),
                FormaGeometricaContexto.GenerarCirculo(radio: 3)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Círculos | Área 56.55 | Perímetro 37.70 <br/>TOTAL:<br/>2 Formas Perímetro 37.70 Área 56.55",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para multiples cuadrados. Se testea calculo y texto en plural")]
        public void ResumenListaDosCuadradosCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(1),
                FormaGeometricaContexto.GenerarCuadrado(2),
                FormaGeometricaContexto.GenerarCuadrado(3)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Cuadrados | Área 14 | Perímetro 24 <br/>TOTAL:<br/>3 Formas Perímetro 24 Área 14",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para multiples trapecios isosceles. Se testea calculo y texto en plural")]
        public void ResumenListaDosTrapeciosIsocelesCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrapecioIsoceles(15, 12, altura: 6),
                FormaGeometricaContexto.GenerarTrapecioIsoceles(15, 12, altura: 6)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Trapecios isósceles | Área 162 | Perímetro 78.74 <br/>TOTAL:<br/>2 Formas Perímetro 78.74 Área 162",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para multiples trapecios rectangulo. Se testea calculo y texto en plural")]
        public void ResumenListaDosTrapeciosRectanguloCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrapecioRectangulo(5, 4, lado: 3.1622m),
                FormaGeometricaContexto.GenerarTrapecioRectangulo(5, 4, lado: 3.1622m)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Trapecios rectángulo | Área 27.00 | Perímetro 30.32 <br/>TOTAL:<br/>2 Formas Perímetro 30.32 Área 27.00",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para multiples triangulos equilatero. Se testea calculo y texto en plural")]
        public void ResumenListaTesTriangulosEquilateroCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrianguloEquilatero(1),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(2),
                FormaGeometricaContexto.GenerarTrianguloEquilatero(3)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Triángulos equiláteros | Área 6.06 | Perímetro 18 <br/>TOTAL:<br/>3 Formas Perímetro 18 Área 6.06",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para multiples triangulos isosceles. Se testea calculo y texto en plural")]
        [TestCase]
        public void ResumenListaTesTriangulosIsoscelesCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrianguloIsosceles(12, altura: 8),
                FormaGeometricaContexto.GenerarTrianguloIsosceles(12, altura: 8)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Triángulos isósceles | Área 96 | Perímetro 64 <br/>TOTAL:<br/>2 Formas Perímetro 64 Área 96",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        #endregion

        #endregion
    }
}
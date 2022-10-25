using System;
using System.Collections.Generic;
using CodingChallenge.Data.Models;
using CodingChallenge.Data.Models.Common;
using CodingChallenge.Data.Services.Shapes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    class ServicioReporteFormasParametrosTests
    {
        #region Prueba de parametros de entrada para la creacion de formas geometricas

        #region Pruebas de calculo de area y perimetro en figuras con parametros de entrada cero

        // Pruebas de calculo de area y perimetro en figuras geometricas
        [TestCase, Description("(Castellano) Resumen de lista para un circulo con diametro 0")]
        public void ResumenListaUnCirculoCeroCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCirculo(diametro: 0)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Círculo | Área 0 | Perímetro 0 <br/>TOTAL:<br/>1 Forma Perímetro 0 Área 0",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }
        
        [TestCase, Description("(Castellano) Resumen de lista para un cuadrado con lado 0")]
        public void ResumenListaUnCuadradoCeroCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(0)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 0 | Perímetro 0 <br/>TOTAL:<br/>1 Forma Perímetro 0 Área 0",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un trapecio isosceles con bases y altura 0")]
        public void ResumenListaUnTrapecioIsocelesCeroCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrapecioIsoceles(0, 0, altura: 0)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio isósceles | Área 0 | Perímetro 0 <br/>TOTAL:<br/>1 Forma Perímetro 0 Área 0",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un trapecio rectangulo con bases y altura 0")]
        public void ResumenListaUnTrapecioRectanguloCeroCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrapecioRectangulo(0, 0, altura: 0)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio rectángulo | Área 0 | Perímetro 0 <br/>TOTAL:<br/>1 Forma Perímetro 0 Área 0",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un triangulo equilatero con lado 0")]
        public void ResumenListaUnTrianguloEquilateroCeroCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrianguloEquilatero(0)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triángulo equilátero | Área 0 | Perímetro 0 <br/>TOTAL:<br/>1 Forma Perímetro 0 Área 0",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un triangulo isosceles con base y altura 0")]
        public void ResumenListaUnTrianguloIsoscelesCeroCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrianguloIsosceles(0, altura: 0)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triángulo isósceles | Área 0 | Perímetro 0 <br/>TOTAL:<br/>1 Forma Perímetro 0 Área 0",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        #endregion

        #region Pruebas de calculo de area y perimetro en figuras con parametros de entrada negativos

        // Pruebas de calculo de area y perimetro en figuras geometricas
        [TestCase, Description("(Castellano) Resumen de lista para un circulo con diametro negativo")]
        public void ResumenListaUnCirculoNegativoCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCirculo(diametro: -6)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Círculo | Área 28.27 | Perímetro 18.85 <br/>TOTAL:<br/>1 Forma Perímetro 18.85 Área 28.27",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un cuadrado con lado negativo")]
        public void ResumenListaUnCuadradoNegativoCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarCuadrado(5)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 Forma Perímetro 20 Área 25",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un trapecio isosceles con altura negativa")]
        public void ResumenListaUnTrapecioIsocelesNegativoCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrapecioIsoceles(15, 12, altura: 6)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio isósceles | Área 81 | Perímetro 39.37 <br/>TOTAL:<br/>1 Forma Perímetro 39.37 Área 81",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un trapecio rectangulo con altura negativa")]
        public void ResumenListaUnTrapecioRectanguloNegativoCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrapecioRectangulo(5, 4, altura: 3)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio rectángulo | Área 13.5 | Perímetro 15.16 <br/>TOTAL:<br/>1 Forma Perímetro 15.16 Área 13.5",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un triangulo equilatero con lado negativo")]
        public void ResumenListaUnTrianguloEquilateroNegativoCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrianguloEquilatero(5)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triángulo equilátero | Área 10.83 | Perímetro 15 <br/>TOTAL:<br/>1 Forma Perímetro 15 Área 10.83",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        [TestCase, Description("(Castellano) Resumen de lista para un triangulo isosceles con altura negativa")]
        public void ResumenListaUnTrianguloIsoscelesNegativoCaTest()
        {
            var listaFormas = new List<IFormaGeometrica>()
            {
                FormaGeometricaContexto.GenerarTrianguloIsosceles(12, altura: 8)
            };

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triángulo isósceles | Área 48 | Perímetro 32 <br/>TOTAL:<br/>1 Forma Perímetro 32 Área 48",
                ServicioImpresionReporteFormas.Imprimir(listaFormas, Culturas.Castellano));
        }

        #endregion

        #endregion
    }
}

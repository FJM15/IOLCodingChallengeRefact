using CodingChallenge.Business.Services.Reports;
using CodingChallenge.Business.Services.Shapes;
using CodingChallenge.Data.Models;
using CodingChallenge.Data.Models.Reports;
using CodingChallenge.Data.Tools.Culture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Services.Shapes
{
    public static class ServicioImpresionReporteFormas
    {
        public static string Imprimir(List<IFormaGeometrica> formas, string cultura)
        {
            try
            {
                // Se instancia el traductor y se setea la cultura
                ITraductor tr = new TraductorRecurso(cultura);
                ServicioCultura.SetearCultura(cultura);

                // Armado de Reporte
                var sb = new StringBuilder();

                if (!formas.Any())
                    sb.Append(ServicioArmadoReporteFormas.GenerarLineaReporteVacio(tr));
                else
                    sb.Append(ServicioArmadoReporteFormas.GenerarReporteFormas(CalculoFormas.CalcularPorLista(formas), tr));

                // Se revierte a cultura original
                ServicioCultura.RevertirCultura();

                return sb.ToString();
            }
            catch (Exception)
            {
                // De ocurrir un error se retorna vacio
                return "";
            }
        }
    }
}
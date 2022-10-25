using CodingChallenge.Data.Models.Reports;
using CodingChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Business.Services.Reports
{
    internal static class ServicioArmadoReporteFormas
    {
        internal static string GenerarLineaReporteVacio(ITraductor tr) =>
            $"{ tr.GetTraduccion("encabezado_vacio") }";

        internal static string GenerarReporteFormas(List<ReporteFormas> lista_formas_reporte, ITraductor tr)
        {
            try
            {
                var sb = new StringBuilder();

                // HEADER
                sb.Append(GenerarLineaEncabezadoReporte(tr));

                // BODY
                foreach (var forma in lista_formas_reporte)
                    sb.Append(GenerarLineaForma(forma, tr));

                // FOOTER
                sb.Append(GenerarLineaPieReporte(lista_formas_reporte, tr));

                return sb.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }

        private static string GenerarLineaEncabezadoReporte(ITraductor tr) =>
            $"{ tr.GetTraduccion("encabezado") }";

        private static string GenerarLineaForma(ReporteFormas forma, ITraductor tr) =>
            $"{ forma.Cantidad } { (forma.Cantidad == 1 ? tr.GetTraduccion(forma.Forma.ToLower() + "_s") : tr.GetTraduccion(forma.Forma.ToLower() + "_p")) } | { tr.GetTraduccion("area") } { Decimal.Round(forma.SumaAreas, 2) } | { tr.GetTraduccion("perimetro") } { Decimal.Round(forma.SumaPerimetros, 2) } { tr.GetTraduccion("salto_linea") }";

        private static string GenerarLineaPieReporte(List<ReporteFormas> lista_formas_reporte, ITraductor tr)
        {
            var sb = new StringBuilder();

            sb.Append($"{ tr.GetTraduccion("total") }{ tr.GetTraduccion("salto_linea") }");
            sb.Append($"{ lista_formas_reporte.Sum(f => f.Cantidad) } { (lista_formas_reporte.Sum(c => c.Cantidad) == 1 ? tr.GetTraduccion("forma_s") : tr.GetTraduccion("forma_p")) } ");
            sb.Append($"{ tr.GetTraduccion("perimetro") } { Decimal.Round(lista_formas_reporte.Sum(p => p.SumaPerimetros), 2) } ");
            sb.Append($"{ tr.GetTraduccion("area") } { Decimal.Round(lista_formas_reporte.Sum(a => a.SumaAreas), 2) }");

            return sb.ToString();
        }
    }
}

using CodingChallenge.Data.Models;
using CodingChallenge.Data.Models.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Business.Services.Shapes
{
    internal static class CalculoFormas
    {
        internal static List<ReporteFormas> CalcularPorLista(List<IFormaGeometrica> formas)
        {
            try
            {
                var lista_formas_reporte = (from f in formas
                                            group f by f.GetType().Name into t
                                            select new ReporteFormas()
                                            {
                                                Forma = t.Key,
                                                Cantidad = t.Count(),
                                                SumaAreas = t.Sum(a => a.CalcularArea()),
                                                SumaPerimetros = t.Sum(p => p.CalcularPerimetro())
                                            }).ToList();

                return lista_formas_reporte;
            }
            catch (Exception)
            {
                return new List<ReporteFormas>();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Models.Reports
{
    public class ReporteFormas
    {
        public string Forma { get; set; }
        public int Cantidad { get; set; }
        public decimal SumaAreas { get; set; }
        public decimal SumaPerimetros { get; set; }
    }
}
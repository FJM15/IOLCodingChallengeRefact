using CodingChallenge.Data.Models.Common;
using System;
using System.Globalization;
using System.Threading;

namespace CodingChallenge.Data.Tools.Culture
{
    public static class ServicioCultura
    {
        private static readonly CultureInfo _originalCultureUIInfo = Thread.CurrentThread.CurrentUICulture;
        private static readonly CultureInfo _originalCultureInfo = Thread.CurrentThread.CurrentCulture;

        public static void SetearCultura(string cultura)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultura);
        }

        public static void RevertirCultura()
        {
            Thread.CurrentThread.CurrentUICulture = _originalCultureUIInfo;
            Thread.CurrentThread.CurrentCulture = _originalCultureInfo;
        }
    }
}
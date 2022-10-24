using System;
using System.Globalization;
using System.Threading;

namespace CodingChallenge.Data.Tools.Culture
{
    public static class ServicioCultura
    {
        private static readonly CultureInfo _originalCultureUIInfo = Thread.CurrentThread.CurrentUICulture;

        public static void SetearCultura(string cultura) =>
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);

        public static void RevertirCultura() =>
            Thread.CurrentThread.CurrentUICulture = _originalCultureUIInfo;
    }
}

using System.Globalization;
using System.Threading;

namespace Handy.DotNETCoreCompatibility.StandardLibrary
{
    public class CultureInfoWrapper
    {
        public static CultureInfo GetCultureFromCode(string code) {
#if NET_STANDARD
            return new CultureInfo(code);
#else
            return CultureInfo.CreateSpecificCulture(code);
#endif
        }

        public static void SetCurrentCulture(CultureInfo ci)
        {
#if NET_STANDARD
            CultureInfo.CurrentCulture = ci;
#else
            Thread.CurrentThread.CurrentCulture = ci;
#endif
        }

        public static void SetCurrentUICulture(CultureInfo ci)
        {
#if NET_STANDARD
            CultureInfo.CurrentUICulture = ci;
#else
            Thread.CurrentThread.CurrentUICulture = ci;
#endif
        }
    }
}

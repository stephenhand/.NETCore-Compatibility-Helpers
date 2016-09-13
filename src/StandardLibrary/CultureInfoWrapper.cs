
using System.Globalization;

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
    }
}

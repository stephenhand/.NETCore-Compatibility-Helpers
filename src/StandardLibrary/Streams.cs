using System;
using System.IO;

namespace Handy.DotNETCoreCompatibility.StandardLibrary
{
    public static class Streams
    {
#if NET_STANDARD
        public static byte[] GetBuffer(this MemoryStream source)
        {
            ArraySegment<byte> bufferSegment;
            if (source.TryGetBuffer(out bufferSegment))
            {
                return bufferSegment.Array;
            }

            throw new UnauthorizedAccessException("Unauthorized access to MemoryStream buffer");
        }
#endif

    }
}

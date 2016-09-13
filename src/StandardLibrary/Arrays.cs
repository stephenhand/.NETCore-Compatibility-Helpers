using System;
using System.Collections.Generic;

namespace Handy.DotNETCoreCompatibility.StandardLibrary
{
    public class Arrays
    {
#if NET_STANDARD
        public static void Copy(Array sourceArray, Array destinationArray, long length)
        {
            if (length > Int32.MaxValue || length < Int32.MinValue)
                throw new ArgumentOutOfRangeException("length", "length too large");
            Array.Copy(sourceArray, destinationArray, (int)length);
        }
        
        public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
        {
            if (sourceIndex > Int32.MaxValue || sourceIndex < Int32.MinValue)
                throw new ArgumentOutOfRangeException("sourceIndex", "sourceIndex too large");
            if (destinationIndex > Int32.MaxValue || destinationIndex < Int32.MinValue)
                throw new ArgumentOutOfRangeException("destinationIndex", "destinationIndex too large");
            if (length > Int32.MaxValue || length < Int32.MinValue)
                throw new ArgumentOutOfRangeException("length" , "length too large");

            Array.Copy(sourceArray, (int)sourceIndex, destinationArray, (int)destinationIndex, (int)length);
        }
#else
        public static void Copy(Array sourceArray, Array destinationArray, long length)
        {
            Array.Copy(sourceArray, destinationArray, length);
        }
        
        public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
        {
            Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }
#endif
    }
}

using System;

using System.Reflection;

namespace BlueTreeSystems.BTMagma.Compatibility
{
    public class Reflection
    {
#if NET_STANDARD

            public static TypeInfo GetReflectionType(Object o)
            {
                return o.GetType().GetTypeInfo();
            }

            public static TypeInfo GetReflectionType(Type t)
            {
                return t.GetTypeInfo();
            }
        
#else


            public static Type GetReflectionType(Object o)
            {
                return o.GetType();
            }
            public static Type GetReflectionType(Type t)
            {
                return t;
            }
#endif
    }
}

using System;

namespace Handy.DotNETCoreCompatibility.ColourTranslations
{
    public struct ARGB
    {
        private readonly int a, r, g, b;

        public ARGB(int a, int r, int g, int b) {
            this.a = a;
            this.r = r;
            this.g = g;
            this.b = b;
        }
        public ARGB(int r, int g, int b) : this(255, r, g, b) { }

        public int A { get { return a; } }
        public int R { get { return r; } }
        public int G { get { return g; } }
        public int B { get { return b; } }

        public override string ToString()
        {
            return String.Format("A:{0}, R:{1}, G:{2}, B:{3}");
        }
    }
}

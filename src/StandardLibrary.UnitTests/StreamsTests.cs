using NUnit.Framework;
using System;
using System.IO;
#if NET_STANDARD
using Assert = NUnit.Framework.Assert;
using TestAttribute = Xunit.FactAttribute;
#endif

namespace Handy.DotNETCoreCompatibility.StandardLibrary.UnitTests
{
    [TestFixture]
    public class StreamsTests
    {
        [Test]
        public void GetBuffer_PubliclyAccessibleStream_GetsOriginalMemoryStreamBuffer() {
            var buff = new byte[] { 1, 5, 9 };
            Assert.AreSame(buff, new MemoryStream(buff,0, 3, false, true).GetBuffer());
        }
        
        [Test]
        public void GetBuffer_NonPubliclyAccessibleStream_Throws()
        {
            var buff = new byte[] { 1, 5, 9 };
            Assert.Throws<UnauthorizedAccessException>(()=> new MemoryStream(buff).GetBuffer());
        }
    }
}

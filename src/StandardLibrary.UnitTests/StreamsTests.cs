using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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

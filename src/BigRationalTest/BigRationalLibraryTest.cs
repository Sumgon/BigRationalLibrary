using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numerics;

namespace BigRationalTest {
    [TestClass]
    public class BigRationalLibraryTest
    {
        [TestMethod]
        public void Sqrt_Test() {

            var r = new BigRational(2, 1);
            Assert.AreEqual(r, BigRational.Sqrt(4));

            r = new BigRational(3,1);
            Assert.AreEqual(r, BigRational.Sqrt(9));

            r = new BigRational(BigInteger.Parse("2168488286494085478154297235187389205761"), BigInteger.Parse("685736206471705483022831680917430579904"));
            Assert.AreEqual(r, BigRational.Sqrt(10));
            
        }
    }
}

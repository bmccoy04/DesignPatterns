using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
    [TestClass]
    public class FacadeTests
    {
        private Adder _adder;
        [TestInitialize]
        public void init(){
            _adder = new Adder();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var expected = 3;
            var actual = _adder.Add(1, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}
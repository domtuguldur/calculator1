using calculatorlibrary1;

namespace calculatortest1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sum(10);
            result = calculator.Sub(20);
            result = calculator.Sub(30);
            Assert.AreEqual(-40, result);
        }
    }
}

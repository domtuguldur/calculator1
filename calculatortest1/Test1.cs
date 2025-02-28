using System.Reflection;
using System.Reflection.Metadata;
using calculatorlibrary1;
using Microsoft.VisualStudio.TestPlatform.TestHost;

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
        [TestMethod]
        public void TestMethod2()
        {
            Memory memory = new Memory();
            memory.hadgalah(10);
            Calculator calculator = new Calculator();
            calculator.results = memory.toonuud[0];
            int result = calculator.Sum(20);
            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Memory memory = new Memory();
            memory.hadgalah(5);
            memory.hadgalah(10);
            memory.hadgalah(15);
            memory.hadgalah(20);
            Calculator calculator = new Calculator();
            calculator.results = memory.toonuud[2];
            calculator.results = calculator.Sum(memory.toonuud[3]);
            Assert.AreEqual(35, calculator.results);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Memory memory = new Memory();
            memory.hadgalah(5);
            memory.hadgalah(10);
            memory.hadgalah(15);
            memory.hadgalah(20);
            Calculator calculator = new Calculator();
            calculator.results = memory.toonuud[2];
            memory.tsewereh();
            memory.hadgalah(25);
            calculator.results = memory.toonuud[0];
            Assert.AreEqual(25, calculator.results);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Memory memory = new Memory();
            memory.hadgalah(5);
            memory.hadgalah(6);
            memory.hadgalah(7);
            memory.harah();
            Assert.AreEqual(3, memory.toonuud.Count);
            memory.tsewereh();
            memory.harah();
            Assert.AreEqual(0, memory.toonuud.Count);
        }
    }
}

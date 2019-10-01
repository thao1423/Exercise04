using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsContain5() 

        {
            int[] Arr1 = new int[] { 1, 2, 3, 4 };
            bool result0 = Program.IsContain5(Arr1);
            Assert.AreEqual(false, result0);

            int[] Arr2 = new int[] { 1, 2, 3, 5 };
            bool result1 = Program.IsContain5(Arr2);
            Assert.AreEqual(false, result1);

        }
        
    }
}

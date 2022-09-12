using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumNumber;

namespace FindMaximumNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMaxFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            int num = max.FindMaxIntNumber(1,3,2);
            Assert.AreEqual(num, 7);
        }
    }
}

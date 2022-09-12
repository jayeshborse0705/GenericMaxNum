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
        [TestMethod]
        public void GivenMaxFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            float num = max.FindMaxFloatNumber(2.2f,3.4f, 5.2f);
            Assert.AreEqual(num,5.2f);
        }
        [TestMethod]
        public void GivenMaxFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            string num = max.FindMaxStringNumber("Apple","Banana","Strawberry");
            Assert.AreEqual(num, "Strawberry");
        }
    }
}
  
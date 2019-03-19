using Afgift;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void BilAfgiftStørreEnd200000Test()
        {
            //Arrange
            var bilafgift = new Afgift.Afgift();

            //Act
            double afgift = bilafgift.BilAfgift(20000);

            //Assert
            Assert.AreEqual(100000, afgift);

        }
        [TestMethod]
        public void BilAfgiftMindreEnd200000Test()
        {
            var bilafgift = new Afgift.Afgift();

            double afgift = bilafgift.BilAfgift(100000);

            Assert.AreEqual(20000, afgift);

        }

        [TestMethod]
        public void ElBilAfgiftTest()
        {
            var elBilAfgift = new Afgift.Afgift();

            double afgift = elBilAfgift.ElBilAfgift(100000);

            Assert.AreEqual(4000, afgift);


        }
    }
}

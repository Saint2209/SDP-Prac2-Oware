using NUnit.Framework;

namespace Oware.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            House h = new House(0, 0);
            //Act:
            h.ResetHouse();
            //Assert
            Assert.AreEqual(4,h.GetCount(),"Reseting house, sets all houses back all to 4 seeds each");
        }
        
    }
}
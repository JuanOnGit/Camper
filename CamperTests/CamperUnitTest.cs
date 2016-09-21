using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CamperTests
{
    [TestClass]
    public class CamperUnitTest
    {
        [TestMethod]
        public void GetGPSLocationTest()
        {
            //Arrange
            var latitude = 0;
            var longitude = 0;
            string[]  loc = new string[] { "0", "0" };
            var expected = loc;

            //Act
            GetGPSLocationTest();
            var actual = "";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetGearTest()
        {

        }

        [TestMethod]
        public void CheckGearTest()
        {

        }

        [TestMethod]
        public void GetCampSitesTest()
        {

        }

        [TestMethod]
        public void GetCamperLogTest()
        {

        }

        [TestMethod]
        public void AddCamperTest()
        {

        }

        [TestMethod]
        public void ViewCamperTest()
        {

        }

    }
}

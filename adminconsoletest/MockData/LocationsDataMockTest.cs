using adminconsole.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace adminconsoletest
{
    [TestClass]
    public class LocationsDataMockTest
    {
        [TestMethod]
        public void LocationsDataMock_Constructor_Should_Pass()
        {
            // Arrange
            
            
            // Act
            var dataMock = new LocationsDataMock();



            // Assert
            Assert.IsNotNull(dataMock);
        }
    }
}

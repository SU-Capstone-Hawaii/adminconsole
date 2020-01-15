using adminconsole.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace adminconsoletest
{
    [TestClass]
    public class ContactModelTest
    {
        [TestMethod]
        public void ContactModel_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new Contact();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ContactModel_Get_Property_Defaults_Should_Pass()
        {
            // Arrange
            var result = new Contact();

            // Act

            // Assert
            Assert.IsNull(result.Location);
            Assert.IsNull(result.LocationId);
            Assert.IsNull(result.Phone);
            Assert.IsNull(result.Fax);
            Assert.IsNull(result.Terminal);
        }

        [TestMethod]
        public void ContactModel_Set_Property_Should_Pass()
        {
            // Arrange
            var result = new Contact();

            // Act
            result.Location = new Locations();
            result.LocationId = "location id";
            result.Phone = "phone";
            result.Fax = "fax";
            result.Terminal = "terminal";

            // Assert
            Assert.IsNotNull(result.Location);
            Assert.AreEqual("location id", result.LocationId);
            Assert.AreEqual("phone", result.Phone);
            Assert.AreEqual("fax", result.Fax);
            Assert.AreEqual("terminal", result.Terminal);
        }
    }
}

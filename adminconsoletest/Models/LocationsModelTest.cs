using adminconsole.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace adminconsoletest
{
    [TestClass]
    public class LocationsModelTest
    {
        [TestMethod]
        public void LocationsModel_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new Locations();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LocationsModel_Get_Property_Defaults_Should_Pass()
        {
            // Arrange
            var result = new Locations();

            // Act

            // Assert
            Assert.IsNull(result.City);
            Assert.IsNull(result.Contact);
            Assert.IsNull(result.Hours);
            Assert.IsNull(result.InstitutionName);
            Assert.IsNull(result.Lat);
            Assert.IsNull(result.LocationId);
            Assert.IsNull(result.Long);
            Assert.IsNull(result.RetailOutlet);
            Assert.IsNull(result.SpecialQualities);
            Assert.IsNull(result.State);
            Assert.IsNull(result.Street);
            Assert.IsNull(result.TypeName);
            Assert.IsNull(result.Zipcode);
        }

        [TestMethod]
        public void LocationsModel_Set_Property_Should_Pass()
        {
            // Arrange
            var result = new Locations();

            // Act
            result.City = "city";
            result.Contact = new Contact();
            result.Hours = "hours";
            result.InstitutionName = "institution";
            result.Lat = 45.555M;
            result.LocationId = "locationid";
            result.Long = 45.555M;
            result.RetailOutlet = "retail";
            result.SpecialQualities = new SpecialQualities();
            result.State = "state";
            result.Street = "street";
            result.TypeName = "atm";
            result.Zipcode = "zip";

            // Assert
            Assert.IsNotNull(result.Contact);
            Assert.IsNotNull(result.SpecialQualities);

            Assert.AreEqual("city", result.City);
            Assert.AreEqual("hours", result.Hours);
            Assert.AreEqual("institution", result.InstitutionName);
            Assert.AreEqual(45.555M, result.Lat);
            Assert.AreEqual("locationid", result.LocationId);
            Assert.AreEqual(45.555M, result.Long);
            Assert.AreEqual("retail", result.RetailOutlet);
            Assert.AreEqual("state", result.State);
            Assert.AreEqual("street", result.Street);
            Assert.AreEqual("atm", result.TypeName);
            Assert.AreEqual("zip", result.Zipcode);
        }
    }
}

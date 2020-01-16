using adminconsole.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace adminconsoletest
{
    [TestClass]
    public class LocationsContactSpecialQualitiesViewModelTest
    {
        [TestMethod]
        public void LocationsContactSpecialQualitiesViewModel_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new LocationsContactSpecialQualitiesViewModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LocationsContactSpecialQualitiesViewModel_Get_Property_Defaults_Should_Pass()
        {
            // Arrange
            var result = new LocationsContactSpecialQualitiesViewModel();

            // Act

            // Assert
            // Locations
            Assert.IsNull(result.City);
            Assert.IsNull(result.contacts);
            Assert.IsNull(result.Hours);
            Assert.IsNull(result.InstitutionName);
            Assert.AreEqual(0.0M, result.Lat);
            Assert.IsNull(result.locations);
            Assert.IsNull(result.LocationId);
            Assert.AreEqual(0.0M, result.Long);
            Assert.IsNull(result.RetailOutlet);
            Assert.IsNull(result.specialQualities);
            Assert.IsNull(result.State);
            Assert.IsNull(result.Street);
            Assert.IsNull(result.TypeName);
            Assert.IsNull(result.Zipcode);

            // Contacts
            Assert.IsNull(result.Phone);
            Assert.IsNull(result.Fax);
            Assert.IsNull(result.Terminal);

            // Special Qualities
            Assert.IsNull(result.AcceptsCash);
            Assert.IsNull(result.AdditionalDetail);
            Assert.IsNull(result.Cashless);
            Assert.IsNull(result.DepositTaking);
            Assert.IsNull(result.HandicapAccess);
            Assert.IsNull(result.LimitedTransactions);
            Assert.IsNull(result.MilitaryIdrequired);
            Assert.IsNull(result.OnMilitaryBase);
            Assert.IsNull(result.RestrictedAccess);
            Assert.IsNull(result.SelfServiceOnly);
            Assert.IsNull(result.Surcharge);
        }

        [TestMethod]
        public void LocationsContactSpecialQualitiesViewModel_Set_Property_Should_Pass()
        {
            // Arrange
            var result = new LocationsContactSpecialQualitiesViewModel();

            // Act
            // Locations
            result.City = "city";
            result.contacts = new List<Contact>();
            result.Hours = "hours";
            result.InstitutionName = "institution";
            result.Lat = 45.555M;
            result.LocationId = "locationid";
            result.Long = 45.555M;
            result.RetailOutlet = "retail";
            result.specialQualities = new List<SpecialQualities>();
            result.State = "state";
            result.Street = "street";
            result.TypeName = "atm";
            result.Zipcode = "zip";

            // Contacts
            result.Phone = "phone";
            result.Fax = "fax";
            result.Terminal = "terminal";

            // SpecialQualities
            result.locations = new List<Locations>();
            result.AcceptsCash = true;
            result.AdditionalDetail = "additional";
            result.Cashless = true;
            result.DepositTaking = true;
            result.HandicapAccess = true;
            result.LimitedTransactions = true;
            result.MilitaryIdrequired = true;
            result.OnMilitaryBase = true;
            result.RestrictedAccess = true;
            result.SelfServiceOnly = true;
            result.Surcharge = true;

            // Assert
            // Locations
            Assert.IsNotNull(result.contacts);
            Assert.IsNotNull(result.specialQualities);
            Assert.AreEqual("locationid", result.LocationId);
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

            // Contacts
            Assert.AreEqual("phone", result.Phone);
            Assert.AreEqual("fax", result.Fax);
            Assert.AreEqual("terminal", result.Terminal);

            // SpecialQualities
            Assert.IsNotNull(result.locations);            Assert.AreEqual(true, result.AcceptsCash);
            Assert.AreEqual("additional", result.AdditionalDetail);
            Assert.AreEqual(true, result.Cashless);
            Assert.AreEqual(true, result.DepositTaking);
            Assert.AreEqual(true, result.HandicapAccess);
            Assert.AreEqual(true, result.LimitedTransactions);
            Assert.AreEqual(true, result.MilitaryIdrequired);
            Assert.AreEqual(true, result.OnMilitaryBase);
            Assert.AreEqual(true, result.RestrictedAccess);
            Assert.AreEqual(true, result.SelfServiceOnly);
            Assert.AreEqual(true, result.Surcharge);
        }

        [TestMethod]
        public void LocationsContactSpecialQualitiesViewModel_Index_Should_Pass()
        {
            // Arrange

            // Act

            // Reset

            // Assert
        }
    }
}
